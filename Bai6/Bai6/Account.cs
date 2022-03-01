using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Account
    {
        long accountNumber;
        string name;
        double balance;
        double RATE = 0.035;
        public void setname(string name) { this.name = name; }
        public void setbalance(double balance) { this.balance = balance; }
        public Account()
        {
            if(accountNumber <= 0 || name.Equals("") || balance < 50000)
            {
                accountNumber = 999999;
                name = "Chua xac dinh";
                balance = 50000;
            }
        }

        public Account(string name, long accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.balance = balance;
        }

        public Account(long accountNumber, string name)
        {
            this.accountNumber = accountNumber;
            this.name = name;
        }
        public string getname() { return name; }
        public long getAccountNumber() { return accountNumber; }
        public double getBalance() { return balance; }
        public double deposit(double amount)
        {
            return this.balance = this.balance + amount;
        }
        public double withdraw(double amount, double fee)
        {
            return balance = balance - amount - fee;
        }
        public void addInterest()
        {
            balance = balance + balance * RATE;
        }
        public void transfer(Account acc2, double amount)
        {
            setbalance(balance + amount);
            acc2.setbalance(this.balance - amount);
            Console.WriteLine(toString());
            Console.WriteLine(acc2.toString());
        }
        public String toString()
        {
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.CurrencySymbol = "VND";
            culture.NumberFormat.CurrencyPositivePattern = 2;

            return string.Format(culture,"{0} = {1:C2}", getname(), getBalance());
        }
    }
}
