using PrimeiroProjeto.Classes;

namespace PrimeiroProjeto.Exercises {
    internal class BeginOOP {
        static void Main(string[] args) {
            Person person = new Person();
            Employee employee = new Employee();

            person.nome = "Maria";
            person.idade = 17;

            employee.nome = "Carlos Silva";
            employee.salario = 6300.00;
        }
    }
}
