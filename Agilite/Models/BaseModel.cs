using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace Agilite.Models {
    public static class BaseModel
    {
        public class AgiliteError
        {
            [JsonProperty(PropertyName = "statusCode")]
            public string StatusCode { get; set; }

            [JsonProperty(PropertyName = "errorMessage")]
            public string ErrorMessage { get; set; }

            [JsonProperty(PropertyName = "additionalMessages")]
            public List<string> AdditionalMessages { get; set; }
        }

        public class BaseResponse
        {
            public bool IsSuccess => Error == null;
            public AgiliteError Error { get; set; }
        }

        public class BaseResultData
        {
            [JsonProperty(PropertyName = "key", NullValueHandling = NullValueHandling.Ignore)]
            public string Key { get; set; }

            [JsonProperty(PropertyName = "groupName", NullValueHandling = NullValueHandling.Ignore)]
            public string GroupName { get; set; }

            [JsonProperty(PropertyName = "isActive", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsActive { get; set; }
        }

        public class BaseResult
        {
            [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
            public string CreatedBy { get; set; }

            [JsonProperty("modifiedBy", NullValueHandling = NullValueHandling.Ignore)]
            public string ModifiedBy { get; set; }

            [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime UpdatedAt { get; set; }

            [JsonProperty("__v", NullValueHandling = NullValueHandling.Ignore)]
            public string Version { get; set; }
        }

        public class AgiliteResponse
        {
            public string StringResponse { get; set; }
            public HttpResponseMessage AgiliteResponseMessage { get; set; }
            public AgiliteError Error { get; set; } = null;

            public MyAwaiter GetAwaiter()
            {
                return new MyAwaiter();
            }
        }

        public struct MyAwaiter :   INotifyCompletion
        {
            public void OnCompleted(Action continuation)
            {
                continuation();
            }
        }

        public class ResultDataValues
        {
            [JsonProperty(PropertyName = "label", NullValueHandling = NullValueHandling.Ignore)]
            public string Label { get; set; }

            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore)]
            public string Value { get; set; }
        }

        public class ParamStringObject
        {
            [JsonProperty(PropertyName = "param1", NullValueHandling = NullValueHandling.Ignore)]
            public string Param1 { get; set; }

            [JsonProperty(PropertyName = "param2", NullValueHandling = NullValueHandling.Ignore)]
            public string Param2 { get; set; }
        }

        public class ReturnObject<T> : BaseResponse
        {
            public T ResponseData { get; set; }
        }
    }
}