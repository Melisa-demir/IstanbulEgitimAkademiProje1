using EventProjectWeb.DTO.Artist;
using FluentValidation;

namespace EventProjectWeb.Model.Validations.Artist
{
    public class UpdateArtistRequestValidator : AbstractValidator<UpdateArtistRequestDTO>
    {
        public UpdateArtistRequestValidator()
        {
            RuleFor(x => x.ArtistName)
                .NotEmpty().WithMessage("The ArtistName field cannot be empty.")
                .MinimumLength(10).WithMessage("Artist name must consist of at least 10 characters.");
        }
    }
}
