using System;
using VaccineAPI5.Arguments.Patient;
using VaccineAPI5.Domain.Interfaces.Repositories;
using VaccineAPI5.Interfaces.Services;
using VaccineAPI5.ValueObjects;

namespace VaccineAPI5.Services
{
    public class ServicePatient : IServicePatient
    {
        private readonly IRepositoryPatient _repositoryPatient;

        public ServicePatient(IRepositoryPatient repositoryPatient)
        {
            _repositoryPatient = repositoryPatient;
        }

        public AddPatientResponse AddPatient(AddPatientRequest request)
        {
            if(request == null)
            {
                throw new Exception("AddPatientRequest obrigatório");
            }

            if(string.IsNullOrEmpty(request.Name))
            {
                throw new Exception("Informe um nome.");
            }
            if (IsEmail(request.Email))
            {
                throw new Exception("Informe um Email.");
            }
            if (IsCpf(request.Cpf))
            {
                throw new Exception("Informe um Cpf.");
            }
            //if (DateTime(request.Birthdate))
            //{
            //    throw new Exception("Informe uma data de nascimento.");
            //}
            //if (bool(request.Comorbidity))
            //{
            //    throw new Exception("Informe se possui comorbidade.");
            //}
            if (string.IsNullOrEmpty(request.District))
            {
                throw new Exception("Informe o bairro.");
            }
            if (string.IsNullOrEmpty(request.State))
            {
                throw new Exception("Informe o Estado.");
            }
            if (string.IsNullOrEmpty(request.City))
            {
                throw new Exception("Informe a Cidade.");
            }

            Guid id = _repositoryPatient.AddPatient(request);
            return new AddPatientResponse() { Id = id, Message = "Operação realizada com sucesso!" };
        }

        private bool IsCpf(int cpf)
        {
            throw new NotImplementedException();
        }

        private bool IsEmail(Email email)
        {
            return false;
        }
    }
}
