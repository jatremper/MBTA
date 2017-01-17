using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class Direction
    {
        [JsonProperty("direction_id")]
        public string ID { get; set; }
        [JsonProperty("direction_name")]
        public string name { get; set; }
        [JsonProperty("trip")]
        public List<Trip> trips { get; set; }
    }
}
