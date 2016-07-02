using System;
using System.ComponentModel;
using FHIR.Data.Enum;

namespace FHIR.Data.Entities
{
    public class PatientEntity
    {
     
        public long Id { get; set; }

        public string Name { get; set; }

        public string FamilyName { get; set; }
       
        public int MaritalStatus { get; set; }

        public int HealthStatus { get; set; }

        public bool SoftDelete { get; set; }

        public System.DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string Comments { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset LastModifiedAt { get; set; }


    }
}
