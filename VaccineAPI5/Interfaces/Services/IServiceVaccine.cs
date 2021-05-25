using System;
using System.Collections.Generic;
using VaccineAPI5.Arguments.Vaccine;
using VaccineAPI5.Domain.Arguments.Vaccine;

namespace VaccineAPI5.Interfaces.Services
{
    public interface IServiceVaccine
    {
        AddVaccineResponse AddVaccine(AddVaccineRequest request);

        IEnumerable<VaccineResponse> ListVaccines();

        VaccineResponse GetVaccineById(Guid id);
    }
}
