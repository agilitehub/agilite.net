using System;
using System.IO;
using Agilite.Models;
using static Agilite.Models.BaseModel;

namespace Agilite.Library
{
    /// <summary>
    ///     Class Files.
    ///     Implements the <see cref="Agilite.Library.CrudRequests" />
    /// </summary>
    /// <seealso cref="Agilite.Library.CrudRequests" />
    public class Files : CrudRequests
    {
        /// <summary>
        ///     The agilite configuration
        /// </summary>
        private readonly AgiliteRequestConfig _agiliteConfig;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Files" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public Files(AgiliteRequestConfig config) : base(config)
        {
            _agiliteConfig = config;
            _agiliteConfig.Module = Constants.ModuleKey.Files;
        }

        /// <summary>
        ///     Uploads the file by location.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="contentType">Type of the content.</param>
        /// <returns>ReturnObject&lt;FileModel.FileResult&gt;.</returns>
        public ReturnObject<FileModel.FileResult> UploadFileByLocation(string filePath, string fileName = "", string contentType = "")
        {
            try
            {
                return UploadFileByByte(File.ReadAllBytes(filePath), fileName, contentType);
            }
            catch (Exception e)
            {
                return Base.ReturnError<FileModel.FileResult>(e);
            }
        }

        /// <summary>
        ///     Uploads the file by byte.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="contentType">Type of the content.</param>
        /// <returns>ReturnObject&lt;FileModel.FileResult&gt;.</returns>
        public ReturnObject<FileModel.FileResult> UploadFileByByte(byte[] data, string fileName = "", string contentType = "")
        {
            _agiliteConfig.Headers.Add(Constants.Header.FileName, fileName);
            _agiliteConfig.Headers.Add(Constants.Header.ContentType, contentType);
            var agiliteResponse = AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Upload, data);
            return Base.SetReturnObject<FileModel.FileResult>(agiliteResponse);
        }


        /// <summary>
        ///     Gets the file.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <returns>ReturnObject&lt;System.Byte[]&gt;.</returns>
        public ReturnObject<byte[]> GetFile(string recordId = "")
        {
            _agiliteConfig.Headers.Add(Constants.Header.RecordId, recordId);
            return Base.SetReturnObject<byte[]>(AgiliteRequest.ExecuteCrudRequest(_agiliteConfig, Constants.Methods.Get));
        }

        /// <summary>
        ///     Deletes the file.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> DeleteFile(string recordId = "")
        {
            return DeleteAgiliteData(recordId);
        }

        /// <summary>
        ///     Gets the name of the file.
        /// </summary>
        /// <param name="recordId">The record identifier.</param>
        /// <returns>ReturnObject&lt;System.String&gt;.</returns>
        public ReturnObject<string> GetFileName(string recordId = "")
        {
            _agiliteConfig.Function = Constants.Functions.Files.GetFileName;
            _agiliteConfig.Headers.Add(Constants.Header.RecordId, recordId);
            return Base.SetReturnObject<string>(AgiliteRequest.ExecuteRequest(_agiliteConfig).Result);
        }

        /// <summary>
        ///     Writes to file.
        /// </summary>
        /// <param name="dataBuffer">The data buffer.</param>
        /// <param name="dstFilePath">The DST file path.</param>
        public void WriteToFile(byte[] dataBuffer, string dstFilePath)
        {
            using (var fileStream = new FileStream(dstFilePath, FileMode.Create, FileAccess.Write))
            {
                if (dataBuffer.Length > 0) fileStream.Write(dataBuffer, 0, dataBuffer.Length);
            }
        }
    }
}