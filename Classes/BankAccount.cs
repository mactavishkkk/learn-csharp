using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    class BankAccount {
        private int _numberAccount;
        private string _titularName;
        private double _balance;

        public BankAccount(int numberAccount, string titularName) {
            _numberAccount = numberAccount;
            _titularName = titularName;
            _balance = 0;
        }

        public BankAccount(int numberAccount, string titularName, double initialDeposit) : this(numberAccount, titularName) {
            Deposit(initialDeposit);
        }

        public string titularName {
            get { return _titularName; }
            set { _titularName = value; }
        }

        public void Deposit(double value) {
            _balance += value;
        }

        public void WithDraw(double value) {
            _balance -= value;
            _balance -= 5.00;
        }

        public override string ToString() {
            return "\nDados da conta: \nConta - " + _numberAccount +
                ", Titular: " + _titularName + ", Saldo: $ " + _balance.ToString("F2") + "\n";
        }
    }

}
