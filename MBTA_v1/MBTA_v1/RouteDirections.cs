using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class RouteDirections
    {
        [JsonProperty("direction")]
        public List<RouteDirection> directions { get; set; }
    }
}
