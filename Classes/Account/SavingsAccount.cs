using PrimeiroProjeto.Classes.Exceptions;
using PrimeiroProjeto.Classes.Order;

namespace PrimeiroProjeto.Classes.Account
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Saldo suficiente!");
            }

            Balance -= amount;
        }
    }
}
