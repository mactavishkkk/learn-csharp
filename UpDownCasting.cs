using PrimeiroProjeto.Classes.Account;

namespace PrimeiroProjeto
{
    internal class UpDownCasting
    {
        static void MainOff(string[] args)
        {
            // Account account = new Account();
            BusinessAccount businessAccount = new BusinessAccount();

            // UP

            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1003, "Gabriela", 100, 200);
            /* 
             * account2.Loan(200); Para o compilador, esta variável (account2) é um Account, logo, apesar de ser instânciada como "Business",
            ela só possui as operações de "Account" 
            */
            account2.Withdraw(10.5);
            Account account3 = new SavingsAccount(1003, "Gabriela", 100, 1.0);

            // DOWN

            /* 
             * BusinessAccount businessAccount2 = account2; | Para o compilador, ele só toma como parâmetro 
             * o tipo da variável, que é "Account" 
             */

            // Logo, é necessário este casting para funcionar

            BusinessAccount businessAccount2 = (BusinessAccount)account2;
            businessAccount2.Loan(100.50);

            // Também é necessário o down casting, mas apesar disto, o erro ocorre em tempo de execução
            BusinessAccount businessAccount3 = (BusinessAccount)account3;

            // Tratando excessões acima
            if (account3 is BusinessAccount)
            {
                BusinessAccount businessAccount1 = (BusinessAccount)account3;
                businessAccount1.Loan(157.6);
                Console.WriteLine("Loan!");
            }

            if (account3 is SavingsAccount)
            {
                SavingsAccount savingsAccount = account3 as SavingsAccount;
                savingsAccount.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
