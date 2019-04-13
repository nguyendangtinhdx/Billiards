using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class Debt
    {
        public Debt(int iDDebt, string nameDebt, float money, string statusDebt, int iDBill)
        {
            this.IDDebt = iDDebt;
            this.NameDebt = nameDebt;
            this.Money = money;
            this.StatusDebt = statusDebt;
            this.IDBill = iDBill;
        }
        public Debt(DataRow row)
        {
            this.IDDebt = (int)row["IDDebt"];
            this.NameDebt = row["NameDebt"].ToString();
            this.Money = (float)Convert.ToDouble(row["Money"].ToString());
            this.StatusDebt = row["StatusDebt"].ToString();
            this.IDBill = (int)row["IDBill"];
        }
        private int iDDebt;

        public int IDDebt
        {
            get { return iDDebt; }
            set { iDDebt = value; }
        }
        private string nameDebt;

        public string NameDebt
        {
            get { return nameDebt; }
            set { nameDebt = value; }
        }
        private float money;

        public float Money
        {
            get { return money; }
            set { money = value; }
        }
        private string statusDebt;

        public string StatusDebt
        {
            get { return statusDebt; }
            set { statusDebt = value; }
        }
        private int iDBill;

        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }
    }
}
