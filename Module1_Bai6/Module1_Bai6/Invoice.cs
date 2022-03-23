using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai6
{
    public abstract class Invoice
    {
        public string BillCode { get; set; }
        public string BillDate { get; set; }
        public string GuestName { get; set; }
        public string RoomID { get; set; }
        public double Price { get; set; }

        public Invoice(string billCode, string billDate, string guestName, string roomID, double price)
        {
            BillCode = billCode;
            BillDate = billDate;
            GuestName = guestName;
            RoomID = roomID;
            Price = price;
        }

        public Invoice()
        {
        }
        public abstract double Total();
        public virtual void InputInform()
        {
            Console.WriteLine("Input Bill's code");
            BillCode = Console.ReadLine();
            Console.WriteLine("Created Date: ");
            BillDate = Console.ReadLine();
            Console.WriteLine("Name of Guest: ");
            GuestName = Console.ReadLine();
            Console.WriteLine("Room Id: ");
            RoomID = Console.ReadLine();
            Console.WriteLine("Room's Price: ");
            Price = double.Parse(Console.ReadLine());

        }

        public virtual string toString()
        {
            return $"Code: {this.BillCode}, Date: {this.BillDate}, Guest's Name: {this.GuestName}, Room: {this.RoomID}, Price: {this.Price}";
        }
    }
}
