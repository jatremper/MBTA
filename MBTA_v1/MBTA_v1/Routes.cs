using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTA_v1
{
    class Routes
    {
        [JsonProperty("mode")]
        public List<Mode> modes { get; set; }

        public void printRoutes()
        {
            Console.WriteLine("Routes:");
            foreach (Mode m in modes)
                if (m.name == "Subway")
                    foreach (Route r in m.routes)
                        Console.WriteLine(r.name);
        }
    }
}
