using FHIR.Data.Entities;
using FHIR.Data.Initializer;
using System.Data.Entity;

namespace FHIR.Data.Context
{
    public class FHIRDbContext : DbContext
    {
        public FHIRDbContext()
            : base("FHIR.DbConnection")
        {

            Database.SetInitializer<FHIRDbContext>(new ClientAppInitializer());
            Configuration.ProxyCreationEnabled = false;
        }
       
        public DbSet<PatientEntity> Patients { get; set; }
    }
}
