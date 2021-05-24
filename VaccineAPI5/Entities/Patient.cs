using System;
using VaccineAPI5.ValueObjects;

namespace VaccineAPI5.Models
{
    public class Patient
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Email Email { get; set; }

        public int Cpf { get; set; }

        public DateTime Birthdate { get; set; }

        public bool Comorbidity { get; set; }

        public string Address { get; set; }

        public string District { get; set; }

        public string State { get; set; }

        public string City { get; set; }
    }
}
