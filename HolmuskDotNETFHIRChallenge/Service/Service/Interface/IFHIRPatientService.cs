using FHIR.Data.Entities;
using System.Collections.Generic;
using System.Data;

namespace FHIR.Data.Service.Interface
{
    public interface IFHIRPatientService
    {
        /// <summary>
        /// Method to get all patients
        /// </summary>
        /// <returns>Data table</returns>
        DataRow GetById(int Id);

        /// <summary>
        /// Service method to get all patients
        /// </summary>
        /// <returns>Data table</returns>
        DataTable GetAll();

        /// <summary>
        /// Service method to search records by multiple parameters
        /// </summary>
        /// <param name="filter">filter string</param>
        /// <returns>Data table</returns>
        DataTable Search(string filter);

        /// <summary>
        /// Service method to create patient
        /// </summary>
        /// <param name="patient">patient model</param>
        /// <returns>true or false</returns>
        bool Create(PatientEntity patient);


        /// <summary>
        /// Service method to batch create patient
        /// </summary>
        /// <param name="patient">patient list</param>
        /// <returns>true or false</returns>
        bool BatchCreate(List<PatientEntity> patientlist);

        /// <summary>
        /// Method to update patient details
        /// </summary>
        /// <param name="patient">patient</param>
        /// <returns></returns>
        bool Update(PatientEntity patient);

        /// <summary>
        /// Method to soft delete a patient
        /// </summary>
        /// <param name="id">patient id</param>
        /// <returns>true / false</returns>
        bool Delete(int id);


        /// <summary>
        /// Method to delete a patient from db
        /// </summary>
        /// <param name="id">patient id</param>
        /// <returns>true / false</returns>
        bool DeletefromDB(int id);      
    }
}
