using AutoMapper;
using MininuShop.Domain.Entities;

namespace MininuShop.Application;

public class DtoToDomainMapping : Profile
{
  public DtoToDomainMapping()
  { 
    CreateMap<PersonDTO, Person>();
    
  }
}
