using System;
using VaccineAPI5.Interfaces.Arguments;

namespace VaccineAPI5.Arguments.Vaccine
{
    public class AddVaccineRequest : IRequest
    {
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Batch { get; set; }

        public string DueDate { get; set; }

        public int NumberOfDoses { get; set; }

        public int IntervalBetweenDoses { get; set; }
    }
}
