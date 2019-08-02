using System.Collections.Generic;
using Newtonsoft.Json;
using static Agilite.Models.BaseModel;

namespace Agilite.Models
{
    public static class KeywordsModel
    {
        public class Result : BaseResult
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public ResultData Data { get; set; }
        }

        public class ResultData : BaseResultData
        {
            [JsonProperty(PropertyName = "values", NullValueHandling = NullValueHandling.Ignore)]
            public List<ResultDataValues> Values { get; set; } = new List<ResultDataValues>();
        }
    }
}