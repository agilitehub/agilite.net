using System;
using System.Collections.Generic;
using Agilite.Models;
using Newtonsoft.Json;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class CrudRequests.
    /// </summary>
    public class CrudRequests
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CrudRequests" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        protected CrudRequests(AgiliteRequestConfig config)
        {
            _agiliteConfig = config;
        }


        /// <summary>
        ///     Posts the agilite data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>AgiliteResponse.</returns>
        internal AgiliteResponse PostAgiliteData(object data)
        {
            try
            {
                return AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Post, data);
            }
            catch (Exception e)
            {
                return Base.ReturnError(e);
            }
        }


        /// <summary>
        ///     Gets the agilite data.
        /// </summary>
        /// <param name="profileKeys">The profile keys.</param>
        /// <param name="recordIds">The record ids.</param>
        /// <param name="slimResult">if set to <c>true</c> [slim result].</param>
        /// <returns>AgiliteResponse.</returns>
        internal AgiliteResponse GetAgiliteData(List<string> profileKeys = null, List<string> recordIds = null, bool slimResult = true)
        {
            try
            {
                profileKeys = profileKeys ?? new List<string>();
                recordIds = recordIds ?? new List<string>();

                _agiliteConfig.Headers.Add(Constants.Header.ProfileKey, string.Join(Constants.SeparatorComma, profileKeys));
                _agiliteConfig.Headers.Add(Constants.Header.RecordIds, string.Join(Constants.SeparatorComma, recordIds));
                _agiliteConfig.Headers.Add(Constants.Header.SlimResult, slimResult.ToString());
                return AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Get);
            }
            catch (Exception e)
            {
                return Base.ReturnError(e);
            }
        }

        /// <summary>
        ///     Puts the agilite data.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <param name="data">The data.</param>
        /// <returns>AgiliteResponse.</returns>
        internal AgiliteResponse PutAgiliteData(string recordId, object data)
        {
            try
            {
                _agiliteConfig.Headers.Add(Constants.Header.RecordId, recordId);
                return AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Put, data);
            }
            catch (Exception e)
            {
                return Base.ReturnError(e);
            }
        }

        /// <summary>
        ///     Deletes the agilite data.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        internal ReturnObject<string> DeleteAgiliteData(string recordId = "")
        {
            try
            {
                _agiliteConfig.Headers.Add(Constants.Header.RecordId, recordId);
                var agiliteResponse = AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Delete);
                return new ReturnObject<string> {Error = agiliteResponse.Error, ResponseData = JsonConvert.SerializeObject(agiliteResponse.StringResponse)};
            }
            catch (Exception e)
            {
                return Base.ReturnError<string>(e);
            }
        }
    }
}