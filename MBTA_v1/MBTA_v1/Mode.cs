using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class Mode
    {
        [JsonProperty("route_type")]
        public string routeType { get; set; }
        [JsonProperty("mode_name")]
        public string name { get; set; }
        [JsonProperty("route")]
        public List<Route> routes { get; set; }
    }
}
