using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using Agilite.Tests.DataTemplates;
using Agilite.Tests.Library;
using static Agilite.Models.NumberingModel;

namespace Agilite.Tests {
    [TestClass()]
    public class Test3NumberingTests : BaseClass {
        private readonly dynamic _mainEntry = JsonConvert.DeserializeObject(NumberingData.Data);

        [TestMethod]
        public void RunAllNumberingTests() {
            Numbering_1_PostDataTest();
            Numbering_2_GetDataTest();
            Numbering_3_GenerateTest_1();
            Numbering_4_UpdateRecordTest();
            Numbering_5_GenerateTest_2();
            Numbering_6_GenerateTest_3();
            Numbering_7_ResetNumberTest();
            Numbering_8_GenerateTest_4();
            Numbering_9_DeleteDataTest();
        }

        //1. Create New Record
        private void Numbering_1_PostDataTest() {
            try {
                var value = _mainEntry.newItem.data;
                ResultData newItem = JsonConvert.DeserializeObject<ResultData>(JsonConvert.SerializeObject(value));
                newItem.Name = Key;
                newItem.Key = Key;

                var result = Agilite.Numbering.PostData(newItem);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.Name, Key);

                RecordId = result.ResponseData.Id;
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //2. Get Data - Slim Result - Find Record By Id
        private void Numbering_2_GetDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Numbering.GetData();

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

        //3. Generate Number - Test 1
        private void Numbering_3_GenerateTest_1() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(Key), false);
                var result = Agilite.Numbering.GenerateString(Key);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(int.TryParse(result.ResponseData, out _), true);
                Assert.AreEqual(int.Parse(result.ResponseData), 1);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //4. Update Record
        private void Numbering_4_UpdateRecordTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                Key = "PUT_" + Key;

                ResultData modifiedItem = JsonConvert.DeserializeObject<ResultData>(JsonConvert.SerializeObject(_mainEntry.modifiedItem.data));

                modifiedItem.Key = Key;
                modifiedItem.Name = Key;
                modifiedItem.GroupName = GroupName;

                var result = Agilite.Numbering.PutData(RecordId, modifiedItem);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.GroupName, GroupName);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //5. Generate Number - Test 2
        private void Numbering_5_GenerateTest_2() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(Key), false);
                var result = Agilite.Numbering.GenerateString(Key);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, "PRE00010SUF");
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //6. Generate Number - Test 3
        private void Numbering_6_GenerateTest_3() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(Key), false);
                var result = Agilite.Numbering.GenerateString(Key);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, "PRE00011SUF");
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //7. Generate Number - Test 3
        private void Numbering_7_ResetNumberTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Numbering.ResetCounters(RecordId);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(JsonConvert.SerializeObject(result.ResponseData), JsonConvert.SerializeObject("{}"));
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //8. Generate Number - Test 4
        private void Numbering_8_GenerateTest_4() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(Key), false);
                var result = Agilite.Numbering.GenerateString(Key);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, "PRE00010SUF");
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        private void Numbering_9_DeleteDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Numbering.DeleteData(RecordId);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, JsonConvert.SerializeObject("{}"));
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }
    }
}