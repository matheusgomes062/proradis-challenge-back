using System;
using System.Collections.Generic;
using VaccineAPI5.Entities;

namespace VaccineAPI5.Domain.Interfaces.Repositories
{
    public interface IRepositoryVaccine
    {
        Vaccine AddVaccine(Vaccine vaccine);

        IEnumerable<Vaccine> ListVaccines();

        Vaccine GetVaccineById(Guid id);
    }
}
