using System;
using System.Configuration;
using System.Data.Entity;
using VaccineAPI5.Entities;

namespace VaccineAPI5.Infra.Persistence
{
    public class VaccineAPI5Context : DbContext
    {
        public VaccineAPI5Context() : base("VaccineAPI5ConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Patient> Patients { get; set; }

        public IDbSet<Vaccine> Vaccines { get; set; }
    }
}
