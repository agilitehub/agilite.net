
using Newtonsoft.Json;

namespace Agilite.Models
{
    public static class FileModel
    {
        public class FileData
        {
            public string Data { get; set; }
        }

        public class FileResult : BaseModel.BaseResult
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data { get; set; }
        }

        public class Data
        {
            [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
            public string FileName { get; set; }

            [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
            public string ParentId { get; set; }

            [JsonProperty("contentType", NullValueHandling = NullValueHandling.Ignore)]
            public string ContentType { get; set; }
        }
    }
}