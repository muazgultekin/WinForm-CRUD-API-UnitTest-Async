using Employees.Models;
using Employees.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;

namespace Employees.UnitTestProject
{
    [TestClass]

    public class UnitTest1
    {
        public int Id { get; set; }

        [TestMethod]
        public void ALL()
        {
            CreateUser();
            UpdateUser();
            DeleteUser();
        }

        public void CreateUser()
        {
            try
            {
                Controllers.EmployeeRepository employeeRepository = new Controllers.EmployeeRepository();
                Root root = new Root
                {
                    data = new System.Collections.Generic.List<Personel>
                    {
                        new Personel
                        {
                            id = 0,
                            name = "Muaz Gultekin",
                            email = "muaz1.muaz1@muaz.com",
                            gender = "male",
                            status = "active"
                        }
                    }
                };
                SetRoot setRoot = JsonConvert.DeserializeObject<SetRoot>(employeeRepository.PostPutUsers(MethodType.POST, root).Result);
                Id = setRoot.data.id;
            }
            catch
            {

            }
            Assert.IsTrue(Id > 0);
        }
        public void UpdateUser()
        {
            try
            {
                Controllers.EmployeeRepository employeeRepository = new Controllers.EmployeeRepository();
                Root root = new Root
                {

                    data = new System.Collections.Generic.List<Personel>
                    {
                        new Personel
                        {
                            id = 0,
                            name = "Muaz Gultekin",
                            email = "muaz1.muaz1@muaz.com",
                            gender = "male",
                            status = "active"
                        }
                    }
                };
                SetRoot setRoot = JsonConvert.DeserializeObject<SetRoot>(employeeRepository.PostPutUsers(MethodType.POST, root).Result);
                Id = setRoot.data.id;
            }
            catch
            {

            }
            Assert.IsTrue(Id > 0);
        }



        public void DeleteUser()
        {
            SetRoot setRoot = null;
            try
            {
                Controllers.EmployeeRepository employeeRepository = new Controllers.EmployeeRepository();
                setRoot = JsonConvert.DeserializeObject<SetRoot>(employeeRepository.DeleteUsers(Id.ToString()).Result);
            }

            catch
            {
                Assert.IsFalse(true);
            }

            Assert.IsTrue(setRoot.code == 204);

        }

    }
}
