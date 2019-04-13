using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class Food
    {
        public Food(int iDFood, string nameFood, float price, int iDFoodCategory)
        {
            this.IDFood = iDFood;
            this.NameFood = nameFood;
            this.Unit = unit;
            this.Price = price;
            this.IDFoodCategory = iDFoodCategory;
        }
        public Food(DataRow row)
        {
            this.IDFood = (int)row["IDFood"];
            this.NameFood = row["NameFood"].ToString();
            this.Unit = row["Unit"].ToString();
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.IDFoodCategory = (int)row["IDCategory"];
        }
        private int iDFood;

        public int IDFood
        {
            get { return iDFood; }
            set { iDFood = value; }
        }
        private string nameFood;

        public string NameFood
        {
            get { return nameFood; }
            set { nameFood = value; }
        }
        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private int iDFoodCategory;

        public int IDFoodCategory
        {
            get { return iDFoodCategory; }
            set { iDFoodCategory = value; }
        }


    }
}
