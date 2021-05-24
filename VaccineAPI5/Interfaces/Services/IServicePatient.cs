using System;
using VaccineAPI5.Arguments.Patient;
using VaccineAPI5.ValueObjects;

namespace VaccineAPI5.Interfaces.Services
{
    public interface IServicePatient
    {
        AddPatientResponse AddPatient(AddPatientRequest request);
    }
}
 