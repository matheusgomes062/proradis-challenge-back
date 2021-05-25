using System;
using VaccineAPI5.Interfaces.Arguments;

namespace VaccineAPI5.Arguments.Patient
{
    public class AddPatientResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }

        public static explicit operator AddPatientResponse(Entities.Patient entity)
        {
            return new AddPatientResponse()
            {
                Id = entity.Id,
                Message = "Operação realizada com sucesso!"
            };
        }
    }
}
