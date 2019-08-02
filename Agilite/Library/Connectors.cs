using Agilite.Models;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class Connectors.
    /// </summary>
    public class Connectors
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Connectors" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public Connectors(AgiliteRequestConfig config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.Connectors;
        }

        /// <summary>
        ///     Executes the specified profile key.
        /// </summary>
        /// <param name="profileKey">The profile key.</param>
        /// <param name="routeKey">The route key.</param>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> Execute(string profileKey, string routeKey, ParamStringObject data = null)
        {
            _agiliteConfig.Function = Constants.Functions.Connectors.Execute;
            _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, profileKey);
            _agiliteConfig.Headers.Add(Constants.Header.RouteKey, routeKey);
            return Base.SetReturnObject<dynamic>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }
    }
}