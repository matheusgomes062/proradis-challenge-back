using System;
using System.Collections.Generic;
using VaccineAPI5.Entities;

namespace VaccineAPI5.Domain.Interfaces.Repositories
{
    public interface IRepositoryPatient
    {
        Patient AddPatient(Patient patient);

        IEnumerable<Patient> ListPatients();

        Patient GetPatientById(Guid id);
    }
}
