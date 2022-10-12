namespace testeC_
{
    public class ContaBancaria
    {
        private int NumeroConta {get;}
        public string Nome {get; set;}
        public double Saldo;

        public ContaBancaria(int numeroConta, string nome, double saldo){
                NumeroConta = numeroConta;
                Nome = nome;
                Saldo = saldo;
        }

        public ContaBancaria(int numeroConta, string nome){
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public void deposito(double valor){
            Saldo += valor;
        }

        public void saque(double valor){
            Saldo = Saldo - valor - 5.00;
        }

        public override string ToString(){
            return "Número da conta: " + NumeroConta
            + " Nome: " + Nome 
            + " Saldo:" + Saldo.ToString("F2");
        }
    }
}