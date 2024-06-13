using EventProjectWeb.DTO.Ticket;
using FluentValidation;

namespace EventProjectWeb.Model.Validations.Ticket
{
    public class CreateTicketRequestValidator: AbstractValidator<CreateTicketRequestDto>
    {
        public CreateTicketRequestValidator()
        {
                
        }
    }
}
