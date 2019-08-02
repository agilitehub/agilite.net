using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Agilite.Models;
using Newtonsoft.Json;
using static Agilite.Models.BaseModel;

namespace Agilite
{
    /// <summary>
    /// Class AgiliteRequest.
    /// </summary>
    internal static class AgiliteRequest
    {
        /// <summary>
        /// Executes the request.
        /// </summary>
        /// <param name="requestConfig">The request configuration.</param>
        /// <param name="data">The data.</param>
        /// <returns>Task&lt;AgiliteResponse&gt;.</returns>
        /// <exception cref="Exception"></exception>
        internal static async Task<AgiliteResponse> ExecuteRequest(AgiliteRequestConfig requestConfig, object data = null)
        {
            var proxyHttpClientHandler = new HttpClientHandler();
            var requestData = new AgiliteResponse();

            #if NETCOREAPP1_0
            #elif NETCOREAPP1_1
            #else
                        if (!string.IsNullOrEmpty(requestConfig.AgiliteConfig.ProxyAddress)) {

                                        var webProxy = new WebProxy(new Uri(requestConfig.AgiliteConfig.ProxyAddress), false) {
                                            UseDefaultCredentials = true,
                                            Credentials = new NetworkCredential(requestConfig.AgiliteConfig.ProxyUsername, requestConfig.AgiliteConfig.ProxyPassword)
                                        };

                                        proxyHttpClientHandler.Proxy = webProxy;
                                        proxyHttpClientHandler.UseProxy = true;
                        }
            #endif

            #if NET40
                    ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;  
            #elif NETCOREAPP1_0 || NETCOREAPP1_1
            #else
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        ServicePointManager.Expect100Continue = true;
            #endif


            using (var client = new HttpClient(proxyHttpClientHandler))
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.Header.ApplicationJson));
                try
                {
                    requestConfig.Headers.Add(Constants.Header.ApiKey, requestConfig.AgiliteConfig.ApiKey);
                    requestConfig.Uri = requestConfig.AgiliteConfig.ApiServerUrl;

                    if (!string.IsNullOrEmpty(requestConfig.AgiliteConfig.TeamId))
                        requestConfig.Headers.Add(Constants.Header.TeamName, requestConfig.AgiliteConfig.TeamId);

                    if (!requestConfig.Publish)
                        client.DefaultRequestHeaders.Add(Constants.Header.Publish, requestConfig.Publish.ToString());

                    client.BaseAddress = new Uri(requestConfig.Uri);
                    client.DefaultRequestHeaders.Accept.Clear();


                    if (requestConfig.Module == "files")
                    {
                        if (requestConfig.Function == null)
                        {
                            requestConfig.Url = requestConfig.Uri + "/" + requestConfig.Module;
                        }
                        else
                        {
                            requestConfig.Url = requestConfig.Uri + "/" + requestConfig.Module + "/" + requestConfig.Function;
                        }
                    }
                    else
                    {
                        requestConfig.Url = $"{requestConfig.Uri}/{requestConfig.Module}/{requestConfig.Function ?? Constants.StringData}";
                    }

                    foreach (var header in requestConfig.Headers)
                        if (!string.IsNullOrEmpty(header.Value))
                            client.DefaultRequestHeaders.Add(header.Key, header.Value);

                    HttpResponseMessage response = null;

                    if (requestConfig.Method == Constants.Methods.Get)
                    {
                        response = await client.GetAsync(requestConfig.Url, HttpCompletionOption.ResponseHeadersRead);
                    }
                    else if (requestConfig.Method == Constants.Methods.Post)
                    {
                        client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", Constants.Header.ApplicationJson);
                        response = await client.PostAsync(requestConfig.Url, GetContent(data));
                    }
                    else if (requestConfig.Method == Constants.Methods.Put)
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.Header.ApplicationJson));
                        response = await client.PutAsync(requestConfig.Url, GetContent(data));
                    }
                    else if (requestConfig.Method == Constants.Methods.Delete)
                    {
                        response = await client.DeleteAsync(requestConfig.Url);
                    }
                    else if (requestConfig.Method == Constants.Methods.Upload)
                    {
                        client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", Constants.Header.ApplicationOctet);
                        response = await client.PostAsync(requestConfig.Url, GetContentFile(data));
                    }

                    if (response != null)
                    {
                        requestData.StringResponse = await response.Content.ReadAsStringAsync();
                        requestData.AgiliteResponseMessage = response;

                        if (requestData.AgiliteResponseMessage.StatusCode != HttpStatusCode.OK)
                        {
                            //check if it is a valid error from Agilite and deserialize it for use
                            if (requestData.StringResponse.Contains("\"statusCode\":"))
                            {
                                requestData.Error = JsonConvert.DeserializeObject<AgiliteError>(requestData.StringResponse);
                                requestData.StringResponse = string.Empty;
                            }
                            else
                            {
                                requestData.Error = new AgiliteError { ErrorMessage = requestData.StringResponse, StatusCode = requestData.AgiliteResponseMessage.StatusCode.ToString() };
                                requestData.StringResponse = string.Empty;
                            }
                           
                        }

                        return requestData;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (WebException ex)
                {
                    using (var sr = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        requestData.Error = new AgiliteError
                        {
                            StatusCode = "500",
                            ErrorMessage = sr.ReadToEnd()
                        };
                    }

                    requestData.StringResponse = string.Empty;
                    return requestData;
                }
                catch (HttpRequestException ex)
                {
                    requestData.Error = new AgiliteError
                    {
                        StatusCode = "500",
                        ErrorMessage = ex.InnerException.Message
                    };
                    requestData.StringResponse = string.Empty;
                    return requestData;
                }
                catch (Exception ex)
                {
                    requestData.Error = new AgiliteError
                    {
                        StatusCode = "500",
                        ErrorMessage = ex.Message
                    };
                    requestData.StringResponse = string.Empty;
                    return requestData;
                }
                finally
                {
                    requestConfig.Headers.Clear();
                    requestConfig.Method = Constants.Methods.Get;
                    requestConfig.Function = null;
                    requestConfig.Publish = false;
                }
            }
        }

        /// <summary>
        /// Executes the crud request.
        /// </summary>
        /// <param name="requestConfig">The request configuration.</param>
        /// <param name="method">The method.</param>
        /// <param name="data">The data.</param>
        /// <returns>AgiliteResponse.</returns>
        internal static AgiliteResponse ExecuteCrudRequest(AgiliteRequestConfig requestConfig, string method, object data = null)
        {
            requestConfig.Method = method;
            return ExecuteRequest(requestConfig, data).Result;
        }

        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ByteArrayContent.</returns>
        private static ByteArrayContent GetContent(object data)
        {
            var obj = new {data};
            var myContent = JsonConvert.SerializeObject(obj);
            var buffer = Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return byteContent;
        }

        /// <summary>
        /// Gets the content file.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>ByteArrayContent.</returns>
        private static ByteArrayContent GetContentFile(object data)
        {
            var obj = new {data};
            var myContent = JsonConvert.SerializeObject(obj);
            var buffer = Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue(Constants.Header.ApplicationOctet);
            return byteContent;
        }
    }
}