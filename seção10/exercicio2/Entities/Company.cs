namespace exercicio2.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployeers { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberOfEmployeers)
        : base(name, anualIncome)
        {
            NumberOfEmployeers = numberOfEmployeers;
        }

        public override double Tax()
        {
            if (NumberOfEmployeers <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}