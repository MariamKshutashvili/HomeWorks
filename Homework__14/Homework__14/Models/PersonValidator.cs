using FluentValidation;
using System;

namespace Homework__14.Models
{
    public class PersonValidator:AbstractValidator <Person>
    {
        public PersonValidator() {
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Name cannot be empty")
                    .Length(0,50).WithMessage("First name length is wrong");

            RuleFor(x => x.Lastname).NotEmpty().WithMessage("Name cannot be empty")
                    .Length(0, 50).WithMessage("Last name length is wrong");

            RuleFor(x => x.JobPosition).NotEmpty().WithMessage("Position cannot be empty")
                    .Length(0, 50).WithMessage("length is wrong");


            RuleFor(x => x.Salary).GreaterThanOrEqualTo(0).LessThanOrEqualTo(10000)
                .WithMessage("Salary amount is incorrect");

            RuleFor(x => x.CreateDate).LessThanOrEqualTo(DateTime.Now)
                .WithMessage("It cannot be the future");

            RuleFor(x => x.WorkExperince).NotEmpty()
                .WithMessage("Work experience is obligatory");
                    






        }
    }
}
