using System;
namespace VaccineAPI5.Models
{
    public class DoseControl
    {
        public Guid Id { get; set; }

        public Patient Patient { get; set; }

        public Vaccine Vaccine { get; set; }

        public DateTime ApplicationDate { get; set; }

        public int DoseTaken { get; set; }
    }
}
