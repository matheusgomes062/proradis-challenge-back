using System;
using VaccineAPI5.Interfaces.Arguments;

namespace VaccineAPI5.Arguments.Vaccine
{
    public class AddVaccineResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
