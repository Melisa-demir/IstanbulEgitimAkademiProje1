using EventProjectWeb.DTO.Venue;
using FluentValidation;

namespace EventProjectWeb.Model.Validations.Venue
{
    public class CreateVenueRequestValidator: AbstractValidator<CreateVenueRequestDto>
    {
        public CreateVenueRequestValidator()
        {
                
        }
    }
}
