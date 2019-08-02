using Newtonsoft.Json;
using static Agilite.Models.BaseModel;

namespace Agilite.Models
{
    public static class NumberingModel
    {
        public class Result : BaseResult
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public ResultData Data { get; set; }
        }

        public class ResultData : BaseResultData
        {
            [JsonProperty(PropertyName = "isHidden", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsHidden { get; set; }

            [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty(PropertyName = "prefix", NullValueHandling = NullValueHandling.Ignore)]
            public string Prefix { get; set; }

            [JsonProperty(PropertyName = "suffix", NullValueHandling = NullValueHandling.Ignore)]
            public string Suffix { get; set; }

            [JsonProperty(PropertyName = "startAt", NullValueHandling = NullValueHandling.Ignore)]
            public int? StartAt { get; set; }

            [JsonProperty(PropertyName = "incrementBasedOn", NullValueHandling = NullValueHandling.Ignore)]
            public int? IncrementBasedOn { get; set; }

            [JsonProperty(PropertyName = "minLength", NullValueHandling = NullValueHandling.Ignore)]
            public int? MinLength { get; set; }
        }
    }
}