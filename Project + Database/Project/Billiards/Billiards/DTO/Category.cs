using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class Category
    {
        public Category(int iDCategory, string nameCategory)
        {
            this.IDCategory = iDCategory;
            this.NameCategory = nameCategory;
        }
        public Category(DataRow row)
        {
            this.IDCategory = (int)row["IDCategory"];
            this.NameCategory = row["NameCategory"].ToString();
        }
        private int iDCategory;

        public int IDCategory
        {
            get { return iDCategory; }
            set { iDCategory = value; }
        }

    
        private string nameCategory;

        public string NameCategory
        {
            get { return nameCategory; }
            set { nameCategory = value; }
        }
    }
}
