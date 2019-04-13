using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class Table
    {
        public Table(int iDTable, string nameTable, string statusTable)
        {
            this.IDTable = iDTable;
            this.NameTable = nameTable;
            this.StatusTable = statusTable;
        }
        private int iDTable;

        public Table(DataRow row)
        {
            this.IDTable = (int)row["IDTable"];
            this.NameTable = row["NameTable"].ToString();
            this.StatusTable = row["StatusTable"].ToString();
        }
        public int IDTable
        {
            get { return iDTable; }
            set { iDTable = value; }
        }

        
        private string nameTable;

        public string NameTable
        {
            get { return nameTable; }
            set { nameTable = value; }
        }
        private string statusTable;

        public string StatusTable
        {
            get { return statusTable; }
            set { statusTable = value; }
        }
    }
}
