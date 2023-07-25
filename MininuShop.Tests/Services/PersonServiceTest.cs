using AutoMapper;
using MininuShop.Application;
using MininuShop.Domain;
using Moq;

namespace MininuShop.Tests.Services
{
    public class PersonServiceTest
    {
        private PersonService _personService;
        private IMapper _mapper;
        private Mock<IPersonRepository> _personRepository;

        public PersonServiceTest()
        {
            _personService = new PersonService(new Mock<IPersonRepository>().Object, new Mock<IMapper>().Object);
        }

        [Fact]
        public void CreatePerson()
        {
            var person = new PersonDTO
            {
                Id = 1,
                Name = "Gui",
                Email = "teste@teste.com",
                Password = "123456",
                Document = "12345678789",
                Phone = "12345676890"
            };

            var result = _personService.CreateAsync(person);

            Assert.NotNull(result.Result.Data);
        }
    }
} 