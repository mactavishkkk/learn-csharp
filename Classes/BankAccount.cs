using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    class BankAccount {
        private int _numeroConta;
        private string _nomeTitular;
        private double _saldo;

        public BankAccount(int numeroConta, string nomeTitular, double saldo) {
            _numeroConta = numeroConta;
            _nomeTitular = nomeTitular;
            _saldo = saldo;
        }

        public BankAccount(int numeroConta, string nomeTitular) {
            _numeroConta = numeroConta;
            _nomeTitular = nomeTitular;
            _saldo = 0;
        }

        public string NomeTitular {
            get { return _nomeTitular; }
            set { _nomeTitular = value; }
        }

        public void Deposito(double valor) {
            _saldo += valor;
        }

        public void Saque(double valor) {
            _saldo -= valor;
            _saldo -= 5.00;
        }

        public override string ToString() {
            return "\nDados da conta: \nConta - " + _numeroConta +
                ", Titular: " + _nomeTitular + ", Saldo: $ " + _saldo.ToString("F2") + "\n";
        }
    }

}
