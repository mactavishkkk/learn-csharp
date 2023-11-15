using PrimeiroProjeto.Classes.Exceptions;

namespace PrimeiroProjeto.Classes.Account
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            if (loanLimit < 0)
            {
                throw new DomainException("Seu limite não pode ser negativo!");
            }

            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                throw new DomainException("Você não pode emprestar mais do que seu limite: $" + LoanLimit);
            }

            Balance += amount;
        }
    }
}
