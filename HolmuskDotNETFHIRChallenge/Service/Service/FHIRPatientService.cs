

namespace FHIR.Data.Service
{
    using FHIR.Data.Context;
    using FHIR.Data.Entities;
    using FHIR.Data.Extension;
    using FHIR.Data.Service.Interface;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class FHIRPatientService : IFHIRPatientService
    {
        
        /// <summary>
        /// Service method to get patient by Id
        /// </summary>
        /// <param name="id">patient id</param>
        /// <returns>Data row</returns>
        public DataRow GetById(int id)
        {
            using (var context = new FHIRDbContext())
            {
                PatientEntity membership = context.Patients
                    .Where(i => i.Id == id)
                    .SingleOrDefault();

                
                return membership.ToDataRow<PatientEntity>();
            }            
        }

        /// <summary>
        /// Service method to get all patients
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAll()
        {
            using (var context = new FHIRDbContext())
            {
                IList<PatientEntity> patients = context.Patients.Where(i => i.SoftDelete == false).ToList();
                return patients.ToDataTable<PatientEntity>();
            }
        }

        /// <summary>
        /// Service method to search records by multiple parameters
        /// </summary>
        /// <param name="filter">filter string</param>
        /// <returns>Data table</returns>
        public DataTable Search(string filter)
        {
            using (var context = new FHIRDbContext())
            {
                List<PatientEntity> patients = context.Patients.Where(i => (i.Name.Contains(filter) &&  i.SoftDelete == false))
                    .ToList();

                return patients.ToDataTable<PatientEntity>();
            }
        }        

        /// <summary>
        /// Service method to create patient
        /// </summary>
        /// <param name="patient">patient model</param>
        /// <returns>true or false</returns>
        public bool Create(PatientEntity patient)
        {
            using (var context = new FHIRDbContext())
            {
                context.Patients.Add(patient);
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Service method to batch create patient
        /// </summary>
        /// <param name="patient">patient list</param>
        /// <returns>true or false</returns>
        public bool BatchCreate(List<PatientEntity> patientlist)
        {
            using (var context = new FHIRDbContext())
            {
                try
                {
                    foreach (var row in patientlist)
                    {
                        context.Patients.Add(row);
                    }
                    return context.SaveChanges()>0;
                }
                catch (Exception ex)
                {
                    return false;
                }  
               
               
            }
        }
        /// <summary>
        /// Service method to update patient
        /// </summary>
        /// <param name="patient">patient</param>
        /// <returns>true / false</returns>
        public bool Update(PatientEntity patient)
        {
            using (var context = new FHIRDbContext())
            {
                context.Patients.Attach(patient);
                context.Entry(patient).State = EntityState.Modified;                
                return context.SaveChanges() > 0;
                
            }
        }

        /// <summary>
        /// Method to soft delete a patient
        /// </summary>
        /// <param name="id">patient id</param>
        /// <returns>true / false</returns>
        public bool Delete(int id)
        {
            using (var context = new FHIRDbContext())
            {
                var patient = context.Patients.Find(id);
                patient.SoftDelete = true;
                context.Patients.Attach(patient);
                context.Entry(patient).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }            
        }

        /// <summary>
        /// Method to delete a patient
        /// </summary>
        /// <param name="id">patient id</param>
        /// <returns>true / false</returns>
        public bool DeletefromDB(int id)
        {
            using (var context = new FHIRDbContext())
            {
                var patient = context.Patients.Find(id);
              context.Patients.Remove(patient);
                return context.SaveChanges() > 0;
            }
        }
    }
}
