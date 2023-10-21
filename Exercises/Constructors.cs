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

            int numberAccount;
            string titularName;
            double value;
            string initialDeposit;

            Console.Write("Entre com o número da conta: "); numberAccount = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: "); titularName = Console.ReadLine();
            Console.Write("Deseja fazer um depósito inicial? (S/N) "); initialDeposit = Console.ReadLine();
            

            if (initialDeposit == "S") {
                Console.Write("Entre com o value do depósito: "); value = double.Parse(Console.ReadLine());
                account = new BankAccount(numberAccount, titularName, value);
                Console.WriteLine(account);
            } else {
                account = new BankAccount(numberAccount, titularName);
                Console.WriteLine(account);
            }

            Console.Write("Entre com um value para depósito: "); value = double.Parse(Console.ReadLine());
            account.Deposit(value);
            Console.WriteLine(account);

            Console.Write("Entre com um value para saque: "); value = double.Parse(Console.ReadLine());
            account.WithDraw(value);
            Console.WriteLine(account);
        }
    }
}
