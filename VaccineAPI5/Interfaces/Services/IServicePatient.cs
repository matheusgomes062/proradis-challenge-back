using System.Collections.Generic;
using VaccineAPI5.Arguments.Patient;
using VaccineAPI5.Domain.Arguments.Patient;

namespace VaccineAPI5.Interfaces.Services
{
    public interface IServicePatient
    {
        AddPatientResponse AddPatient(AddPatientRequest request);
    }

    IEnumerable<PatientResponse> ListPatients();
}
 