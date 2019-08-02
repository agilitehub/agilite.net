using System.Collections.Generic;
using Agilite.Models;
using static Agilite.Models.BaseModel;


namespace Agilite.Library
{
    /// <summary>
    ///     Class Roles.
    ///     Implements the <see cref="Agilite.Library.CrudRequests" />
    /// </summary>
    /// <seealso cref="Agilite.Library.CrudRequests" />
    public class Roles : CrudRequests
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Roles" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public Roles(AgiliteRequestConfig config) : base(config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.Roles;
        }

        /// <summary>
        ///     Posts the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;RolesModel.Result&gt;.</returns>
        public ReturnObject<RolesModel.Result> PostData(RolesModel.ResultData data)
        {
            return Base.SetReturnObject<RolesModel.Result>(PostAgiliteData(data));
        }

        /// <summary>
        ///     Gets the data.
        /// </summary>
        /// <param name="profileKeys">The profile keys.</param>
        /// <param name="recordIds">The record ids.</param>
        /// <param name="slimResult">if set to <c>true</c> [slim result].</param>
        /// <returns>ReturnObject&lt;List&lt;RolesModel.Result&gt;&gt;.</returns>
        public ReturnObject<List<RolesModel.Result>> GetData(List<string> profileKeys = null, List<string> recordIds = null, bool slimResult = true)
        {
            return Base.SetReturnObject<List<RolesModel.Result>>(GetAgiliteData(profileKeys, recordIds, slimResult));
        }

        /// <summary>
        ///     Puts the data.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;RolesModel.Result&gt;.</returns>
        public ReturnObject<RolesModel.Result> PutData(string recordId, RolesModel.ResultData data = null)
        {
            return Base.SetReturnObject<RolesModel.Result>(PutAgiliteData(recordId, data));
        }

        /// <summary>
        ///     Deletes the data.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> DeleteData(string recordId = "")
        {
            return DeleteAgiliteData(recordId);
        }

        /// <summary>
        ///     Gets the role.
        /// </summary>
        /// <param name="roleNames">The role names.</param>
        /// <param name="conditionalLevels">The conditional levels.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;RolesModel.RolesResult&gt;.</returns>
        public ReturnObject<RolesModel.RolesResult> GetRole(List<string> roleNames = null, List<string> conditionalLevels = null, ParamStringObject data = null)
        {
            roleNames = roleNames ?? new List<string>();
            conditionalLevels = conditionalLevels ?? new List<string>();

            _agiliteConfig.Function = Constants.Functions.Roles.GetRole;
            _agiliteConfig.Headers.Add(Constants.Header.ConditionalLevels, string.Join(Constants.SeparatorComma, conditionalLevels));
            _agiliteConfig.Headers.Add(Constants.Header.RoleNames, string.Join(Constants.SeparatorComma, roleNames));

            return Base.SetReturnObject<RolesModel.RolesResult>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }

        /// <summary>
        ///     Assigns the role.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <param name="bpmRecordId">The BPM record identifier.</param>
        /// <param name="roleName">Name of the role.</param>
        /// <param name="currentUser">The current user.</param>
        /// <param name="responsibleUsers">The responsible users.</param>
        /// <returns>ReturnObject&lt;RolesModel.AssignRoleResult&gt;.</returns>
        public ReturnObject<RolesModel.AssignRoleResult> AssignRole(string processKey = "", string bpmRecordId = "", string roleName = "", string currentUser = "", List<string> responsibleUsers = null)
        {
            responsibleUsers = responsibleUsers ?? new List<string>();

            _agiliteConfig.Function = Constants.Functions.Roles.AssignRole;
            _agiliteConfig.Headers.Add(Constants.Header.ResponsibleUsers, string.Join(Constants.SeparatorComma, responsibleUsers));
            _agiliteConfig.Headers.Add(Constants.Header.ProcessKey, processKey);
            _agiliteConfig.Headers.Add(Constants.Header.BpmRecordId, bpmRecordId);
            _agiliteConfig.Headers.Add(Constants.Header.RoleName, roleName);
            _agiliteConfig.Headers.Add(Constants.Header.CurrentUser, currentUser);

            return Base.SetReturnObject<RolesModel.AssignRoleResult>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Gets the assigned roles.
        /// </summary>
        /// <param name="processKey">The process key.</param>
        /// <param name="bpmRecordId">The BPM record identifier.</param>
        /// <param name="roleNames">The role names.</param>
        /// <returns>ReturnObject&lt;List&lt;RolesModel.AssignRolesResult&gt;&gt;.</returns>
        public ReturnObject<List<RolesModel.AssignRolesResult>> GetAssignedRoles(string processKey = "", string bpmRecordId = "", List<string> roleNames = null)
        {
            roleNames = roleNames ?? new List<string>();

            _agiliteConfig.Function = Constants.Functions.Roles.GetAssignedRoles;
            _agiliteConfig.Headers.Add(Constants.Header.RoleNames, string.Join(Constants.SeparatorComma, roleNames));
            _agiliteConfig.Headers.Add(Constants.Header.ProcessKey, processKey);
            _agiliteConfig.Headers.Add(Constants.Header.BpmRecordId, bpmRecordId);

            return Base.SetReturnObject<List<RolesModel.AssignRolesResult>>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Changes the conditional levels.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <param name="conditionalLevels">The conditional levels.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> ChangeConditionalLevels(string recordId = "", List<string> conditionalLevels = null)
        {
            _agiliteConfig.Function = Constants.Functions.Roles.ChangeConditionalLevels;
            _agiliteConfig.Headers.Add(Constants.Header.ConditionalLevels, string.Join(Constants.SeparatorComma, conditionalLevels ?? new List<string>()));
            _agiliteConfig.Headers.Add(Constants.Header.RecordId, recordId);

            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Res the assign responsible user.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <param name="responsibleUser">The responsible user.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> ReAssignResponsibleUser(string recordId = "", List<string> responsibleUser = null)
        {
            _agiliteConfig.Function = Constants.Functions.Roles.ReAssignResponsibleUser;
            _agiliteConfig.Headers.Add(Constants.Header.ResponsibleUser, string.Join(Constants.SeparatorComma, responsibleUser ?? new List<string>()));
            _agiliteConfig.Headers.Add(Constants.Header.RecordId, recordId);

            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }
    }
}