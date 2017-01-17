using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class Stop
    {
        [JsonProperty("stop_order")]
        public string order { get; set; }
        [JsonProperty("stop_id")]
        public string ID { get; set; }
        [JsonProperty("stop_name")]
        public string name { get; set; }
        [JsonProperty("parent_station")]
        public string parent { get; set; }
        [JsonProperty("parent_station_name")]
        public string parentName { get; set; }
        [JsonProperty("stop_lat")]
        public string lat { get; set; }
        [JsonProperty("stop_lon")]
        public string lon { get; set; }
    }
}
