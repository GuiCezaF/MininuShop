using FluentValidation;

namespace MininuShop.Application;

public class PersonDTOValidator : AbstractValidator<PersonDTO>
{
  public PersonDTOValidator()
  {

    RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("O nome deve ser Informado");
    RuleFor(x => x.Document).NotEmpty().NotNull().WithMessage("O Documento deve ser Informado");
    RuleFor(x => x.Phone).NotEmpty().NotNull().WithMessage("O telefone deve ser Informado");
    RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage("A senha deve ser Informado");
    RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage("O Email deve ser Informado");

  }
}
