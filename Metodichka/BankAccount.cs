using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka
{
    public enum AccountType { Current, Saving, IncorrectInput };
    class BankAccount
    {

        private uint number;
        private decimal balance;
        private AccountType type;
        private static uint genNum = 1;
        public void GetInfo()
        {
            Console.WriteLine($"Номер счета: {number},\nТип счета: {type},\nБаланс счета: {balance}");
        }
        public BankAccount() { number = genNum++;type = AccountType.Current; balance = 0; }
        public BankAccount(decimal sum) { number = genNum++; type = AccountType.Current; balance = sum; }
        public BankAccount(int x, decimal sum) { number = genNum++; type = (AccountType)x; balance = sum; }

        public void SetAccInfo()
        {
            bool flag;
            uint x;
            decimal y;
            Console.WriteLine("Введите баланс:");
            while (flag = !decimal.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Некорректный ввод");
            }
            balance = y;
            Console.WriteLine("Выберите тип счета:\n1.Current;\n2.Saving");
            while (flag = !uint.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Некорректный ввод");
            }
            switch (x)
            {
                case 1:
                    type = AccountType.Current;
                    break;
                case 2:
                    type = AccountType.Saving;
                    break;
                default:
                    type = AccountType.IncorrectInput;
                    break;
            }
        }
        public void Withdraw(decimal take)
        {
            if (balance - take <= 0)
            {
                Console.WriteLine("Снять со счета эту сумму нельзя");
            }
            else
            {
                balance -= take;
            }
        }
        public void AddMoney(decimal add)
        {
            balance += add;
        }
        public void TakeFrom(ref BankAccount account, decimal sum)
        {
            if (sum>account.balance)
            {
                Console.WriteLine("С этого аккаунта нельзя перевести такую сумму");
            }
            else
            {
                account.Withdraw(sum);
                AddMoney(sum);
            }

        }
    }
}
