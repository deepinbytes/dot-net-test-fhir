using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FHIR.Data.Context;
using FHIR.Data.Enum;
using FHIR.Data.Entities;
using FHIR.Data.Extension;
using FHIR.Data.Service.Interface;
using System.Configuration;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Patient = Hl7.Fhir.Model.Patient;
using System.Data;

namespace FHIR.Data.Service
{
   public class FHIRServerAccessService : IFHIRServerAccessService
    {
      
       private readonly FhirClient _client;

       public FHIRServerAccessService(Uri endPoint)
        {
            _client = new FhirClient(endPoint);
        }
       public FhirClient getServerInstance()
       {
           if(_client==null)
               new FhirClient(ConfigurationManager.AppSettings["FHIRDefaultURI"]);

           return _client;
       }
        private DataTable Search(SearchParams searchParams)
        {
            try
            {
                var result = _client.Search(searchParams, "Patient");
                return result.Entry.Select(i => i.Resource as Patient).Select(ConvertFHIREntityToLocal).OfType<PatientEntity>().ToList().ToDataTable<PatientEntity>();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        private PatientEntity ConvertFHIREntityToLocal(Patient fhirPatient)
        {
            try
            {
                if ((fhirPatient.Name.FirstOrDefault().Given.First() == string.Empty) ||
                    (fhirPatient.Name.FirstOrDefault().Family.First() == string.Empty))
                    return null;
                return new PatientEntity
                {
                    Name = fhirPatient.Name.First().Given.First(),
                    FamilyName = fhirPatient.Name.First().Family.First(),
                    DateOfBirth = DateTime.Parse(fhirPatient.BirthDate),
                    Gender = fhirPatient.Gender == AdministrativeGender.Male
                        ? Gender.Male
                        : fhirPatient.Gender == AdministrativeGender.Female
                            ? Gender.Female
                            : Gender.Other,
                    Comments = string.Join(Environment.NewLine, fhirPatient.FhirComments)
                };
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public DataTable FetchAll()
        {
            return Search(new SearchParams());
        }

        public DataTable SearchPatientByName(string patientname)
        {
            var param = new SearchParams
            {
                Parameters = {new Tuple<string, string>("name", patientname)}
            };
            return Search(param);
        }
    }
}
