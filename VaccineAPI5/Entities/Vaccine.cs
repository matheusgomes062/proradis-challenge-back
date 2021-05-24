using System;
namespace VaccineAPI5.Models
{
    public class Vaccine
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Batch { get; set; }

        public DateTime DueDate { get; set; }

        public int NumberOfDoses { get; set; }

        public int IntervalBetweenDoses { get; set; }
    }
}
