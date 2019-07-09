using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExcecao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new Domain("Maior que o limite permitido");
            }
            if(amount > Balance)
            {
                throw new Domain("Saque maior que o Saldo permitido");
            }
            if(amount < WithdrawLimit && amount > Balance)
            {
                throw new Domain("Saque maior que o Saldo permitido");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New Balance $ " + Balance; 
        }


    }
}
