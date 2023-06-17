using MininuShop.Domain.Validations;

namespace MininuShop.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CodeErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }

        public Product(string name, string codeErp, decimal price)
        {
            Validation(name, codeErp, price);
            Purchases = new List<Purchase>();
        }

        public Product(int id, string name, string codeErp, decimal price)
        {
            DomainValidationException.When(id < 0, "Id do produto deve ser informado");
            Id = id;
            Validation(name, codeErp, price);
            Purchases = new List<Purchase>();
        }

        private void Validation(string name, string codeErp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(codeErp), "Codigo erp deve ser informado");
            DomainValidationException.When(price < 0, "Preço deve ser informado");

            Name = name;
            CodeErp = codeErp;
            Price = price;
        }
    }
}