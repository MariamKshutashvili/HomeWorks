using FluentValidation;
namespace Homework__14.Models
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public AddressValidator() {
            
         RuleFor(x => x.Country).NotEmpty()
                .WithMessage("You must choose a country");

         RuleFor(x => x.City).NotEmpty()
                .WithMessage("You must write a city");

         RuleFor(x => x.HomeNumber).NotEmpty()
                .WithMessage("You must write your home number");

        }

    }
}
