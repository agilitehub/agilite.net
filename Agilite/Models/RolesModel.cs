using System.Collections.Generic;
using Newtonsoft.Json;

namespace Agilite.Models
{
    public static class RolesModel
    {
        public class AssignRolesResult
        {
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
            public List<User> Users { get; set; }
        }

        public class User
        {
            [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
            public string Email { get; set; }
        }

        public class AssignRoleResult
        {
            [JsonProperty("hasChanged", NullValueHandling = NullValueHandling.Ignore)]
            public bool? HasChanged { get; set; }

            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }
        }

        public class RolesResult
        {
            [JsonProperty("roleIds", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> RoleIds { get; set; }

            [JsonProperty("responsibleUsers", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> ResponsibleUsers { get; set; }
        }

        public class Result : BaseModel.BaseResult
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public ResultData Data { get; set; }
        }

        public class ResultData
        {
            [JsonProperty("responsibleUser", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> ResponsibleUser { get; set; }

            [JsonProperty("levels", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Levels { get; set; }

            [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsActive { get; set; }

            [JsonProperty("isHidden", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsHidden { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
            public string GroupName { get; set; }

            [JsonProperty("surrogateUser", NullValueHandling = NullValueHandling.Ignore)]
            public string SurrogateUser { get; set; }
        }
    }
}