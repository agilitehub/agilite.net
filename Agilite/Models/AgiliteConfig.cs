using System.Collections.Generic;
using Newtonsoft.Json;

namespace Agilite.Models
{
    public class AgiliteConfig
    {
        public string ApiServerUrl { get; set; } = Constants.UrlApiServer;
        public string ApiKey { get; set; } = "No Key Provided";
        public string TeamId { get; set; }
#if NETCOREAPP1_0
#elif NETCOREAPP1_1
#else
        public string ProxyAddress { get; set; }
        public string ProxyUsername { get; set; }
        public string ProxyPassword { get; set; }
#endif


    }

    public class AgiliteRequestConfig
    {
        [JsonProperty(PropertyName = Constants.Uri)]
        public string Uri { get; set; }

        [JsonProperty(PropertyName = Constants.Url)]
        public string Url { get; set; }

        [JsonProperty(PropertyName = Constants.Method)]
        public string Method { get; set; } = Constants.Methods.Get;

        public string Module { get; set; }
        public string Function { get; set; }
        public bool Publish { get; set; } = false;

        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        public AgiliteConfig AgiliteConfig { get; set; }
    }
}