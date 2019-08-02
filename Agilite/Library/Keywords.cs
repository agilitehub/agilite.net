using System.Collections.Generic;
using Agilite.Models;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class Keywords.
    ///     Implements the <see cref="Agilite.Library.CrudRequests" />
    /// </summary>
    /// <seealso cref="Agilite.Library.CrudRequests" />
    public class Keywords : CrudRequests
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Keywords" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public Keywords(AgiliteRequestConfig config) : base(config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.Keywords;
        }

        /// <summary>
        ///     Posts the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;KeywordsModel.Result&gt;.</returns>
        public ReturnObject<KeywordsModel.Result> PostData(KeywordsModel.ResultData data)
        {
            return Base.SetReturnObject<KeywordsModel.Result>(PostAgiliteData(data));
        }

        /// <summary>
        ///     Gets the data.
        /// </summary>
        /// <param name="profileKeys">The profile keys.</param>
        /// <param name="recordIds">The record ids.</param>
        /// <param name="slimResult">if set to <c>true</c> [slim result].</param>
        /// <returns>ReturnObject&lt;List&lt;KeywordsModel.Result&gt;&gt;.</returns>
        public ReturnObject<List<KeywordsModel.Result>> GetData(List<string> profileKeys = null, List<string> recordIds = null, bool slimResult = true)
        {
            return Base.SetReturnObject<List<KeywordsModel.Result>>(GetAgiliteData(profileKeys, recordIds, slimResult));
        }

        /// <summary>
        ///     Puts the data.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;KeywordsModel.Result&gt;.</returns>
        public ReturnObject<KeywordsModel.Result> PutData(string recordId, KeywordsModel.ResultData data = null)
        {
            return Base.SetReturnObject<KeywordsModel.Result>(PutAgiliteData(recordId, data));
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
        ///     Gets the by profile key json.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="sortOrder">The sort order.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> GetByProfileKeyJson(string profileKey, AgilEnums.SortOrder sortOrder = AgilEnums.SortOrder.None)
        {
            return Base.SetReturnObject<dynamic>(GetByProfileKey(profileKey, sortOrder, AgilEnums.OutFormatAj.Json));
        }

        /// <summary>
        ///     Gets the by profile key list.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="sortOrder">The sort order.</param>
        /// <returns>ReturnObject&lt;List&lt;ResultDataValues&gt;&gt;.</returns>
        public ReturnObject<List<ResultDataValues>> GetByProfileKeyList(string profileKey, AgilEnums.SortOrder sortOrder = AgilEnums.SortOrder.None)
        {
            return Base.SetReturnObject<List<ResultDataValues>>(GetByProfileKey(profileKey, sortOrder, AgilEnums.OutFormatAj.Array));
        }

        /// <summary>
        ///     Gets the profile keys by group.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        /// <param name="sortOrder">The sort order.</param>
        /// <returns>ReturnObject&lt;List&lt;System.String&gt;&gt;.</returns>
        public ReturnObject<List<string>> GetProfileKeysByGroup(string groupName, AgilEnums.SortOrder sortOrder = AgilEnums.SortOrder.None)
        {
            _agiliteConfig.Function = Constants.Functions.Keywords.GetProfileKeysByGroup;
            _agiliteConfig.Headers.Add(Constants.Header.GroupName, groupName);
            _agiliteConfig.Headers.Add(Constants.Header.Sort, Base.ManageEnums.SortOrder(sortOrder));
            return Base.SetReturnObject<List<string>>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Gets the label by value string.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="valueKey">The value key.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> GetLabelByValueString(string profileKey, string valueKey)
        {
            return Base.SetReturnObject<string>(GetLabelByValue(profileKey, valueKey, AgilEnums.OutFormatSj.String));
        }

        /// <summary>
        ///     Gets the label by value json.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="valueKey">The value key.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> GetLabelByValueJson(string profileKey, string valueKey)
        {
            return Base.SetReturnObject<dynamic>(GetLabelByValue(profileKey, valueKey, AgilEnums.OutFormatSj.String));
        }

        /// <summary>
        ///     Gets the value by label json.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="labelKey">The label key.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> GetValueByLabelJson(string profileKey, string labelKey)
        {
            return Base.SetReturnObject<dynamic>(GetValueByLabel(profileKey, labelKey, AgilEnums.OutFormatSj.Json));
        }

        /// <summary>
        ///     Gets the value by label string.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="labelKey">The label key.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> GetValueByLabelString(string profileKey, string labelKey)
        {
            return Base.SetReturnObject<string>(GetValueByLabel(profileKey, labelKey, AgilEnums.OutFormatSj.String));
        }

        /// <summary>
        ///     Gets the value by label.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="labelKey">The label key.</param>
        /// <param name="outputFormat">The output format.</param>
        /// <returns>AgiliteResponse.</returns>
        private AgiliteResponse GetValueByLabel(string profileKey, string labelKey, AgilEnums.OutFormatSj outputFormat = AgilEnums.OutFormatSj.None)
        {
            _agiliteConfig.Function = Constants.Functions.Keywords.GetValueByLabel;
            _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, profileKey);
            _agiliteConfig.Headers.Add(Constants.Header.OutputFormat, Base.ManageEnums.OutFormatSj(outputFormat));
            _agiliteConfig.Headers.Add(Constants.Header.LabelKey, labelKey);

            return AgiliteRequest.ExecuteRequest(_agiliteConfig).Result;
        }

        /// <summary>
        ///     Gets the label by value.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="valueKey">The value key.</param>
        /// <param name="outputFormat">The output format.</param>
        /// <returns>AgiliteResponse.</returns>
        private AgiliteResponse GetLabelByValue(string profileKey, string valueKey, AgilEnums.OutFormatSj outputFormat = AgilEnums.OutFormatSj.None)
        {
            _agiliteConfig.Function = Constants.Functions.Keywords.GetLabelByValue;
            _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, profileKey);
            _agiliteConfig.Headers.Add(Constants.Header.OutputFormat, Base.ManageEnums.OutFormatSj(outputFormat));
            _agiliteConfig.Headers.Add(Constants.Header.ValueKey, valueKey);

            return AgiliteRequest.ExecuteRequest(_agiliteConfig).Result;
        }

        /// <summary>
        ///     Gets the by profile key.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="sortOrder">The sort order.</param>
        /// <param name="outputFormat">The output format.</param>
        /// <returns>AgiliteResponse.</returns>
        private AgiliteResponse GetByProfileKey(string profileKey, AgilEnums.SortOrder sortOrder = AgilEnums.SortOrder.None, AgilEnums.OutFormatAj outputFormat = AgilEnums.OutFormatAj.None)
        {
            _agiliteConfig.Function = Constants.Functions.Keywords.GetProfileKey;
            _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, profileKey);
            _agiliteConfig.Headers.Add(Constants.Header.Sort, Base.ManageEnums.SortOrder(sortOrder));
            _agiliteConfig.Headers.Add(Constants.Header.OutputFormat, Base.ManageEnums.OutFormatAj(outputFormat));

            return AgiliteRequest.ExecuteRequest(_agiliteConfig).Result;
        }
    }
}