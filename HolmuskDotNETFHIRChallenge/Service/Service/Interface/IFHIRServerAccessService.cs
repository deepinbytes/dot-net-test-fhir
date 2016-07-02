using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FHIR.Data.Entities;
using System.Data;
using Hl7.Fhir.Rest;
namespace FHIR.Data.Service.Interface
{
    public interface IFHIRServerAccessService
    {

        /// <summary>
        /// Searches a patient based on his/her name.
        /// </summary>
        /// <param name="name">The name of the patient.</param>
        /// <returns>The patients matching the search query.</returns>
        DataTable SearchPatientByName(string name);

        /// <summary>
        /// Gets patients from the FHIR server without any search query.
        /// </summary>
        /// <returns>The first patients returned by the server.</returns>
        DataTable FetchAll();

        /// <summary>
        /// Gets server instance.
        /// </summary>
        /// <returns>fhirclient instance.</returns>
        FhirClient getServerInstance();
    }
}
