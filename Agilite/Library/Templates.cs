using System.Collections.Generic;
using Agilite.Models;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class Templates.
    ///     Implements the <see cref="Agilite.Library.CrudRequests" />
    /// </summary>
    /// <seealso cref="Agilite.Library.CrudRequests" />
    public class Templates : CrudRequests
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Templates" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public Templates(AgiliteRequestConfig config) : base(config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.Templates;
        }

        /// <summary>
        ///     Posts the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;TemplatesModel.Result&gt;.</returns>
        public ReturnObject<TemplatesModel.Result> PostData(TemplatesModel.ResultData data)
        {
            return Base.SetReturnObject<TemplatesModel.Result>(PostAgiliteData(data));
        }

        /// <summary>
        ///     Gets the data.
        /// </summary>
        /// <param name="profileKeys">The profile keys.</param>
        /// <param name="recordIds">The record ids.</param>
        /// <param name="slimResult">if set to <c>true</c> [slim result].</param>
        /// <returns>ReturnObject&lt;List&lt;TemplatesModel.Result&gt;&gt;.</returns>
        public ReturnObject<List<TemplatesModel.Result>> GetData(List<string> profileKeys = null, List<string> recordIds = null, bool slimResult = true)
        {
            return Base.SetReturnObject<List<TemplatesModel.Result>>(GetAgiliteData(profileKeys, recordIds, slimResult));
        }

        /// <summary>
        ///     Puts the data.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;TemplatesModel.Result&gt;.</returns>
        public ReturnObject<TemplatesModel.Result> PutData(string recordId, TemplatesModel.ResultData data = null)
        {
            return Base.SetReturnObject<TemplatesModel.Result>(PutAgiliteData(recordId, data));
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
        ///     Executes the specified profile key.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> Execute(string profileKey, ParamStringObject data = null)
        {
            _agiliteConfig.Function = Constants.Functions.Templates.Execute;
            _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, profileKey);
            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }
    }
}