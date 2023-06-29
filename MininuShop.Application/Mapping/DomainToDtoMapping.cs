using AutoMapper;
using MininuShop.Domain.Entities;

namespace MininuShop.Application;

public class DomainToDtoMapping : Profile
{ 
  public DomainToDtoMapping()
  {
    CreateMap<Person ,PersonDTO>();
  }

}
