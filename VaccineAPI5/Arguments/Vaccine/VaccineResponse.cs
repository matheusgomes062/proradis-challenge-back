using System;
namespace VaccineAPI5.Domain.Arguments.Vaccine
{
    public class VaccineResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Batch { get; set; }

        public string DueDate { get; set; }

        public int NumberOfDoses { get; set; }

        public int IntervalBetweenDoses { get; set; }

        public static explicit operator VaccineResponse(Entities.Vaccine entity)
        {
            return new VaccineResponse()
            {
                Id = entity.Id,
                Name = entity.Name,
                Manufacturer = entity.Manufacturer,
                Batch = entity.Batch,
                DueDate = entity.DueDate,
                NumberOfDoses = entity.NumberOfDoses,
                IntervalBetweenDoses = entity.IntervalBetweenDoses,
            };
        }
    }
}
