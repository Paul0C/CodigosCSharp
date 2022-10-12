namespace testeC_
{
    public class  Employee
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public double Salario {get; private set;}

        public Employee(int id, string nome, double salario){
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public Employee(){

        }

        public void increaseSalary(double porcentagem){
            Salario = Salario + (Salario * (porcentagem / 100.0));
        } 

        public override string ToString(){
            return "ID:" + Id
            + " Nome:"  + Nome
            + " Salário:" + Salario.ToString("F2");
        }
    }
}