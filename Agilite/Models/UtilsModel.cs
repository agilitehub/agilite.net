
using Newtonsoft.Json;

namespace Agilite.Models
{
    public static class UtilsModel
    {
        public class GeneratePdfResult : BaseModel.BaseResult
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data { get; set; }
        }

        public class Data
        {
            [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
            public string FileName { get; set; }

            [JsonProperty("contentType", NullValueHandling = NullValueHandling.Ignore)]
            public string ContentType { get; set; }
        }
    }
}