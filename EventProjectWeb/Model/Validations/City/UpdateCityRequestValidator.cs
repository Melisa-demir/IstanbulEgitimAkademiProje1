using EventProjectWeb.DTO.City;
using FluentValidation;

namespace EventProjectWeb.Model.Validations.Artist
{
    public class UpdateCityRequestValidator : AbstractValidator<UpdateCityRequestDTO>
    {
        public UpdateCityRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The Name field cannot be empty.")
                .MinimumLength(10).WithMessage("Name must be at least 10 characters.");
        }
    }
}
