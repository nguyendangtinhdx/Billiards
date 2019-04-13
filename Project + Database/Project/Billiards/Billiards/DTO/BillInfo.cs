using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class BillInfo
    {
        public BillInfo(int iDBillInfo, int iDBill, int iDFood, int count)
        {
            this.IDBillInfo = iDBillInfo;
            this.IDBill = iDBill;
            this.IDFood = iDFood;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.IDBillInfo = (int)row["IDBillInfo"];
            this.IDBill = (int)row["IDBill"];
            this.IDFood = (int)row["IDFood"];
            this.Count = (int)row["Count"];
        }
        private int iDBillInfo;

        public int IDBillInfo
        {
            get { return iDBillInfo; }
            set { iDBillInfo = value; }
        }
        private int iDBill;

        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }
        private int iDFood;

        public int IDFood
        {
            get { return iDFood; }
            set { iDFood = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
