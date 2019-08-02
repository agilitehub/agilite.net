using Newtonsoft.Json;
using static Agilite.Models.BaseModel;

namespace Agilite.Models
{
    public static class TemplatesModel
    {
        public class Result : BaseResult
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public ResultData Data { get; set; }
        }

        public class ResultData : BaseResultData
        {
            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("templateType", NullValueHandling = NullValueHandling.Ignore)]
            public string TemplateType { get; set; }

            [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
            public string Mode { get; set; }

            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public string Data { get; set; }

            [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
            public string Theme { get; set; }
        }
    }
}