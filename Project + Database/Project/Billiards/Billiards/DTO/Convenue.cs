using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class Convenue
    {
        public Convenue(string nameTable2, DateTime dateCheckIn, DateTime dateCheckOut,int hour, int minute, int discount, float totalPrice)
        {
            this.NameTable2 = nameTable2;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckIn;
            this.Hour = hour;
            this.Minute = minute;
            this.Discount = discount;
            this.TotalPrice = totalPrice;

        }
        public Convenue(DataRow row)
        {
            this.NameTable2 = row["NameTable"].ToString();
            this.DateCheckIn = (DateTime)row["DateCheckIn"];
            var dateCheckOutTemp = row["DateCheckOut"];
            if (dateCheckOutTemp.ToString() != "") // 10
            {
                this.DateCheckOut = (DateTime)row["DateCheckOut"];
            }
            this.Hour = (int)row["Hour"];
            this.Minute = (int)row["Minute"];
            if (row["Discount"].ToString() != "")
                this.Discount = (int)row["Discount"];
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
        }
        private string nameTable2;

        public string NameTable2
        {
            get { return nameTable2; }
            set { nameTable2 = value; }
        }
        private DateTime dateCheckIn;

        public DateTime DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }


        private DateTime dateCheckOut;

        public DateTime DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

      
        private int hour;

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        private int minute;

        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
