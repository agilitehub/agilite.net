using System.Collections.Generic;
using Agilite.Models;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class Numbering.
    ///     Implements the <see cref="Agilite.Library.CrudRequests" />
    /// </summary>
    /// <seealso cref="Agilite.Library.CrudRequests" />
    public class Numbering : CrudRequests
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Numbering" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public Numbering(AgiliteRequestConfig config) : base(config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.Numbering;
        }

        /// <summary>
        ///     Posts the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;NumberingModel.Result&gt;.</returns>
        public ReturnObject<NumberingModel.Result> PostData(NumberingModel.ResultData data)
        {
            return Base.SetReturnObject<NumberingModel.Result>(PostAgiliteData(data));
        }

        /// <summary>
        ///     Gets the data.
        /// </summary>
        /// <param name="profileKeys">The profile keys.</param>
        /// <param name="recordIds">The record ids.</param>
        /// <param name="slimResult">if set to <c>true</c> [slim result].</param>
        /// <returns>ReturnObject&lt;List&lt;NumberingModel.Result&gt;&gt;.</returns>
        public ReturnObject<List<NumberingModel.Result>> GetData(List<string> profileKeys = null, List<string> recordIds = null, bool slimResult = true)
        {
            return Base.SetReturnObject<List<NumberingModel.Result>>(GetAgiliteData(profileKeys, recordIds, slimResult));
        }

        /// <summary>
        ///     Puts the data.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;NumberingModel.Result&gt;.</returns>
        public ReturnObject<NumberingModel.Result> PutData(string recordId, NumberingModel.ResultData data = null)
        {
            return Base.SetReturnObject<NumberingModel.Result>(PutAgiliteData(recordId, data));
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
        ///     Generates the json.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> GenerateJson(string profileKey, ParamStringObject data = null)
        {
            return Base.SetReturnObject<dynamic>(Generate(profileKey, data, AgilEnums.OutFormatSj.Json));
        }

        /// <summary>
        ///     Generates the string.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> GenerateString(string profileKey, ParamStringObject data = null)
        {
            return Base.SetReturnObject<string>(Generate(profileKey, data, AgilEnums.OutFormatSj.String));
        }

        /// <summary>
        ///     Resets the counters.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> ResetCounters(string recordId = "")
        {
            _agiliteConfig.Function = Constants.Functions.Numbering.ResetCounters;
            _agiliteConfig.Headers.Add(Constants.Header.RecordId, recordId);

            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Generates the specified profile key.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="data">The data.</param>
        /// <param name="outputFormat">The output format.</param>
        /// <returns>AgiliteResponse.</returns>
        private AgiliteResponse Generate(string profileKey, ParamStringObject data = null, AgilEnums.OutFormatSj outputFormat = AgilEnums.OutFormatSj.None)
        {
            _agiliteConfig.Function = Constants.Functions.Numbering.Generate;
            _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, profileKey);
            _agiliteConfig.Headers.Add(Constants.Header.OutputFormat, Base.ManageEnums.OutFormatSj(outputFormat));

            return AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data);
        }
    }
}