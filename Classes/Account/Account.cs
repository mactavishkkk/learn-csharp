using PrimeiroProjeto.Classes.Exceptions;

namespace PrimeiroProjeto.Classes.Account
{
    internal abstract class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            if (balance <= 0)
            {
                throw new DomainException("Seu saldo inicial não pode ser <= á 0!");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount + 5.0 > Balance)
            {
                throw new DomainException("Saldo suficiente!");
            }

            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("Você não pode depositar um valor <= á 0!");
            }

            Balance += amount;
        }
    }
}
