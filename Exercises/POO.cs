using PrimeiroProjeto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercises {
    internal class POO {
        static void Main(string[] args) {
            //Rectangle rectangle = new Rectangle();

            //Console.WriteLine("Digite a largura e depois a altura de um retângulo: ");
            //rectangle.largura = double.Parse(Console.ReadLine());
            //rectangle.altura = double.Parse(Console.ReadLine());

            //Console.WriteLine("AREA = " + rectangle.Area());
            //Console.WriteLine("PERIMETRO = " + rectangle.Perimetro());
            //Console.WriteLine("DIAGONAL = " + rectangle.Diagonal());

            //Employee employee = new Employee();

            //Console.Write("Digite o nome: "); employee.nome = Console.ReadLine();
            //Console.Write("Digite o salário bruto: "); employee.salario = double.Parse(Console.ReadLine());
            //Console.Write("Digite o imposto: "); employee.imposto = double.Parse(Console.ReadLine());

            //Console.WriteLine(employee);

            //Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            //employee.AumentarSalario(double.Parse(Console.ReadLine()));

            //Console.WriteLine(employee);

            Student student = new Student();

            Console.Write("Digite o nome do aluno: "); student.nome = Console.ReadLine();
            Console.Write("Digite a nota do primeiro trimestre: "); student.notaUm = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do segundo trimestre: "); student.notaDois = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do terceiro trimestre: "); student.notaTres = double.Parse(Console.ReadLine());

            Console.WriteLine(student);
        }
    }
}
