using MininuShop.Domain.Entities;

namespace MininuShop.Domain;

public interface IPersonRepository
{
  Task<Person> GetByIdAsync(int id);
  Task<ICollection<Person>> GetPeopleAsync();
  Task<Person> CreateAsync(Person person);
  Task EditAsync(Person person);
}
