using Agilite.Models;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class DataMapping.
    /// </summary>
    public class DataMapping
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DataMapping" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public DataMapping(AgiliteRequestConfig config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.DataMapping;
        }

        /// <summary>
        ///     Executes the specified profile key.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> Execute(string profileKey, ParamStringObject data = null)
        {
            _agiliteConfig.Function = Constants.Functions.DataMapping.Execute;
            _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, profileKey);

            return Base.SetReturnObject<dynamic>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }
    }
}