using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class Route
    {
        [JsonProperty("route_id")]
        public string ID { get; set; }
        [JsonProperty("route_name")]
        public string name { get; set; }
        [JsonProperty("direction")]
        public List<Direction> directions { get; set; }
    }
}
