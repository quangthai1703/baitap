using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai6
{
    class InvoiceManagement
    {
        static void Main(string[] arg)
        {
            List<InvoiceFollowedByHour> invoiceFollowedByHours = new List<InvoiceFollowedByHour>();
            List<InvoiceFollowedByDays> invoiceFollowedByDays = new List<InvoiceFollowedByDays>();
            int count;
            int choice;
            double totalbillsbyhours = 0, totalbillsbydays = 0;
            do
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Invoices followed by Hours or 2. Invoices followed by Days");
                        Console.WriteLine("Please choose the number");
                        check:
                        int num = int.Parse(Console.ReadLine());
                        if(num == 1)
                        {
                            Console.WriteLine("Input the number of Invoices followed by Hours: ");
                            int n = int.Parse(Console.ReadLine());
                            for (int i = 0;i < n; i++)
                            {
                                InvoiceFollowedByHour bill = new InvoiceFollowedByHour();
                                Console.WriteLine($"Inform's Guest No.{i + 1}:  ");
                                bill.InputInform();
                                invoiceFollowedByHours.Add(bill);
                            }
                        }
                        else if(num == 2)
                        {
                            Console.WriteLine("Input the number of Invoices followed by Days: ");
                            int n = int.Parse(Console.ReadLine());
                            for (int i = 0; i < n; i++)
                            {
                                InvoiceFollowedByDays bill = new InvoiceFollowedByDays();
                                Console.WriteLine($"Inform's Guest No.{i + 1}:  ");
                                bill.InputInform();
                                invoiceFollowedByDays.Add(bill);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Choose Again!");
                            goto check;
                        }
                        break;
                   case 2:
                        Console.WriteLine("LIST OF INVOICES");
                        for (int i = 0; i < invoiceFollowedByHours.Count; i++)
                        {
                            Console.WriteLine(invoiceFollowedByHours[i].toString());
                        }
                        Console.WriteLine();
                        for (int i = 0; i < invoiceFollowedByDays.Count; i++)
                        {
                            Console.WriteLine(invoiceFollowedByDays[i].toString());
                        }
                        break;
                    case 3:
                        Console.Write("The number of Invoices in the list = ");
                        Console.WriteLine(invoiceFollowedByHours.Count + invoiceFollowedByDays.Count);
                        break;
                    case 4:
                        Console.Write("The number of InvoicesFollowedByHours = ");
                        Console.WriteLine(invoiceFollowedByHours.Count);
                        break;
                    case 5:
                        Console.Write("The number of InvoicesFollowedByDays = ");
                        Console.Write(invoiceFollowedByDays.Count);
                        break;
                    case 6:
                        Console.Write("Total of all bills in the list = ");
                        for (int i = 0; i < invoiceFollowedByHours.Count; i++)
                        {
                            totalbillsbyhours += invoiceFollowedByHours[i].Total();
                        }
                        for (int i = 0; i < invoiceFollowedByDays.Count; i++)
                        {
                            totalbillsbydays += invoiceFollowedByDays[i].Total();
                        }
                        Console.WriteLine(totalbillsbydays + totalbillsbyhours);
                        break;
                    default:
                        Console.WriteLine("Choose Again!!!");
                        break;
                }               
            }
            while (choice != 0);

            static void ShowMenu()
            {
                Console.WriteLine("1.\t Create A List of Invoices");
                Console.WriteLine("2.\t Display the List");
                Console.WriteLine("3.\t Display the number of Invoices in the list");
                Console.WriteLine("4.\t Display the number of InvoicesFollowedByHours");
                Console.WriteLine("5.\t Display the number of InvoicesFollowedByDays");
                Console.WriteLine("6.\t Total of All Bills");
                Console.WriteLine("0.\t Exit");
                Console.WriteLine("Please choose the number");
            }
        }
    }
}
