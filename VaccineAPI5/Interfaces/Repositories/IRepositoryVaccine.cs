using System;
using VaccineAPI5.Arguments.Vaccine;

namespace VaccineAPI5.Domain.Interfaces.Repositories
{
    public interface IRepositoryVaccine
    {
        Guid AddVaccine(AddVaccineRequest request);
    }
}
