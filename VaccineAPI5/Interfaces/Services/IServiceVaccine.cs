using System;
using VaccineAPI5.Arguments.Vaccine;

namespace VaccineAPI5.Interfaces.Services
{
    public interface IServiceVaccine
    {
        AddVaccineResponse AddVaccine(AddVaccineRequest request);
    }
}
