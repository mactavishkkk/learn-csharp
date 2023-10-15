using PrimeiroProjeto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercises {
    class Constructors {
        static void Main(string[] args) {
            BankAccount account;

            int numeroConta;
            string nomeTitular;
            double valor;
            string depositoInicial;

            Console.Write("Entre com o número da conta: "); numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: "); nomeTitular = Console.ReadLine();
            Console.Write("Deseja fazer um depósito inicial? (S/N) "); depositoInicial = Console.ReadLine();
            

            if (depositoInicial == "S") {
                Console.Write("Entre com o valor do depósito: "); valor = double.Parse(Console.ReadLine());
                account = new BankAccount(numeroConta, nomeTitular, valor);
                Console.WriteLine(account);
            } else {
                account = new BankAccount(numeroConta, nomeTitular);
                Console.WriteLine(account);
            }

            Console.Write("Entre com um valor para depósito: "); valor = double.Parse(Console.ReadLine());
            account.Deposito(valor);
            Console.WriteLine(account);

            Console.Write("Entre com um valor para saque: "); valor = double.Parse(Console.ReadLine());
            account.Saque(valor);
            Console.WriteLine(account);
        }
    }
}
