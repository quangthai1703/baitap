using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai6
{
    public class InvoiceFollowedByHour:Invoice
    {
        public int RentailHours { get; set; }

        public InvoiceFollowedByHour():base()
        {
        }

        public InvoiceFollowedByHour(string billCode, string billDate, string guestName, string roomID, double price, int rentailHours) : base(billCode, billDate, guestName, roomID, price)
        {
            RentailHours = rentailHours;
        }

        public override void InputInform()
        {
            base.InputInform();
            Console.WriteLine("Input Rentail Hours: ");
            RentailHours = int.Parse(Console.ReadLine());
        }

        public override double Total()
        {
            if (RentailHours <= 24) return RentailHours * Price;
            else if (RentailHours <= 30) return 24 * Price;
            else throw new Exception("This bill must be calculated by days");
        }

        public override string toString()
        {
            return base.toString() + " , Rentail Hours: " + this.RentailHours;
        }
    }
}
