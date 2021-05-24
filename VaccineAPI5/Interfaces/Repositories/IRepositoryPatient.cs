using System;
using VaccineAPI5.Arguments.Patient;

namespace VaccineAPI5.Domain.Interfaces.Repositories
{
    public interface IRepositoryPatient
    {
        Guid AddPatient(AddPatientRequest request);
    }
}
