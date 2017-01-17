using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class RouteDirection
    {
        [JsonProperty("direction_id")]
        public string ID { get; set; }
        [JsonProperty("direction_name")]
        public string name { get; set; }
        [JsonProperty("stop")]
        public List<Stop> stops { get; set; }
    }
}
