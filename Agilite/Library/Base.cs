using System;
using Agilite.Models;
using Newtonsoft.Json;

namespace Agilite.Library {
    /// <summary>
    ///     Class Common.
    /// </summary>
    internal class Base {
        /// <summary>
        ///     The settings
        /// </summary>
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Error };

        /// <summary>
        ///     Sets the return object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="agiliteResponse">The agilite response.</param>
        /// <returns>CommonModel.ReturnObject&lt;T&gt;.</returns>
        public static BaseModel.ReturnObject<T> SetReturnObject<T>(BaseModel.AgiliteResponse agiliteResponse) {
            try {
                var returnObject = new BaseModel.ReturnObject<T> { Error = agiliteResponse.Error };

                if (agiliteResponse.Error != null) return returnObject;

                var typeParameterType = typeof(T);

                if (typeParameterType == typeof(string)) {
                    returnObject.ResponseData = (T)Convert.ChangeType(agiliteResponse.StringResponse, typeof(T));
                }
                else if (typeParameterType == typeof(byte[])) {
                    var fileData = JsonConvert.DeserializeObject<FileModel.FileData>(agiliteResponse.StringResponse, Settings);
                    var byteValue = string.IsNullOrEmpty(fileData.Data) == false ? Convert.FromBase64String(fileData.Data) : null;
                    returnObject.ResponseData = (T)Convert.ChangeType(byteValue, typeof(T));
                }
                else {
                    returnObject.ResponseData = JsonConvert.DeserializeObject<T>(agiliteResponse.StringResponse, Settings);
                }

                return returnObject;
            }
            catch (Exception e) {
                return ReturnError<T>(e);
            }
        }

        /// <summary>
        ///     Returns the error.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="e">The e.</param>
        /// <returns>CommonModel.ReturnObject&lt;T&gt;.</returns>
        public static BaseModel.ReturnObject<T> ReturnError<T>(Exception e) {
            return new BaseModel.ReturnObject<T> { Error = new BaseModel.AgiliteError { ErrorMessage = e.Message, StatusCode = "500" } };
        }

        /// <summary>
        ///     Returns the error.
        /// </summary>
        /// <param name="e">The e.</param>
        /// <returns>CommonModel.AgiliteResponse.</returns>
        public static BaseModel.AgiliteResponse ReturnError(Exception e) {
            return new BaseModel.AgiliteResponse { Error = new BaseModel.AgiliteError { StatusCode = "500", ErrorMessage = e.Message } };
        }

        /// <summary>
        ///     Class ManageEnums.
        /// </summary>
        public class ManageEnums {
            /// <summary>
            ///     Sorts the order.
            /// </summary>
            /// <param name="sortOrder">The sort order.</param>
            /// <returns>System.String.</returns>
            public static string SortOrder(AgilEnums.SortOrder sortOrder) {
                switch (sortOrder) {
                    case AgilEnums.SortOrder.Ascending: return Constants.SortAsc;
                    case AgilEnums.SortOrder.Descending: return Constants.SortDesc;
                    case AgilEnums.SortOrder.AscendingValue: return Constants.SortAscValue;
                    case AgilEnums.SortOrder.DescendingValue: return Constants.SortDescValue;
                    default: return "";
                }
            }

            /// <summary>
            ///     Outs the format sj.
            /// </summary>
            /// <param name="outFormatSj">The out format sj.</param>
            /// <returns>System.String.</returns>
            public static string OutFormatSj(AgilEnums.OutFormatSj outFormatSj) {
                switch (outFormatSj) {
                    case AgilEnums.OutFormatSj.Json: return Constants.Value.JsonLower;
                    case AgilEnums.OutFormatSj.String: return Constants.Value.StringLower;
                    default: return "";
                }
            }

            /// <summary>
            ///     Outs the format aj.
            /// </summary>
            /// <param name="outFormatSj">The out format sj.</param>
            /// <returns>System.String.</returns>
            public static string OutFormatAj(AgilEnums.OutFormatAj outFormatSj) {
                switch (outFormatSj) {
                    case AgilEnums.OutFormatAj.Array: return Constants.Value.ArrayLower;
                    case AgilEnums.OutFormatAj.Json: return Constants.Value.JsonLower;
                    default: return "";
                }
            }

            /// <summary>
            ///     Outs the type of the response.
            /// </summary>
            /// <param name="responseType">Type of the response.</param>
            /// <returns>System.String.</returns>
            public static string OutResponseType(AgilEnums.RespondType responseType) {
                switch (responseType) {
                    case AgilEnums.RespondType.ArrayBuffer: return Constants.ResponseType.ArrayBuffer;
                    case AgilEnums.RespondType.Blob: return Constants.ResponseType.Blob;
                    case AgilEnums.RespondType.Document: return Constants.ResponseType.Document;
                    case AgilEnums.RespondType.Json: return Constants.ResponseType.Json;
                    case AgilEnums.RespondType.Text: return Constants.ResponseType.Text;
                    case AgilEnums.RespondType.Stream: return Constants.ResponseType.Stream;

                    default: return "";
                }
            }
        }
    }
}