using System;
namespace VaccineAPI5.Entities
{
    public class DoseControl
    {
        public Guid Id { get; set; }

        public Patient Patient { get; set; }

        public Vaccine Vaccine { get; set; }

        public string ApplicationDate { get; set; }

        public int DoseTaken { get; set; }
    }
}
