using FHIR.Data.Context;
using FHIR.Data.Entities;
using FHIR.Data.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace FHIR.Data.Initializer
{
    public class ClientAppInitializer : DropCreateDatabaseIfModelChanges<FHIRDbContext>
    {
        protected override void Seed(FHIRDbContext context)
        {
            var patient = new List<PatientEntity>{
                new PatientEntity { Name = "Alan Turing", FamilyName = "Foxtrot", Gender =  Gender.Male, HealthStatus = (int)HealthStatus.Good, MaritalStatus = (int)MaritalStatus.Married,  DateOfBirth = DateTime.Now.AddDays(-7500), Comments = "na" ,CreatedAt=DateTimeOffset.Now,LastModifiedAt=DateTimeOffset.Now},
                new PatientEntity { Name = "Pit Bull", FamilyName = "Philips", Gender = Gender.Male,HealthStatus = (int)HealthStatus.Excellent, MaritalStatus = (int)MaritalStatus.Single,  DateOfBirth = DateTime.Now.AddDays(-6500), Comments = "na",CreatedAt=DateTimeOffset.Now,LastModifiedAt=DateTimeOffset.Now},
                new PatientEntity { Name = "Hans Zimmer" ,FamilyName = "Nolan", Gender = Gender.Male, HealthStatus = (int)HealthStatus.Good, MaritalStatus = (int)MaritalStatus.Single,DateOfBirth = DateTime.Now.AddDays(-6500), Comments = "na",CreatedAt=DateTimeOffset.Now,LastModifiedAt=DateTimeOffset.Now},
                new PatientEntity { Name = "Christopher Nolan",FamilyName = "Adam", Gender = Gender.Male, HealthStatus = (int)HealthStatus.Excellent, MaritalStatus = (int)MaritalStatus.Single, DateOfBirth = DateTime.Now.AddDays(-6500), Comments = "na",CreatedAt=DateTimeOffset.Now,LastModifiedAt=DateTimeOffset.Now}
            };

            patient.ForEach(category => context.Patients.Add(category));
        }
    }
}
