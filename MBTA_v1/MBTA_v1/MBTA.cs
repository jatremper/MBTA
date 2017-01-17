using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace MBTA_v1
{
    class MBTA
    {
        private string url { get; set; }
        private string key { get; set; }
        private string format { get; set; }

        public MBTA(string pUrl, string pKey)
        {
            url = pUrl;
            key = pKey;
            format = "json";
        }

        public Routes GetRoutes()
        {
            Console.WriteLine("\r\nLoading routes...\r\n");

            string response = GetData("routes");
            Routes r = JsonConvert.DeserializeObject<Routes>(response);

            return r;
        }

        public DataTable GetStationsByRoute(string routeID)
        {
            Console.WriteLine("\r\nLoading stops...\r\n");

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");

            string response = GetData("stopsbyroute", "route=" + routeID);
            RouteDirections d = JsonConvert.DeserializeObject<RouteDirections>(response);

            RouteDirection direction = d.directions.First();

            foreach (Stop s in direction.stops)
                dt.Rows.Add(s.parent, s.parentName);

            return dt;
        }

        public DataTable GetStopsByLocation(string pLat, string pLon)
        {
            Console.WriteLine("\r\nLoading stops...\r\n");

            string response = GetData("stopsbylocation", "lat=" + pLat, "lon=" + pLon);
            DataSet ds = JsonConvert.DeserializeObject<DataSet>(response);

            return ds.Tables["stop"];
        }

        public Predictions GetPredictionsByStop(string pStop)
        {
            Console.WriteLine("\r\nLoading ETAs...\r\n");

            string response = GetData("predictionsbystop", "stop=" + pStop);
            Predictions p = JsonConvert.DeserializeObject<Predictions>(response);

            return p;
        }

        private string GetData(string pQuery, params string[] pParameters)
        {
            HttpWebRequest request;
            string response;

            string uri = url + pQuery;

            string parameters = "?api_key=" + key;
            foreach (string p in pParameters) { parameters += "&" + p; }
            parameters += "&format=" + format;
            
            request = (HttpWebRequest)WebRequest.Create(uri + parameters);
            using (HttpWebResponse r = (HttpWebResponse)request.GetResponse())
            using (Stream s = r.GetResponseStream())
            using (StreamReader sr = new StreamReader(s))
                response = sr.ReadToEnd();

            return response;
        }
    }
}
