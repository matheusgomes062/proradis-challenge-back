using System;
using System.Collections.Generic;
using System.Linq;
using VaccineAPI5.Arguments.Vaccine;
using VaccineAPI5.Domain.Arguments.Vaccine;
using VaccineAPI5.Domain.Interfaces.Repositories;
using VaccineAPI5.Entities;
using VaccineAPI5.Interfaces.Services;

namespace VaccineAPI5.Services
{
    public class ServiceVaccine : IServiceVaccine
    {
        private readonly IRepositoryVaccine _repositoryVaccine;

        public ServiceVaccine(IRepositoryVaccine repositoryVaccine)
        {
            _repositoryVaccine = repositoryVaccine;
        }

        public AddVaccineResponse AddVaccine(AddVaccineRequest request)
        {
            Vaccine vaccine = new Vaccine(request.Name, request.Manufacturer, request.Batch, request.DueDate, request.NumberOfDoses, request.IntervalBetweenDoses);

            //if(this.IsInvalid())
            //{
            //    return null;
            //}
            vaccine = _repositoryVaccine.AddVaccine(vaccine);

            return (AddVaccineResponse)vaccine;
        }

        public VaccineResponse GetVaccineById(Guid id)
        {
            return (VaccineResponse)_repositoryVaccine.GetVaccineById(id);
        }

        public IEnumerable<VaccineResponse> ListVaccines()
        {
            return _repositoryVaccine.ListVaccines().ToList().Select(vaccine => (VaccineResponse)vaccine).ToList();
        }
    }
}
