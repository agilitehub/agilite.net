using System.Collections.Generic;
using Agilite.Models;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class Bpm.
    ///     Implements the <see cref="Agilite.Library.CrudRequests" />
    /// </summary>
    /// <seealso cref="Agilite.Library.CrudRequests" />
    public class Bpm : CrudRequests
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Bpm" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public Bpm(AgiliteRequestConfig config) : base(config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.Bpm;
        }

        /// <summary>
        ///     Registers the BPM record dynamic.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <param name="currentUser">The current user.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> RegisterBpmRecordDynamic(string processKey = "", string currentUser = "")
        {
            return Base.SetReturnObject<dynamic>(RegisterBpmRecord(processKey, currentUser));
        }

        /// <summary>
        ///     Registers the BPM record object.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <param name="currentUser">The current user.</param>
        /// <returns>ReturnObject&lt;BpmModel.RecordResult&gt;.</returns>
        public ReturnObject<BpmModel.RecordResult> RegisterBpmRecordObject(string processKey = "", string currentUser = "")
        {
            return Base.SetReturnObject<BpmModel.RecordResult>(RegisterBpmRecord(processKey, currentUser));
        }

        /// <summary>
        ///     Executes the dynamic.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <param name="bpmRecordId">The BPM record identifier.</param>
        /// <param name="optionSelected">The option selected.</param>
        /// <param name="currentUser">The current user.</param>
        /// <param name="comments">The comments.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> ExecuteDynamic(string processKey = "", string bpmRecordId = "", string optionSelected = "", string currentUser = "", string comments = "", ParamStringObject data = null)
        {
            return Base.SetReturnObject<dynamic>(Execute(processKey, bpmRecordId, optionSelected, currentUser, comments, data));
        }

        /// <summary>
        ///     Executes the object.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <param name="bpmRecordId">The BPM record identifier.</param>
        /// <param name="optionSelected">The option selected.</param>
        /// <param name="currentUser">The current user.</param>
        /// <param name="comments">The comments.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;BpmModel.ExecuteResult&gt;.</returns>
        public ReturnObject<BpmModel.ExecuteResult> ExecuteObject(string processKey = "", string bpmRecordId = "", string optionSelected = "", string currentUser = "", string comments = "", ParamStringObject data = null)
        {
            return Base.SetReturnObject<BpmModel.ExecuteResult>(Execute(processKey, bpmRecordId, optionSelected, currentUser, comments, data));
        }

        /// <summary>
        ///     Gets the record state dynamic.
        /// </summary>
        /// <param name="processKeys">The process keys.</param>
        /// <param name="bpmRecordIds">The BPM record ids.</param>
        /// <param name="stepNames">The step names.</param>
        /// <param name="responsibleUsers">The responsible users.</param>
        /// <param name="relevantUsers">The relevant users.</param>
        /// <param name="includeHistory">if set to <c>true</c> [include history].</param>
        /// <param name="includeStepOptions">if set to <c>true</c> [include step options].</param>
        /// <param name="includeVisibleObjects">if set to <c>true</c> [include visible objects].</param>
        /// <param name="page">The page.</param>
        /// <param name="pageLimit">The page limit.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> GetRecordStateDynamic(List<string> processKeys = null, List<string> bpmRecordIds = null, List<string> stepNames = null, List<string> responsibleUsers = null, List<string> relevantUsers = null, bool includeHistory = true, bool includeStepOptions = true, bool includeVisibleObjects = true, string page = "undefined", string pageLimit = "undefined")
        {
            return Base.SetReturnObject<dynamic>(GetRecordState(processKeys, bpmRecordIds, stepNames, responsibleUsers, relevantUsers, includeHistory, includeStepOptions, includeVisibleObjects, page, pageLimit));
        }

        /// <summary>
        ///     Gets the record state object.
        /// </summary>
        /// <param name="processKeys">The process keys.</param>
        /// <param name="bpmRecordIds">The BPM record ids.</param>
        /// <param name="stepNames">The step names.</param>
        /// <param name="responsibleUsers">The responsible users.</param>
        /// <param name="relevantUsers">The relevant users.</param>
        /// <param name="includeHistory">if set to <c>true</c> [include history].</param>
        /// <param name="includeStepOptions">if set to <c>true</c> [include step options].</param>
        /// <param name="includeVisibleObjects">if set to <c>true</c> [include visible objects].</param>
        /// <param name="page">The page.</param>
        /// <param name="pageLimit">The page limit.</param>
        /// <returns>ReturnObject&lt;BpmModel.RecordStateResult&gt;.</returns>
        public ReturnObject<BpmModel.RecordStateResult> GetRecordStateObject(List<string> processKeys = null, List<string> bpmRecordIds = null, List<string> stepNames = null, List<string> responsibleUsers = null, List<string> relevantUsers = null, bool includeHistory = true, bool includeStepOptions = true, bool includeVisibleObjects = true, string page = "undefined", string pageLimit = "undefined")
        {
            return Base.SetReturnObject<BpmModel.RecordStateResult>(GetRecordState(processKeys, bpmRecordIds, stepNames, responsibleUsers, relevantUsers, includeHistory, includeStepOptions, includeVisibleObjects, page, pageLimit));
        }

        /// <summary>
        ///     Gets the by profile key dynamic.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> GetByProfileKeyDynamic(string profileKey)
        {
            return Base.SetReturnObject<dynamic>(GetByProfileKey(profileKey));
        }

        /// <summary>
        ///     Gets the by profile key object.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <returns>ReturnObject&lt;BpmModel.ProfileKeyResult&gt;.</returns>
        public ReturnObject<BpmModel.ProfileKeyResult> GetByProfileKeyObject(string profileKey)
        {
            return Base.SetReturnObject<BpmModel.ProfileKeyResult>(GetByProfileKey(profileKey));
        }

        /// <summary>
        ///     Clears the history data.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> ClearHistoryData(string profileKey = "")
        {
            _agiliteConfig.Function = Constants.Functions.Bpm.ClearHistoryData;
            _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, profileKey);
            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Gets the profile keys by group.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <returns>ReturnObject&lt;List&lt;System.String&gt;&gt;.</returns>
        public ReturnObject<List<string>> GetProfileKeysByGroup(string processKey = "")
        {
            _agiliteConfig.Function = Constants.Functions.Bpm.GetActiveSteps;
            _agiliteConfig.Headers.Add(Constants.Header.ProcessKey, processKey);
            return Base.SetReturnObject<List<string>>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Gets the active users.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <returns>ReturnObject&lt;List&lt;System.String&gt;&gt;.</returns>
        public ReturnObject<List<string>> GetActiveUsers(string processKey = "")
        {
            _agiliteConfig.Function = Constants.Functions.Bpm.GetActiveUsers;
            _agiliteConfig.Headers.Add(Constants.Header.ProcessKey, processKey);
            return Base.SetReturnObject<List<string>>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }


        /// <summary>
        ///     Gets the by profile key.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <returns>AgiliteResponse.</returns>
        private AgiliteResponse GetByProfileKey(string profileKey)
        {
            _agiliteConfig.Function = Constants.Functions.Bpm.GetByProfileKey;
            _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, profileKey);

            return AgiliteRequest.ExecuteRequest(_agiliteConfig).Result;
        }

        /// <summary>
        ///     Registers the BPM record.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <param name="currentUser">The current user.</param>
        /// <returns>AgiliteResponse.</returns>
        private AgiliteResponse RegisterBpmRecord(string processKey, string currentUser)
        {
            _agiliteConfig.Function = Constants.Functions.Bpm.RegisterBpmRecord;
            _agiliteConfig.Headers.Add(Constants.Header.CurrentUser, currentUser);
            _agiliteConfig.Headers.Add(Constants.Header.ProcessKey, processKey);

            return AgiliteRequest.ExecuteRequest(_agiliteConfig).Result;
        }

        /// <summary>
        ///     Gets the state of the record.
        /// </summary>
        /// <param name="processKeys">The process keys.</param>
        /// <param name="bpmRecordIds">The BPM record ids.</param>
        /// <param name="stepNames">The step names.</param>
        /// <param name="responsibleUsers">The responsible users.</param>
        /// <param name="relevantUsers">The relevant users.</param>
        /// <param name="includeHistory">if set to <c>true</c> [include history].</param>
        /// <param name="includeStepOptions">if set to <c>true</c> [include step options].</param>
        /// <param name="includeVisibleObjects">if set to <c>true</c> [include visible objects].</param>
        /// <param name="page">The page.</param>
        /// <param name="pageLimit">The page limit.</param>
        /// <returns>AgiliteResponse.</returns>
        private AgiliteResponse GetRecordState(List<string> processKeys = null, List<string> bpmRecordIds = null, List<string> stepNames = null, List<string> responsibleUsers = null, List<string> relevantUsers = null, bool includeHistory = true, bool includeStepOptions = true, bool includeVisibleObjects = true, string page = null, string pageLimit = null)
        {
            processKeys = processKeys ?? new List<string>();
            bpmRecordIds = bpmRecordIds ?? new List<string>();
            stepNames = stepNames ?? new List<string>();
            responsibleUsers = responsibleUsers ?? new List<string>();
            relevantUsers = relevantUsers ?? new List<string>();

            _agiliteConfig.Function = Constants.Functions.Bpm.GetRecordState;
            _agiliteConfig.Headers.Add(Constants.Header.ProcessKey, string.Join(Constants.SeparatorComma, processKeys));
            _agiliteConfig.Headers.Add(Constants.Header.BpmRecordId, string.Join(Constants.SeparatorComma, bpmRecordIds));
            _agiliteConfig.Headers.Add(Constants.Header.StepNames, string.Join(Constants.SeparatorComma, stepNames));
            _agiliteConfig.Headers.Add(Constants.Header.ResponsibleUsers, string.Join(Constants.SeparatorComma, responsibleUsers));
            _agiliteConfig.Headers.Add(Constants.Header.RelevantUsers, string.Join(Constants.SeparatorComma, relevantUsers));
            _agiliteConfig.Headers.Add(Constants.Header.IncludeHistory, includeHistory.ToString());
            _agiliteConfig.Headers.Add(Constants.Header.IncludeStepOptions, includeStepOptions.ToString());
            _agiliteConfig.Headers.Add(Constants.Header.IncludeVisibleObjects, includeVisibleObjects.ToString());
            _agiliteConfig.Headers.Add(Constants.Header.Page, page);
            _agiliteConfig.Headers.Add(Constants.Header.PageLimit, pageLimit);

            return AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Get);
        }

        /// <summary>
        ///     Executes the specified process key.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <param name="bpmRecordId">The BPM record identifier.</param>
        /// <param name="optionSelected">The option selected.</param>
        /// <param name="currentUser">The current user.</param>
        /// <param name="comments">The comments.</param>
        /// <param name="data">The data.</param>
        /// <returns>AgiliteResponse.</returns>
        private AgiliteResponse Execute(string processKey = "", string bpmRecordId = "", string optionSelected = "", string currentUser = "", string comments = "", ParamStringObject data = null)
        {
            _agiliteConfig.Function = Constants.Functions.Bpm.Execute;
            _agiliteConfig.Headers.Add(Constants.Header.ProcessKey, processKey);
            _agiliteConfig.Headers.Add(Constants.Header.BpmRecordId, bpmRecordId);
            _agiliteConfig.Headers.Add(Constants.Header.OptionSelected, optionSelected);
            _agiliteConfig.Headers.Add(Constants.Header.CurrentUser, currentUser);
            _agiliteConfig.Headers.Add(Constants.Header.Comments, comments);

            return AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data);
        }
    }
}