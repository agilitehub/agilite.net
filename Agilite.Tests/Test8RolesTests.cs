using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Agilite.Models;
using Agilite.Tests.DataTemplates;
using Agilite.Tests.Library;

namespace Agilite.Tests {
    [TestClass()]
    public class Test8RolesTests : BaseClass {
        private readonly dynamic _mainEntry = JsonConvert.DeserializeObject(RolesData.Data);

        private readonly string _processKey = Guid.NewGuid().ToString();
        private readonly string _bpmRecordId = Guid.NewGuid().ToString();
        private readonly string _roleName = Guid.NewGuid().ToString();

        [TestMethod]
        public void RunAllNumberingTests() {
            Roles1PostDataTest();
            Roles2GetDataTest();
            Roles3UpdateRecordTest();
            Roles4DeleteDataTest();
            Roles5AssignRoleTest();
            Roles6GetAssignedRolesTest();
            Roles7GetAssignedRolesTest();
            Roles8GetRoleTest();
            Roles9ChangeConditionalLevelsTest();
            Roles91DeleteDataTest();
        }

        //1. Create New Record
        private void Roles1PostDataTest() {
            try {
                var value = _mainEntry.newItem.data;
                RolesModel.ResultData newItem = JsonConvert.DeserializeObject<RolesModel.ResultData>(JsonConvert.SerializeObject(value));
                newItem.Name = Key;

                var result = Agilite.Roles.PostData(newItem);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.ResponsibleUser.Count, 1);
                Assert.AreEqual(result.ResponseData.Data.Name, Key);

                RecordId = result.ResponseData.Id;
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //2. Get Data - Slim Result - Find Record By Id
        private void Roles2GetDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Roles.GetData();

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
        private void Roles3UpdateRecordTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                Key = "PUT_" + Key;

                RolesModel.ResultData modifiedItem = JsonConvert.DeserializeObject<RolesModel.ResultData>(JsonConvert.SerializeObject(_mainEntry.modifiedItem.data));

                modifiedItem.Name = Key;
                modifiedItem.GroupName = GroupName;

                var result = Agilite.Roles.PutData(RecordId, modifiedItem);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.Data.GroupName, GroupName);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //4. Delete
        private void Roles4DeleteDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Roles.DeleteData(RecordId);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, JsonConvert.SerializeObject("{}"));
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //5. Assign Role
        private void Roles5AssignRoleTest() {
            try {
                var result = Agilite.Roles.AssignRole(_processKey, _bpmRecordId, _roleName, "roles.current@acme.com", new List<string> { "roles.resp1@acme.com", "roles.resp2@acme.com" });

                Utilities.CheckError(result.Error);

                RecordId = result.ResponseData.Id;
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //6. Assign Role
        private void Roles6GetAssignedRolesTest() {
            try {
                var result = Agilite.Roles.GetAssignedRoles(_processKey, _bpmRecordId, new List<string> { _roleName });

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData[0].Users.Count, 2);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //7. Get Assigned Roles
        private void Roles7GetAssignedRolesTest() {
            try {
                var result = Agilite.Roles.GetAssignedRoles(_processKey, _bpmRecordId, new List<string> { _roleName });

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData[0].Users.Count, 2);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //8. GetRole
        private void Roles8GetRoleTest() {
            try {
                var result = Agilite.Roles.GetRole(new List<string> { _roleName }, new List<string> { _processKey, _bpmRecordId });

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData.ResponsibleUsers.Count, 2);
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //8. Change Conditional Levels
        private void Roles9ChangeConditionalLevelsTest() {
            try {
                var result = Agilite.Roles.ChangeConditionalLevels(RecordId, new List<string> { _bpmRecordId });

                Utilities.CheckError(result.Error);

                Assert.AreEqual(JsonConvert.SerializeObject(result.ResponseData), JsonConvert.SerializeObject("{}"));

            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        //9. Delete
        private void Roles91DeleteDataTest() {
            try {
                Assert.AreEqual(string.IsNullOrEmpty(RecordId), false);
                var result = Agilite.Roles.DeleteData(RecordId);

                Utilities.CheckError(result.Error);

                Assert.AreEqual(result.ResponseData, JsonConvert.SerializeObject("{}"));
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }
    }
}