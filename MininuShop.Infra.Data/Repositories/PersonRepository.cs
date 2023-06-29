using Microsoft.EntityFrameworkCore;
using MininuShop.Domain;
using MininuShop.Domain.Entities;
using MininuShop.Infra.Data.Context;

namespace MininuShop.Infra.Data;

public class PersonRepository : IPersonRepository
{
  private readonly ApplicationDbContext _db;

  public PersonRepository(ApplicationDbContext db)
  {
    _db = db;
  }

  public async Task<Person> CreateAsync(Person person)
  {
    _db.Add(person);
    await _db.SaveChangesAsync();
    return person;
  }

  public async Task EditAsync(Person person)
  {
    _db.Update(person);
    await _db.SaveChangesAsync();

  }

  public async Task<Person> GetByIdAsync(int id)
  {
    return await _db.People.FirstOrDefaultAsync(x => x.Id == id);
  }

  public async Task<ICollection<Person>> GetPeopleAsync()
  {
    return await _db.People.ToListAsync();
  }
}
