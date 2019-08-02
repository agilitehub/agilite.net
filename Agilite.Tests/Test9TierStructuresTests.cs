using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Agilite.Models;
using Agilite.Tests.DataTemplates;
using Agilite.Tests.Library;

namespace Agilite.Tests {
    [TestClass()]
    public class Test9TierStructuresTests : BaseClass {
        private readonly dynamic _mainEntry = JsonConvert.DeserializeObject(TierStructuresData.Data);
        
        [TestMethod]
        public void RunAllNumberingTests() {
            TierStructures1PostDataTest();
            TierStructures2GetDataTest();
            TierStructures3UpdateRecordTest();
            TierStructures4GetTierByKeyTest();
            TierStructures5DeleteDataTest();
        }

        //1. Create New Record
        private void TierStructures1PostDataTest() {
            try {
                var value = _mainEntry.newItem.data;
                TierStructuresModel.ResultData newItem = JsonConvert.DeserializeObject<TierStructuresModel.ResultData>(JsonConvert.SerializeObject(value));
                newItem.Key = Key;

                var result = Agilite.TierStructures.PostData(newItem);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.Key, Key);
                Assert.AreEqual(result.ResponseData.Data.Values.Count, 1);

                RecordId = result.ResponseData.Id;
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //2. Get Data - Slim Result - Find Record By Id
        private void TierStructures2GetDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.TierStructures.GetData();

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
        private void TierStructures3UpdateRecordTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                Key = "PUT_" + Key;

                TierStructuresModel.ResultData modifiedItem = JsonConvert.DeserializeObject<TierStructuresModel.ResultData>(JsonConvert.SerializeObject(_mainEntry.modifiedItem.data));
                modifiedItem.Key = Key;

                var result = Agilite.TierStructures.PutData(RecordId, modifiedItem);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.TierEntries.Count > 0, true);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //4. Get Tier By Key - Tier 1
        private void TierStructures4GetTierByKeyTest() {
            try
            {
                var result = Agilite.TierStructures.GetTierByKeyDynamic(new List<string>{Key},true,true,true,AgilEnums.SortOrder.Ascending);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.values.Count > 0, true);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //5. Delete
        private void TierStructures5DeleteDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.TierStructures.DeleteData(RecordId);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, JsonConvert.SerializeObject("{}"));
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }
    }
}