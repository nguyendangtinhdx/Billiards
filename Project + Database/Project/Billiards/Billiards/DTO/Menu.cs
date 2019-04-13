using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class Menu
    {
        public Menu(string nameFood, string unit, int count, float price, float totalPrice = 0)
        {
            this.NameFood = nameFood;
            this.Unit = unit;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.NameFood = row["NameFood"].ToString();
            this.Unit = row["Unit"].ToString();
            this.Count = (int)row["Count"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
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
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
