using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class Predictions
    {
        [JsonProperty("stop_id")]
        public string stopID { get; set; }
        [JsonProperty("stop_name")]
        public string stopName { get; set; }
        [JsonProperty("mode")]
        public List<Mode> modes { get; set; }
        [JsonProperty("alert_headers")]
        public List<Alert> alerts { get; set; }

        public void printETAs()
        {
            Console.WriteLine("\r\nMode:\tRoute:\tDirection:\tDest:\tETA:");
            foreach (Mode m in modes)
            {
                foreach (Route r in m.routes)
                {
                    foreach (Direction d in r.directions)
                    {
                        foreach (Trip t in d.trips)
                        {
                            int minutesOut = int.Parse(t.ETA) / 60;
                            int secondsOut = int.Parse(t.ETA) % 60;
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}:{5}", m.name, r.name, d.name, t.headsign, minutesOut.ToString("D2"), secondsOut.ToString("D2"));
                        }
                    }
                }
            }
        }
    }
}
