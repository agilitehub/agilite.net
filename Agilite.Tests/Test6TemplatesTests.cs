using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using Agilite.Models;
using Agilite.Tests.DataTemplates;
using Agilite.Tests.Library;

namespace Agilite.Tests {
    [TestClass()]
    public class Test6TemplatesTests : BaseClass {
        private readonly dynamic _mainEntry = JsonConvert.DeserializeObject(TemplatesData.Data);

        [TestMethod]
        public void RunAllNumberingTests() {
            Templates1PostDataTest();
            Templates2GetDataTest();
            Templates3UpdateRecordTest();
            Templates4Execute();
            Templates5DeleteDataTest();
        }

        //1. Create New Record
        private void Templates1PostDataTest() {
            try {
                var value = _mainEntry.newItem.data;
                TemplatesModel.ResultData newItem = JsonConvert.DeserializeObject<TemplatesModel.ResultData>(JsonConvert.SerializeObject(value));
                newItem.Key = Key;

                var result = Agilite.Templates.PostData(newItem);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.Key, Key);

                RecordId = result.ResponseData.Id;
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //2. Get Data - Slim Result - Find Record By Id
        private void Templates2GetDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Templates.GetData();

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Count > 0, true);
                foreach (var item in result.ResponseData) {
                    if (item.Id == RecordId) {
                        Assert.AreNotEqual(item.Data, null);
                        Assert.AreEqual(item.CreatedBy, null);
                    }
                }
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //3. Update Record
        private void Templates3UpdateRecordTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                Key = "PUT_" + Key;

                TemplatesModel.ResultData modifiedItem = JsonConvert.DeserializeObject<TemplatesModel.ResultData>(JsonConvert.SerializeObject(_mainEntry.modifiedItem.data));

                modifiedItem.Key = Key;
                modifiedItem.GroupName = GroupName;

                var result = Agilite.Templates.PutData(RecordId, modifiedItem);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.GroupName, GroupName);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //4. Execute
        private void Templates4Execute() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(Key), false);
                var result = Agilite.Templates.Execute(Key);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, "<html>Template test New</html>");
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //5. Delete
        private void Templates5DeleteDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Templates.DeleteData(RecordId);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, JsonConvert.SerializeObject("{}"));
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }
    }
}