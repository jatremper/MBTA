using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class Vehicle
    {
        [JsonProperty("vehicle_id")]
        public string id { get; set; }
        [JsonProperty("vehicle_lat")]
        public string lat { get; set; }
        [JsonProperty("vehicle_lon")]
        public string lon { get; set; }
        [JsonProperty("vehicle_bearing")]
        public string bearing { get; set; }
        [JsonProperty("vehicle_timestamp")]
        public string timestamp { get; set; }
    }
}
