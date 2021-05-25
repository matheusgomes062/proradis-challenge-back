using System;
using VaccineAPI5.Arguments.Vaccine;
using VaccineAPI5.Entities;

namespace VaccineAPI5.Domain.Interfaces.Repositories
{
    public interface IRepositoryVaccine
    {
        Vaccine AddVaccine(Vaccine vaccine);
    }
}
