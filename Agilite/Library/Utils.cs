using Agilite.Models;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class Utils.
    /// </summary>
    public class Utils
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Utils" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public Utils(AgiliteRequestConfig config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.Utils;
        }

        /// <summary>
        ///     Encodes the XML.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> EncodeXml(string data)
        {
            _agiliteConfig.Function = Constants.Functions.Utils.EncodeXml;
            _agiliteConfig.Headers.Add(Constants.Header.ContentType, Constants.Header.TextPlain);

            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }

        /// <summary>
        ///     Decodes the XML.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> DecodeXml(string data)
        {
            _agiliteConfig.Function = Constants.Functions.Utils.DecodeXml;
            _agiliteConfig.Headers.Add(Constants.Header.ContentType, Constants.Header.TextPlain);

            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }

        /// <summary>
        ///     XMLs to js.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> XmlToJs(string data)
        {
            _agiliteConfig.Function = Constants.Functions.Utils.XmlToJs;
            _agiliteConfig.Headers.Add(Constants.Header.ContentType, Constants.Header.TextPlain);

            return Base.SetReturnObject<dynamic>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }

        /// <summary>
        ///     Jses to XML.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> JsToXml(string data)
        {
            _agiliteConfig.Function = Constants.Functions.Utils.JsToXml;
            _agiliteConfig.Headers.Add(Constants.Header.ContentType, Constants.Header.ApplicationJson);

            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }

        /// <summary>
        ///     HTML2s the json.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> Html2Json(string data)
        {
            _agiliteConfig.Function = Constants.Functions.Utils.Html2Json;
            _agiliteConfig.Headers.Add(Constants.Header.ContentType, Constants.Header.TextPlain);

            return Base.SetReturnObject<dynamic>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }

        /// <summary>
        ///     Generates the UUID.
        /// </summary>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> GenerateUuid()
        {
            _agiliteConfig.Function = Constants.Functions.Utils.GenerateUuid;
            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Formats the date time.
        /// </summary>
        /// <param name="dateTimeValue">The date time value.</param>
        /// <param name="formatKey">The format key.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> FormatDateTime(string dateTimeValue = "", string formatKey = "")
        {
            _agiliteConfig.Function = Constants.Functions.Utils.FormatDateTime;
            _agiliteConfig.Headers.Add(Constants.Header.DateTimeValue, dateTimeValue);
            _agiliteConfig.Headers.Add(Constants.Header.FormatKey, formatKey);

            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Generates the PDF.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ReturnObject&lt;dynamic&gt;.</returns>
        public ReturnObject<dynamic> GeneratePdf(string data)
        {
            _agiliteConfig.Function = Constants.Functions.Utils.GeneratePdf;
            _agiliteConfig.Headers.Add(Constants.Header.ContentType, Constants.Header.ApplicationJson);

            return Base.SetReturnObject<dynamic>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data));
        }
    }
}