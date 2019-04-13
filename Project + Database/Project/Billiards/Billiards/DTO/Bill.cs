using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class Bill
    {
        public Bill(int iDBill,DateTime? dateCheckIn, DateTime? DateCheckOut, int hour, int minute, int statusBill, int discount, float totalPrice, int iDTable)
        {
            this.IDBill = iDBill;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Hour = hour;
            this.Minute = minute;
            this.StatusBill = statusBill;
            this.Discount = discount;
            this.TotalPrice = totalPrice;
            this.IDtable = IDtable;
        }
        public Bill(DataRow row)
        {
            this.IDBill = (int)row["IDBill"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            var dateCheckOutTemp = row["DateCheckOut"];
            if (dateCheckOutTemp.ToString() != "") // 10
            {
                this.DateCheckOut = (DateTime?)row["DateCheckOut"];
            }
            this.Hour = (int)row["Hour"];
            this.Minute = (int)row["Minute"];
            this.StatusBill = (int)row["StatusBill"];
            if (row["Discount"].ToString() != "")
                this.Discount = (int)row["Discount"];
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
            this.IDtable = (int)row["IDTable"];
        }
        private int iDBill;

        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }
        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }


        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
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
        private int statusBill;

        public int StatusBill
        {
            get { return statusBill; }
            set { statusBill = value; }
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
        private int iDtable;

        public int IDtable
        {
            get { return iDtable; }
            set { iDtable = value; }
        }
    }
}
