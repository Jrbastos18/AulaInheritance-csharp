using System.Globalization;

namespace Aula142ExFixPolimorfismo.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        //Cosntrutores
        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //Métodos
        public virtual string PriceTag()
        {
            return Name 
                + " $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
