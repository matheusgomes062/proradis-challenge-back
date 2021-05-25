using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Seta o Schema default
            //modelBuilder.HasDefaultSchema("Apoio");

            //Remove a pluralização dos nomes das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Remove exclusão em cascata (permite maior controle)
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setar para usar varchar ou invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //Caso eu esqueça de informar o tamanho do campo ele irá colocar varchar de 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //Mapeia as entidades
            //modelBuilder.Configurations.Add(new PatientMap());
            //modelBuilder.Configurations.Add(new VaccineMap());

            #region Adiciona entidades mapeadas - Automaticamente via Assembly
            modelBuilder.Configurations.AddFromAssembly(typeof(VaccineAPI5Context).Assembly);
            #endregion

            #region Adiciona entidades mapeadas - Automaticamente via NameSpace
            //Assembly.GetExecutingAssembly().GetTypes()
            //    .Where(type => type.Namespace == "VaccineAPI5Context.Domain.Entities.DomainViagem")
            //    .ToList()
            //    .ForEach(type =>
            //    {
            //        dynamic instance = Activator.CreateInstance(type);
            //        modelBuilder.Configurations.Add(instance);
            //    });
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
