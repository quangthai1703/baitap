using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class CD
    {
       private int _cdnumber;
       public int Cdnumber
        {
            get { return _cdnumber; }
            set
            {
                if(value > 0) { this._cdnumber = value; }
                else { this._cdnumber = 999999; }
            }
        }
        private string _cdname;
       public string Cdname
        {
            get { return _cdname; }
            set
            {
                if (value.Equals("")) { this._cdname = "chua xac dinh"; }
                else { this._cdname = value; }
            }
        }
        private int _songnumber;
       public int SongNumber
        {
            get { return _songnumber; }
            set
            {
                if(value <= 0) { Console.WriteLine("So bai hat phai > 0"); }
                else { this._songnumber = value; }
            }
        }
        private float _price;
       public float Price
        {
            get { return _price; }
            set
            {
                if( value <= 0) { Console.WriteLine("Gia thanh phai > 0"); }
                else { this._price = value; }
            }
        }

        public CD()
        {
        }

        public CD(int cdnumber, string cdname, int songNumber, int price)
        {
            Cdnumber = cdnumber;
            Cdname = cdname;
            SongNumber = songNumber;
            Price = price;
        }
        public void Input()
        {
            Console.WriteLine("Ma CD: ");
            Cdnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Ten CD: ");
            Cdname = Console.ReadLine();
            Console.WriteLine("So luong bai hat: ");
            SongNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Gia ban: ");
            Price = float.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine(string.Format("{0,-10} {1,-20} {2,-20} {3,-20}",Cdnumber,Cdname,SongNumber,Price));
        }
       

    }
}
