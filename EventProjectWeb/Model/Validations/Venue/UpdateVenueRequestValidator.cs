using EventProjectWeb.DTO.Venue;
using FluentValidation;

namespace EventProjectWeb.Model.Validations.Venue
{
    public class UpdateVenueRequestValidator: AbstractValidator<UpdateVenueRequestDto>
    {
        public UpdateVenueRequestValidator()
        {
                
        }
    }
}
