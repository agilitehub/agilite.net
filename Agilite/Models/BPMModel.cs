using System.Collections.Generic;
using Newtonsoft.Json;

namespace Agilite.Models
{
    public static class BpmModel
    {
        public class ProfileKeyResult
        {
            [JsonProperty("processSteps", NullValueHandling = NullValueHandling.Ignore)]
            public List<ProcessStep> ProcessSteps { get; set; }

            [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsActive { get; set; }

            [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
            public string Key { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
            public string GroupName { get; set; }

            [JsonProperty("appUrl", NullValueHandling = NullValueHandling.Ignore)]
            public string AppUrl { get; set; }

            [JsonProperty("referenceUrl", NullValueHandling = NullValueHandling.Ignore)]
            public string ReferenceUrl { get; set; }

            [JsonProperty("appAdmin", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> AppAdmin { get; set; }

            [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
            public string Notes { get; set; }
        }

        public class ProcessStep
        {
            [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("isNewEntry", NullValueHandling = NullValueHandling.Ignore)]
            public string IsNewEntry { get; set; }

            [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
            public string IsActive { get; set; }

            [JsonProperty("firstStep", NullValueHandling = NullValueHandling.Ignore)]
            public string FirstStep { get; set; }

            [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
            public string Key { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("instructions", NullValueHandling = NullValueHandling.Ignore)]
            public string Instructions { get; set; }

            [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
            public string Duration { get; set; }

            [JsonProperty("processStage", NullValueHandling = NullValueHandling.Ignore)]
            public string ProcessStage { get; set; }

            [JsonProperty("responsibility", NullValueHandling = NullValueHandling.Ignore)]
            public string Responsibility { get; set; }

            [JsonProperty("responsibleRole", NullValueHandling = NullValueHandling.Ignore)]
            public string ResponsibleRole { get; set; }

            [JsonProperty("roleLevels", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> RoleLevels { get; set; }

            [JsonProperty("visibleObjects", NullValueHandling = NullValueHandling.Ignore)]
            public List<VisibleObject> VisibleObjects { get; set; }

            [JsonProperty("stepOptions", NullValueHandling = NullValueHandling.Ignore)]
            public List<StepOption> StepOptions { get; set; }

            [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
            public string Notes { get; set; }

            [JsonProperty("referenceUrl", NullValueHandling = NullValueHandling.Ignore)]
            public string ReferenceUrl { get; set; }

            [JsonProperty("isActiveDescription", NullValueHandling = NullValueHandling.Ignore)]
            public string IsActiveDescription { get; set; }

            [JsonProperty("isFirstStepDescription", NullValueHandling = NullValueHandling.Ignore)]
            public string IsFirstStepDescription { get; set; }
        }

        public class StepOption
        {
            [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("isNewEntry", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsNewEntry { get; set; }

            [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsActive { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("nextStep", NullValueHandling = NullValueHandling.Ignore)]
            public string NextStep { get; set; }

            [JsonProperty("visibleObjects", NullValueHandling = NullValueHandling.Ignore)]
            public List<VisibleObject> VisibleObjects { get; set; }

            [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
            public string Notes { get; set; }

            [JsonProperty("isActiveDescription", NullValueHandling = NullValueHandling.Ignore)]
            public string IsActiveDescription { get; set; }
        }

        public class RecordStateResult
        {
            [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
            public string Key { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("instructions", NullValueHandling = NullValueHandling.Ignore)]
            public string Instructions { get; set; }

            [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
            public int Duration { get; set; }

            [JsonProperty("processStage", NullValueHandling = NullValueHandling.Ignore)]
            public string ProcessStage { get; set; }

            [JsonProperty("responsibleRole", NullValueHandling = NullValueHandling.Ignore)]
            public string ResponsibleRole { get; set; }

            [JsonProperty("visibleObjects", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> VisibleObjects { get; set; }

            [JsonProperty("stepOptions", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> StepOptions { get; set; }

            [JsonProperty("referenceUrl", NullValueHandling = NullValueHandling.Ignore)]
            public string ReferenceUrl { get; set; }

            [JsonProperty("recordId", NullValueHandling = NullValueHandling.Ignore)]
            public string RecordId { get; set; }

            [JsonProperty("responsibleUsers", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> ResponsibleUsers { get; set; }

            [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> History { get; set; }

            [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
            public List<Role> Roles { get; set; }

            [JsonProperty("eventStampHistory", NullValueHandling = NullValueHandling.Ignore)]
            public List<EventStampHistory> EventStampHistory { get; set; }

            [JsonProperty("submittedIntoStep", NullValueHandling = NullValueHandling.Ignore)]
            public string SubmittedIntoStep { get; set; }

            [JsonProperty("targetTimeDuration", NullValueHandling = NullValueHandling.Ignore)]
            public string TargetTimeDuration { get; set; }
        }

        public class ExecuteResult
        {
            [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("isNewEntry", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsNewEntry { get; set; }

            [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsActive { get; set; }

            [JsonProperty("firstStep", NullValueHandling = NullValueHandling.Ignore)]
            public bool? FirstStep { get; set; }

            [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
            public string Key { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("instructions", NullValueHandling = NullValueHandling.Ignore)]
            public string Instructions { get; set; }

            [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
            public string Duration { get; set; }

            [JsonProperty("processStage", NullValueHandling = NullValueHandling.Ignore)]
            public string ProcessStage { get; set; }

            [JsonProperty("responsibility", NullValueHandling = NullValueHandling.Ignore)]
            public string Responsibility { get; set; }

            [JsonProperty("responsibleRole", NullValueHandling = NullValueHandling.Ignore)]
            public string ResponsibleRole { get; set; }

            [JsonProperty("eventStamp", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> EventStamp { get; set; }

            [JsonProperty("roleLevels", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> RoleLevels { get; set; }

            [JsonProperty("visibleObjects", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> VisibleObjects { get; set; }

            [JsonProperty("stepOptions", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> StepOptions { get; set; }

            [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
            public string Notes { get; set; }

            [JsonProperty("referenceUrl", NullValueHandling = NullValueHandling.Ignore)]
            public string ReferenceUrl { get; set; }

            [JsonProperty("responsibleUsers", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> ResponsibleUsers { get; set; }

            [JsonProperty("submittedIntoStep", NullValueHandling = NullValueHandling.Ignore)]
            public string SubmittedIntoStep { get; set; }

            [JsonProperty("targetTimeDuration", NullValueHandling = NullValueHandling.Ignore)]
            public string TargetTimeDuration { get; set; }
        }

        public class RecordResult
        {
            [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
            public string Key { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("instructions", NullValueHandling = NullValueHandling.Ignore)]
            public string Instructions { get; set; }

            [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
            public int? Duration { get; set; }

            [JsonProperty("processStage", NullValueHandling = NullValueHandling.Ignore)]
            public string ProcessStage { get; set; }

            [JsonProperty("responsibleRole", NullValueHandling = NullValueHandling.Ignore)]
            public string ResponsibleRole { get; set; }

            [JsonProperty("visibleObjects", NullValueHandling = NullValueHandling.Ignore)]
            public List<VisibleObject> VisibleObjects { get; set; }

            [JsonProperty("stepOptions", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> StepOptions { get; set; }

            [JsonProperty("referenceUrl", NullValueHandling = NullValueHandling.Ignore)]
            public string ReferenceUrl { get; set; }

            [JsonProperty("isActiveDescription", NullValueHandling = NullValueHandling.Ignore)]
            public string IsActiveDescription { get; set; }

            [JsonProperty("isFirstStepDescription", NullValueHandling = NullValueHandling.Ignore)]
            public string IsFirstStepDescription { get; set; }

            [JsonProperty("responsibleUsers", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> ResponsibleUsers { get; set; }

            [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
            public List<History> History { get; set; }

            [JsonProperty("recordId", NullValueHandling = NullValueHandling.Ignore)]
            public string RecordId { get; set; }

            [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
            public List<Role> Roles { get; set; }

            [JsonProperty("eventStampHistory", NullValueHandling = NullValueHandling.Ignore)]
            public List<EventStampHistory> EventStampHistory { get; set; }
        }

        public class EventStampHistory
        {
            [JsonProperty("eventName", NullValueHandling = NullValueHandling.Ignore)]
            public string EventName { get; set; }

            [JsonProperty("timeStamp", NullValueHandling = NullValueHandling.Ignore)]
            public string TimeStamp { get; set; }
        }

        public class History
        {
            [JsonProperty("responsibleUsers", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> ResponsibleUsers { get; set; }

            [JsonProperty("eventStamp", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> EventStamp { get; set; }

            [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("processKey", NullValueHandling = NullValueHandling.Ignore)]
            public string ProcessKey { get; set; }

            [JsonProperty("recordId", NullValueHandling = NullValueHandling.Ignore)]
            public string RecordId { get; set; }

            [JsonProperty("currentUser", NullValueHandling = NullValueHandling.Ignore)]
            public string CurrentUser { get; set; }

            [JsonProperty("currentRole", NullValueHandling = NullValueHandling.Ignore)]
            public string CurrentRole { get; set; }

            [JsonProperty("processStage", NullValueHandling = NullValueHandling.Ignore)]
            public string ProcessStage { get; set; }

            [JsonProperty("submissionDate", NullValueHandling = NullValueHandling.Ignore)]
            public string SubmissionDate { get; set; }

            [JsonProperty("optionSelected", NullValueHandling = NullValueHandling.Ignore)]
            public string OptionSelected { get; set; }

            [JsonProperty("fromStep", NullValueHandling = NullValueHandling.Ignore)]
            public string FromStep { get; set; }

            [JsonProperty("fromStepName", NullValueHandling = NullValueHandling.Ignore)]
            public string FromStepName { get; set; }

            [JsonProperty("toStep", NullValueHandling = NullValueHandling.Ignore)]
            public string ToStep { get; set; }

            [JsonProperty("toStepName", NullValueHandling = NullValueHandling.Ignore)]
            public string ToStepName { get; set; }

            [JsonProperty("toProcessStage", NullValueHandling = NullValueHandling.Ignore)]
            public string ToProcessStage { get; set; }

            [JsonProperty("responsibleRole", NullValueHandling = NullValueHandling.Ignore)]
            public string ResponsibleRole { get; set; }

            [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
            public string Comments { get; set; }

            [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
            public string CreatedAt { get; set; }

            [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdatedAt { get; set; }

            [JsonProperty("__v", NullValueHandling = NullValueHandling.Ignore)]
            public string V { get; set; }
        }

        public class Role
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

        public class VisibleObject
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("isEditable", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsEditable { get; set; }

            [JsonProperty("isMandatory", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsMandatory { get; set; }

            [JsonProperty("inputOptions", NullValueHandling = NullValueHandling.Ignore)]
            public InputOptions InputOptions { get; set; }
        }

        public class InputOptions
        {
            [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
            public string Label { get; set; }

            [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
            public string Type { get; set; }

            [JsonProperty("choices", NullValueHandling = NullValueHandling.Ignore)]
            public List<Choice> Choices { get; set; }

            [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Messages { get; set; }
        }

        public class Choice
        {
            [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
            public string Label { get; set; }

            [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
            public string Value { get; set; }
        }
    }
}