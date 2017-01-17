using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class Alert
    {
        [JsonProperty("alert_id")]
        public int ID { get; set; }
        [JsonProperty("alert_text")]
        public string text { get; set; }
        [JsonProperty("effect_name")]
        public string effect { get; set; }
    }
}
