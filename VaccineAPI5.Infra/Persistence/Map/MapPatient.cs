using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using VaccineAPI5.Entities;

namespace VaccineAPI5.Infra.Persistence.Map
{
    public class MapPatient: EntityTypeConfiguration<Patient>
    {
        public MapPatient()
        {
            ToTable("Patient");

            Property(p => p.Email.Endereco)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(
                    new IndexAttribute("UK_PATIENT_EMAIL")
                    {
                        IsUnique = true
                    }))
                .HasColumnName("Email");
            Property(p => p.Name)
                .IsRequired();
            Property(p => p.Cpf)
                .IsRequired();
            Property(p => p.Birthdate)
                .IsRequired();
            Property(p => p.Comorbidity)
                .IsRequired();
            Property(p => p.Address)
                .IsRequired();
            Property(p => p.District)
                .IsRequired();
            Property(p => p.State)
                .IsRequired();
            Property(p => p.City)
                .IsRequired();
        }
    }
}
