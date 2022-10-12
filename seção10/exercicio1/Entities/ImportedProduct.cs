namespace exercicio1.Entities
{
    public class ImportedProduct : Product
    {
        public double CustonsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double custonsFee) : base(name, price)
        {
            CustonsFee = custonsFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + "(Custons Fee: $ " + CustonsFee.ToString("F2") + ")";
        }
    }
}