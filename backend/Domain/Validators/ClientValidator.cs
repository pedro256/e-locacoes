using FluentValidation;
using Domain.Entity;

namespace Domain.Validators
{
    public class ClientValidator : AbstractValidator<Client>{
        public ClientValidator()
        {
            RuleFor(x=>x)
            .NotEmpty()
            .WithMessage("Entity is not empty.")
            .NotNull()
            .WithMessage("Entity is not null.");

            RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is not empty.")

            .NotNull()
            .WithMessage("Name is not null.")
            
            .MinimumLength(3)
            .WithMessage("Name length should be > 3")
            
            .MaximumLength(100)
            .WithMessage("Name length should be < 100");

            RuleFor(x => x.Cpf)
            .NotEmpty()
            .WithMessage("Cpf is not empty.")
            
            .NotNull()
            .WithMessage("Cpf is not null.")
            
            .MinimumLength(3)
            .WithMessage("Cpf length should be > 3")
            
            .MaximumLength(100)
            .WithMessage("Cpf length should be < 100");

            RuleFor(x => x.BirthDate)
            .NotEmpty()
            .WithMessage("BirthDate is not empty.")

            .NotNull()
            .WithMessage("BirthDate is not null.");


        }
    }
}