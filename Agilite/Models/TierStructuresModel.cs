
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Agilite.Models
{
    public static class TierStructuresModel
    {
        public class Result : BaseModel.BaseResult
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public ResultData Data { get; set; }
        }

        public class ResultByKey : BaseModel.BaseResult
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public ResultDataByKey Data { get; set; }
        }

        public class ResultData
        {
            [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
            public List<BaseModel.ResultDataValues> Values { get; set; }

            [JsonProperty("tierEntries", NullValueHandling = NullValueHandling.Ignore)]
            public List<ResultData> TierEntries { get; set; }

            [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsActive { get; set; }

            [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
            public string Key { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
            public string Notes { get; set; }

            [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }
        }

        public class ResultDataByKey
        {
            [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
            public List<BaseModel.ResultDataValues> Values { get; set; }

            [JsonProperty("tierEntries", NullValueHandling = NullValueHandling.Ignore)]
            public List<ResultData> TierEntries { get; set; }

            [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsActive { get; set; }

            [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
            public string Key { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
            public string Notes { get; set; }

            [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }
        }
    }
}