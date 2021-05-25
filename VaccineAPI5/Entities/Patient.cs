using System;
using prmToolkit.NotificationPattern;
using VaccineAPI5.ValueObjects;

namespace VaccineAPI5.Entities
{
    public class Patient : Notifiable
    {
        protected Patient()
        {

        }

        public Patient(string name, Email email, string cpf,
            string birthdate, bool comorbidity,
            string address, string district, string state,
            string city)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            Birthdate = birthdate;
            Comorbidity = comorbidity;
            Address = address;
            District = district;
            State = state;
            City = city;
            Id = Guid.NewGuid();

            new AddNotifications<Patient>(this)
                .IfNotCpf(x => x.Cpf, "Informe um cpf válido!")
                .IfNotDate(x => x.Birthdate, "Informe uma data válida!")
                .IfNull(x => x.Comorbidity, "Informe se o paciente possui alguma comorbidade")
                .IfNullOrWhiteSpace(x => x.Address, "Informe o endereço!")
                .IfNullOrWhiteSpace(x => x.District, "Informe o Bairro!")
                .IfNullOrWhiteSpace(x => x.State, "Informe o Estado!")
                .IfNullOrWhiteSpace(x => x.City, "Informe o Cidade!");
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public Email Email { get; private set; }

        public string Cpf { get; private set; }

        public string Birthdate { get; private set; }

        public bool Comorbidity { get; private set; }

        public string Address { get; private set; }

        public string District { get; private set; }

        public string State { get; private set; }

        public string City { get; private set; }
    }
}
