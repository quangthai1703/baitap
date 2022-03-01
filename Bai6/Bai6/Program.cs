using System;

namespace Bai6

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Ted Murphy", 72354,102.56);
            Account acc2 = new Account("Jane Smith", 69713, 40.00);
            Account acc3 = new Account("Edward Demsey", 93757, 75932);
            acc1.deposit(25.85);
            acc2.deposit(500.00);
            acc2.withdraw(430.75, 1.50);
            acc3.addInterest();
            Console.WriteLine("acc1 = {0}",acc1.toString());
            Console.WriteLine("acc2 = {0}",acc2.toString());
            Console.WriteLine("acc3 = {0}",acc3.toString());
            Console.WriteLine("Sau khi acc2 chuyen 100.00 cho acc1: ");
            acc2.transfer(acc1, 100.00);
            

        }
    }
}