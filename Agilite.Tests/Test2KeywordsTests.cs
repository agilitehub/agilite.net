using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Agilite.Models;
using Agilite.Tests.DataTemplates;
using Agilite.Tests.Library;
using static Agilite.Models.KeywordsModel;

namespace Agilite.Tests {
    [TestClass()]
    public class Test2KeywordsTests : BaseClass {
        private readonly dynamic _mainEntry = JsonConvert.DeserializeObject(KeywordsData.Data);

        [TestMethod]
        public void RunAllKeywordTests() {
            Keywords_1_PostDataTest();
            Keywords_2_GetDataTest();
            Keywords_3_UpdateRecordTest();
            Keywords_4_GetByProfileKeyTest();
            Keywords_5_GetProfileKeysByGroupTest();
            Keywords_6_GetLabelByValueTest();
            Keywords_7_GetValueByLabelTest();
            Keywords_8_DeleteDataTest();
        }

        //1. Create New Record
        private void Keywords_1_PostDataTest() {
            try {
                var values = new List<BaseModel.ResultDataValues>();

                foreach (var item in _mainEntry.newItem.data.values) {
                    values.Add(new BaseModel.ResultDataValues { Label = item.label, Value = item.value });
                }

                var result = Agilite.Keywords.PostData(new ResultData { Key = Key, Values = values });

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.GroupName, string.Empty);
                Assert.AreEqual(JsonConvert.SerializeObject(result.ResponseData.Data.Values), JsonConvert.SerializeObject(_mainEntry.newItem.data.values));

                RecordId = result.ResponseData.Id;
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //2. Get Data - Slim Result - Find Record By Id
        private void Keywords_2_GetDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Keywords.GetData();

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Count > 0, true);
                foreach (var item in result.ResponseData) {
                    if (item.Id == RecordId) {
                        Assert.AreNotEqual(item.Data, null);
                        Assert.AreNotEqual(item.Data.Values, null);
                        Assert.AreEqual(item.CreatedBy, null);
                    }
                }
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //3. Update Record
        private void Keywords_3_UpdateRecordTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                Key = "PUT_" + Key;

                var values = new List<BaseModel.ResultDataValues>();

                foreach (var item in _mainEntry.modifiedItem.data.values) {
                    values.Add(new BaseModel.ResultDataValues { Label = item.label, Value = item.value });
                }

                var result = Agilite.Keywords.PutData(RecordId, new ResultData { Key = Key, Values = values, GroupName = GroupName });

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.GroupName, GroupName);
                Assert.AreEqual(JsonConvert.SerializeObject(result.ResponseData.Data.Values), JsonConvert.SerializeObject(_mainEntry.modifiedItem.data.values));

            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //4. Get By Profile Key
        private void Keywords_4_GetByProfileKeyTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(Key), false);
                var result = Agilite.Keywords.GetByProfileKeyList(Key);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(JsonConvert.SerializeObject(result.ResponseData), JsonConvert.SerializeObject(_mainEntry.modifiedItem.data.values));

                Assert.AreEqual(result.ResponseData.Count > 0, true);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //5. Get Profile Keys by Group
        private void Keywords_5_GetProfileKeysByGroupTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(GroupName), false);
                var result = Agilite.Keywords.GetProfileKeysByGroup(GroupName);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Count > 0, true);
                Assert.AreEqual(result.ResponseData[0], Key);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //6. Get Label By Value
        private void Keywords_6_GetLabelByValueTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(Key), false);
                string value = _mainEntry.modifiedItem.data.values[0].value.Value;
                var result = Agilite.Keywords.GetLabelByValueString(Key, value);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, _mainEntry.modifiedItem.data.values[0].label.Value);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //7. Get Value By Label
        private void Keywords_7_GetValueByLabelTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(Key), false);
                string value = _mainEntry.modifiedItem.data.values[0].label.Value;
                var result = Agilite.Keywords.GetValueByLabelString(Key, value);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, _mainEntry.modifiedItem.data.values[0].value.Value);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        ////8. Delete Record
        private void Keywords_8_DeleteDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Keywords.DeleteData(RecordId);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, JsonConvert.SerializeObject("{}"));
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

    }
}