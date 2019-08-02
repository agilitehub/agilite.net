using System.Collections.Generic;
using Agilite.Models;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class TierStructures.
    ///     Implements the <see cref="Agilite.Library.CrudRequests" />
    /// </summary>
    /// <seealso cref="Agilite.Library.CrudRequests" />
    public class TierStructures : CrudRequests
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TierStructures" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public TierStructures(AgiliteRequestConfig config) : base(config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.TierStructures;
        }

        /// <summary>
        ///     Posts the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;TierStructuresModel.Result&gt;.</returns>
        public ReturnObject<TierStructuresModel.Result> PostData(TierStructuresModel.ResultData data)
        {
            return Base.SetReturnObject<TierStructuresModel.Result>(PostAgiliteData(data));
        }

        /// <summary>
        ///     Gets the data.
        /// </summary>
        /// <param name="profileKeys">The profile keys.</param>
        /// <param name="recordIds">The record ids.</param>
        /// <param name="slimResult">if set to <c>true</c> [slim result].</param>
        /// <returns>ReturnObject&lt;List&lt;TierStructuresModel.Result&gt;&gt;.</returns>
        public ReturnObject<List<TierStructuresModel.Result>> GetData(List<string> profileKeys = null, List<string> recordIds = null, bool slimResult = true)
        {
            return Base.SetReturnObject<List<TierStructuresModel.Result>>(GetAgiliteData(profileKeys, recordIds, slimResult));
        }

        /// <summary>
        ///     Puts the data.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;TierStructuresModel.Result&gt;.</returns>
        public ReturnObject<TierStructuresModel.Result> PutData(string recordId, TierStructuresModel.ResultData data = null)
        {
            return Base.SetReturnObject<TierStructuresModel.Result>(PutAgiliteData(recordId, data));
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
        ///     Gets the tier by key dynamic.
        /// </summary>
        /// <param name="tierKeys">The tier keys.</param>
        /// <param name="includeValues">if set to <c>true</c> [include values].</param>
        /// <param name="includeMetaData">if set to <c>true</c> [include meta data].</param>
        /// <param name="includeTierEntries">if set to <c>true</c> [include tier entries].</param>
        /// <param name="sortValues">The sort values.</param>
        /// <param name="valuesOutputFormat">The values output format.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> GetTierByKeyDynamic(List<string> tierKeys = null, bool includeValues = true, bool includeMetaData = false, bool includeTierEntries = false, AgilEnums.SortOrder sortValues = AgilEnums.SortOrder.None, AgilEnums.OutFormatAj valuesOutputFormat = AgilEnums.OutFormatAj.None)
        {
            return Base.SetReturnObject<dynamic>(GetTierByKey(tierKeys, includeValues, includeMetaData, includeTierEntries, sortValues, valuesOutputFormat));
        }

        /// <summary>
        ///     Gets the tier by key.
        /// </summary>
        /// <param name="tierKeys">The tier keys.</param>
        /// <param name="includeValues">if set to <c>true</c> [include values].</param>
        /// <param name="includeMetaData">if set to <c>true</c> [include meta data].</param>
        /// <param name="includeTierEntries">if set to <c>true</c> [include tier entries].</param>
        /// <param name="sortValues">The sort values.</param>
        /// <param name="valuesOutputFormat">The values output format.</param>
        /// <returns>AgiliteResponse.</returns>
        private AgiliteResponse GetTierByKey(List<string> tierKeys = null, bool includeValues = true, bool includeMetaData = false, bool includeTierEntries = false, AgilEnums.SortOrder sortValues = AgilEnums.SortOrder.None, AgilEnums.OutFormatAj valuesOutputFormat = AgilEnums.OutFormatAj.None)
        {
            tierKeys = tierKeys ?? new List<string>();

            _agiliteConfig.Function = Constants.Functions.TierStructuresFunctions.GetTierByKey;
            _agiliteConfig.Headers.Add(Constants.Header.TierKeys, string.Join(Constants.SeparatorComma, tierKeys));
            _agiliteConfig.Headers.Add(Constants.Header.IncludeValues, includeValues.ToString());
            _agiliteConfig.Headers.Add(Constants.Header.IncludeMetaData, includeMetaData.ToString());
            _agiliteConfig.Headers.Add(Constants.Header.IncludeTierEntries, includeTierEntries.ToString());

            _agiliteConfig.Headers.Add(Constants.Header.SortValues, Base.ManageEnums.SortOrder(sortValues));
            _agiliteConfig.Headers.Add(Constants.Header.ValuesOutputFormat, Base.ManageEnums.OutFormatAj(valuesOutputFormat));

            return AgiliteRequest.ExecuteRequest(_agiliteConfig).Result;
        }
    }
}