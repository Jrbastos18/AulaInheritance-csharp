using System.Globalization;

namespace Aula142ExFixPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        //Construtores
        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        //Método
        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + $" (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";

        }

    }
}
