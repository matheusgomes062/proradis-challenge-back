using System;
using System.Collections.Generic;
using VaccineAPI5.Arguments.Patient;
using VaccineAPI5.Domain.Arguments.Patient;
using VaccineAPI5.Entities;

namespace VaccineAPI5.Domain.Interfaces.Repositories
{
    public interface IRepositoryPatient
    {
        Patient AddPatient(Patient patient);

        IEnumerable<PatientResponse> ListPatients();
    }
}
