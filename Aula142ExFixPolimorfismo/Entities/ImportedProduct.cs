using System.Globalization;

namespace Aula142ExFixPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        //Construtores
        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)//Construtor sobreposto a partir da superclasse Product
        {
            CustomsFee = customsFee;
        }

        //Método herdado da superclasse
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

    }
}
