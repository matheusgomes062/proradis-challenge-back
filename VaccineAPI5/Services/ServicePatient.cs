using System;
using VaccineAPI5.Arguments.Patient;
using VaccineAPI5.Domain.Interfaces.Repositories;
using VaccineAPI5.Interfaces.Services;
using VaccineAPI5.Entities;
using VaccineAPI5.ValueObjects;
using System.Collections.Generic;
using VaccineAPI5.Domain.Arguments.Patient;
using System.Linq;

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
            Patient patient = new(request.Name, request.Email, request.Cpf, request.Birthdate, request.Comorbidity, request.Address, request.District, request.State, request.City);

            //if(this.IsInvalid())
            //{
            //    return null;
            //}
            patient = _repositoryPatient.AddPatient(patient);

            return (AddPatientResponse)patient;
        }

        public IEnumerable<PatientResponse> ListPatients()
        {
            return _repositoryPatient.ListPatients().ToList().Select(patient => (PatientResponse)patient).ToList();
        }
    }
}
