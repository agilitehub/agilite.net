namespace Agilite
{
    internal static class Constants
    {
        public const string UrlApiServer = "https://api.agilite.io";
        public const string StringData = "data";
        public const string SeparatorComma = ",";
        public const string Uri = "uri";
        public const string Url = "url";
        public const string SortAsc = "asc";
        public const string SortDesc = "desc";
        public const string SortAscValue = "asc_value";
        public const string SortDescValue = "desc_value";
        public const string Method = "method";

        public static class Header
        {
            public const string StartDate = "start-date";
            public const string EndDate = "end-date";
            public const string IncludeModules = "include-modules";
            public const string ApiKey = "api-key";
            public const string TeamName = "team-name";
            public const string ContentType = "Content-Type";
            public const string ProfileKey = "profile-key";
            public const string ProfileKeys = "profile-keys";
            public const string RouteKey = "route-key";
            public const string ProcessKey = "process-key";
            public const string ProcessKeys = "process-keys";
            public const string BpmRecordId = "bpm-record-id";
            public const string BpmRecordIds = "bpm-record-ids";
            public const string StepNames = "step-names";
            public const string RecordId = "record-id";
            public const string RecordIds = "record-ids";
            public const string RoleName = "role-name";
            public const string RoleNames = "role-names";
            public const string ConditionalLevels = "conditional-levels";
            public const string SlimResult = "slim-result";
            public const string Publish = "publish";
            public const string ResetService = "reset-service";
            public const string CurrentUser = "current-user";
            public const string OptionSelected = "option-selected";
            public const string Comments = "comments";
            public const string DateTimeValue = "date-time-value";
            public const string FormatKey = "format-key";
            public const string ResponsibleUser = "responsible-user";
            public const string ResponsibleUsers = "responsible-users";
            public const string RelevantUsers = "relevant-users";
            public const string IncludeHistory = "include-history";
            public const string IncludeStepOptions = "include-step-options";
            public const string IncludeVisibleObjects = "include-visible-objects";
            public const string Page = "page";
            public const string PageLimit = "page-limit";
            public const string ApplicationJson = "application/json";
            public const string ApplicationOctet = "application/octet-stream";
            public const string TextPlain = "text/plain";
            public const string Sort = "sort";
            public const string OutputFormat = "output-format";
            public const string GroupName = "group-name";
            public const string ValueKey = "value-key";
            public const string LabelKey = "label-key";
            public const string FileId = "file-id";
            public const string FileName = "file-name";
            public const string TierKeys = "tier-keys";
            public const string IncludeValues = "include-values";
            public const string IncludeMetaData = "include-meta-data";
            public const string IncludeTierEntries = "include-tier-entries";
            public const string SortValues = "sort-values";
            public const string ValuesOutputFormat = "values-output-format";
        }

        public static class Methods
        {
            public const string Delete = "delete";
            public const string Get = "get";
            public const string Post = "post";
            public const string Put = "put";
            public const string Upload = "upload";
            public const string FileGet = "fileGet";
        }

        public static class ModuleKey
        {
            public const string ApiKeys = "apikeys";
            public const string Keywords = "keywords";
            public const string Numbering = "numbering";
            public const string Connectors = "connectors";
            public const string DataMapping = "datamappings";
            public const string Templates = "templates";
            public const string Bpm = "bpm";
            public const string Roles = "roles";
            public const string BotBuilder = "botbuilder";
            public const string TierStructures = "tierstructures";
            public const string Files = "files";
            public const string Utils = "utils";
            public const string Reports = "reports";
            public const string Admin = "admin";
        }

        public static class Value
        {
            public const string ArrayProper = "Array";
            public const string ArrayLower = "array";
            public const string ObjectProper = "Object";
            public const string StringLower = "string";
            public const string NumberLower = "number";
            public const string BooleanLower = "boolean";
            public const string JsonLower = "json";
        }

        public static class ResponseType
        {
            public const string ArrayBuffer = "arraybuffer";
            public const string Blob = "blob";
            public const string Document = "document";
            public const string Json = "json";
            public const string Text = "text";
            public const string Stream = "stream";
        }

        public static class Functions
        {
            public static class Keywords
            {
                public const string GetProfileKey = "getByProfileKey";
                public const string GetProfileKeysByGroup = "getProfileKeysByGroup";
                public const string GetLabelByValue = "getLabelByValue";
                public const string GetValueByLabel = "getValueByLabel";
            }

            public static class Numbering
            {
                public const string Generate = "generate";
                public const string ResetCounters = "resetCounters";
            }

            public static class Connectors
            {
                public const string Execute = "execute";
            }

            public static class DataMapping
            {
                public const string Execute = "execute";
            }

            public static class Templates
            {
                public const string Execute = "execute";
            }

            public static class Bpm
            {
                public const string RegisterBpmRecord = "registerBPMRecord";
                public const string Execute = "execute";
                public const string GetRecordState = "getRecordState";
                public const string GetByProfileKey = "getByProfileKey";
                public const string ClearHistoryData = "clearHistoryData";
                public const string GetActiveSteps = "getActiveSteps";
                public const string GetActiveUsers = "getActiveUsers";
            }

            public static class Roles
            {
                public const string AssignRole = "assignRole";
                public const string GetAssignedRoles = "getAssignedRoles";
                public const string GetRole = "getRole";
                public const string ChangeConditionalLevels = "changeConditionalLevels";
                public const string ReAssignResponsibleUser = "reAssignResponsibleUser";
            }

            public static class Utils
            {
                public const string EncodeXml = "encodeXML";
                public const string DecodeXml = "decodeXML";
                public const string XmlToJs = "XMLToJS";
                public const string JsToXml = "JSToXML";
                public const string Html2Json = "html2json";
                public const string GeneratePdf = "generatePDF";
                public const string GenerateUuid = "generateUUID";
                public const string FormatDateTime = "formatDateTime";
            }

            public static class Files
            {
                public const string GetFileName = "getFileName";
            }

            public static class TierStructuresFunctions
            {
                public const string GetTierByKey = "getTierByKey";
            }
        }
    }
}