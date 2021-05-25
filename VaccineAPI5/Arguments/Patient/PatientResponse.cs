using System;
namespace VaccineAPI5.Domain.Arguments.Patient
{
    public class PatientResponse
    {
        public Guid Id { get; set; }

        public string Name { get;   set; }

        public string Email { get;  set; }

        public string Cpf { get;  set; }

        public string Birthdate { get;  set; }

        public bool Comorbidity { get;  set; }

        public static explicit operator PatientResponse(Entities.Patient entity)
        {
            return new PatientResponse() {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Cpf = entity.Cpf,
                Birthdate = entity.Birthdate,
                Comorbidity = entity.Comorbidity
            };
        }
    }
}
