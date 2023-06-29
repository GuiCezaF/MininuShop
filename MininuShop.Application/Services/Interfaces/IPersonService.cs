namespace MininuShop.Application;

public interface IPersonService
{
  Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO);
}
