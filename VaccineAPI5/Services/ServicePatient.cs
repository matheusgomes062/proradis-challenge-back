using System;
using VaccineAPI5.Arguments.Patient;
using VaccineAPI5.Domain.Interfaces.Repositories;
using VaccineAPI5.Interfaces.Services;
using VaccineAPI5.Entities;
using System.Collections.Generic;
using VaccineAPI5.Domain.Arguments.Patient;
using System.Linq;
using VaccineAPI5.ValueObjects;

namespace VaccineAPI5.Services
{
    public class ServicePatient : IServicePatient
    {
        private readonly IRepositoryPatient _repositoryPatient;

        public ServicePatient()
        {

        }

        public ServicePatient(IRepositoryPatient repositoryPatient)
        {
            _repositoryPatient = repositoryPatient;
        }

        public AddPatientResponse AddPatient(AddPatientRequest request)
        {
            var email = new Email(request.Email);

            Patient patient = new Patient(request.Name, email, request.Cpf,
                request.Birthdate, request.Comorbidity, request.Address,
                request.District, request.State, request.City);

            //if(this.IsInvalid())
            //{
            //    return null;
            //}
            patient = _repositoryPatient.AddPatient(patient);

            return (AddPatientResponse)patient;
        }

        public PatientResponse GetPatientById(Guid id)
        {
            return (PatientResponse)_repositoryPatient.GetPatientById(id);
        }

        public IEnumerable<PatientResponse> ListPatients()
        {
            return _repositoryPatient
                .ListPatients()
                .ToList()
                .Select(patient => (PatientResponse)patient).ToList();
        }
    }
}
