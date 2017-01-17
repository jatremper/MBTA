using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class Trip
    {
        [JsonProperty("trip_id")]
        public string ID { get; set; }
        [JsonProperty("trip_name")]
        public string name { get; set; }
        [JsonProperty("trip_headsign")]
        public string headsign { get; set; }
        [JsonProperty("sch_arr_dt")]
        public string schArrTime { get; set; }
        [JsonProperty("sch_dep_dt")]
        public string schDepTime { get; set; }
        [JsonProperty("pre_dt")]
        public string preTime { get; set; }
        [JsonProperty("pre_away")]
        public string ETA { get; set; }
        [JsonProperty("vehicle")]
        public Vehicle vehicle { get; set; }
    }
}
