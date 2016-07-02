using FHIR.Data;
using FHIR.Data.Entities;
using FHIR.Data.Enum;
using FHIR.Data.Service;
using FHIR.Data.Service.Interface;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
namespace FHIRUnitTest
{
    [TestFixture]
    public class FHIRTests
    {
        private IFHIRPatientService testPatientService;
        private IFHIRServerAccessService testServerService;
        private String TestServer = "http://spark.furore.com/fhir";

        [SetUp()]
        public void Init()
        {
            if (this.testPatientService == null)
                this.testPatientService = new FHIRPatientService();

            if (this.testServerService == null)
                this.testServerService = new FHIRServerAccessService(new Uri(TestServer));

        }

        [Test]
        public void Create_Test()
        {
            PatientEntity obj = new PatientEntity
            {
                Name = "Alan Turing",
                FamilyName = "alpha",
                Gender = Gender.Male,
                HealthStatus = (int)HealthStatus.Good,
                MaritalStatus = (int)MaritalStatus.Married,
                DateOfBirth = DateTime.Now.AddDays(-7500),
                Comments = "na",
                CreatedAt = DateTimeOffset.Now,
                LastModifiedAt = DateTimeOffset.Now

            };
            var success = this.testPatientService.Create(obj);
            Assert.AreEqual(true, success);
        }

        [Test]
        public void Update_Test()
        {

            PatientEntity obj = new PatientEntity
            {
                Id = 21,
                Name = "Alan Turing",
                FamilyName = "alpha",
                Gender = Gender.Male,
                HealthStatus = (int)HealthStatus.Good,
                MaritalStatus = (int)MaritalStatus.Married,
                DateOfBirth = DateTime.Now.AddDays(-7500),
                Comments = "na",
                CreatedAt = DateTimeOffset.Now,
                LastModifiedAt = DateTimeOffset.Now

            };
            this.testPatientService.Create(obj);

            PatientEntity objd = new PatientEntity
            {
                Id = 21,
                Name = "Alan",
                FamilyName = "Fot",
                Gender = Gender.Male,
                HealthStatus = (int)HealthStatus.Good,
                MaritalStatus = (int)MaritalStatus.Married,
                DateOfBirth = DateTime.Now.AddDays(-7500),
                Comments = "testupdate",
                CreatedAt = DateTimeOffset.Now,
                LastModifiedAt = DateTimeOffset.Now

            };
            Assert.AreEqual(true, this.testPatientService.Update(objd));


        }


        [Test]
        public void Delete_Test()
        {
            var success = this.testPatientService.Delete(3);
            Assert.AreEqual(true, success);
        }
        /*
           [Test]
           public void DeletefromDB_Test()
           {
               PatientEntity obj = new PatientEntity
               {
                   Id = 2121,
                   Name = "Ajay",
                   FamilyName = "alpha",
                   Gender = Gender.Male,
                   HealthStatus = (int)HealthStatus.Good,
                   MaritalStatus = (int)MaritalStatus.Single,
                   DateOfBirth = DateTime.Now.AddDays(-7500),
                   Comments = "na",
                   CreatedAt = DateTimeOffset.Now,
                   LastModifiedAt = DateTimeOffset.Now

               };
               this.testPatientService.Create(obj);
               var success = this.testPatientService.DeletefromDB(2121);
               Assert.AreEqual(true, success);
           }
         */
        [Test]
        public void ReadAll_Test()
        {
            DataTable success = this.testPatientService.GetAll();
            Assert.IsNotNull(success);
        }

        [Test]
        public void GetById_Test()
        {
            DataRow test = this.testPatientService.GetById(1);

            Assert.IsNotNull(test);
        }

        [Test]
        public void Search_Test()
        {
            PatientEntity obj = new PatientEntity
            {
                Name = "Searchtest",
                FamilyName = "Foxtrot",
                Gender = Gender.Male,
                HealthStatus = (int)HealthStatus.Good,
                MaritalStatus = (int)MaritalStatus.Married,
                DateOfBirth = DateTime.Now.AddDays(-7500),
                Comments = "na",
                CreatedAt = DateTimeOffset.Now,
                LastModifiedAt = DateTimeOffset.Now

            };
            this.testPatientService.Create(obj);
            DataTable test = this.testPatientService.Search("Searchtest");

            Assert.IsNotNull(test);
        }

        [Test]
        public void BatchCreate_Test()
        {
            List<PatientEntity> objd = new List<PatientEntity>();

            for (int i = 0; i < 3; i++)
            {
                PatientEntity obj = new PatientEntity
                {
                    Name = new Guid().ToString(),
                    FamilyName = "Foxtrot",
                    Gender = Gender.Male,
                    HealthStatus = (int)HealthStatus.Good,
                    MaritalStatus = (int)MaritalStatus.Married,
                    DateOfBirth = DateTime.Now.AddDays(-7500),
                    Comments = "na",
                    CreatedAt = DateTimeOffset.Now,
                    LastModifiedAt = DateTimeOffset.Now

                };
                objd.Add(obj);
            }
            var success = this.testPatientService.BatchCreate(objd);
            Assert.AreEqual(true, success);
        }
        [Test]
        public void FetchAll_Test()
        {
            bool success = false;
            if (this.testServerService.FetchAll().Rows.Count > 0)
                success = true;
            Assert.AreEqual(true, success);
        }

        [Test]
        public void SearchPatientByName_Test()
        {
            Assert.IsNotNull(this.testServerService.SearchPatientByName("john"));
        }
        [TearDown()]
        public void Clean()
        {

        }
    }
}
