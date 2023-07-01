using MininuShop.Domain.Validations;

namespace MininuShop.Domain.Entities
{
    public sealed class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }

        public Person(string name, string email, string password, string document, string phone)
        {
            Validation(name, email, password, document, phone);
            Purchases = new List<Purchase>();
        }

        public Person(int id, string name, string email, string password, string document, string phone)
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que Zero");
            Id = id;
            Validation(name, email, password, document, phone);
            Purchases = new List<Purchase>();
        }

        private void Validation(string name, string email, string password, string document, string phone)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(email), "Email deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(password), "Senha deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(document), "Documento deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(phone), "Telefone deve ser informado!");

            Name = name;
            Email = email;
            Password = password;
            Document = document;
            Phone = phone;
        }
    }
}