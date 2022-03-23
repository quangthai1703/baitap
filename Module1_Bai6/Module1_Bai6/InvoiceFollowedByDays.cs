using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai6
{
    public class InvoiceFollowedByDays:Invoice
    {
        public int RentailDays { get; set; }

        public InvoiceFollowedByDays()
        {
        }

        public InvoiceFollowedByDays(string billCode, string billDate, string guestName, string roomID, double price, int rentailDays) : base(billCode, billDate, guestName, roomID, price)
        {
            RentailDays = rentailDays;
        }

        public override void InputInform()
        {
            base.InputInform();
            Console.WriteLine("Input Rentail Days: ");
            RentailDays = int.Parse(Console.ReadLine());
        }

        public override double Total()
        {
            if (RentailDays <= 7) return RentailDays * Price;
            else if (RentailDays == 0) throw new Exception("This bill must be calculated by hours");
            else return (7 * Price)+((RentailDays-7)*20/100);
        }

        public override string toString()
        {
            return base.toString() + " , Rentail Days: " + this.RentailDays;
        }
    }
}
