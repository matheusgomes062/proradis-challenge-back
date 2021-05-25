using System;
using VaccineAPI5.Interfaces.Arguments;

namespace VaccineAPI5.Arguments.Vaccine
{
    public class AddVaccineResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }

        public static explicit operator AddVaccineResponse(Entities.Vaccine entity)
        {
            return new AddVaccineResponse()
            {
                Id = entity.Id,
                Message = "Operação realizada com sucesso!"
            };
        }
    }
}
