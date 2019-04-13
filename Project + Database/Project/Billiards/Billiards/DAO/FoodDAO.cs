using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodDAO();
                return FoodDAO.instance;
            }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }
        public List<Food> GetListFoodByIDCategory(int idCategory)
        {
            List<Food> list = new List<Food>();
            string query = " SELECT * FROM Food WHERE IDCategory = " + idCategory;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = " SELECT * FROM Food ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool InsertFood(string nameFood, string unit, float price, int idCategory) // 18
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_InsertFood @nameFood , @unit , @price , @idCategory ",new object[]{nameFood,unit,price,idCategory});

            return result > 0;
        }
        public bool UpdateFood(int idFood, string nameFood,string unit , float price , int idCategory) // 18
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_UpdateFood @idFood , @nameFood , @unit , @price , @idCategory ", new object[]{idFood,nameFood,unit,price,idCategory});
            
            return result > 0;
        }
        public bool DeleteFood(int idFood) // 18
        {
            //BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood); // xóa bên billInfo trước khi xóa bill
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Food WHERE IDFood = " + idFood);

            return result > 0;
        }
        public List<Food> SearchFoodByNameOrByPrice(string nameFood, float price)
        {
            List<Food> listFood = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" USP_SearchFoodByNameOrPrice @nameFood , @price",new object[]{nameFood,price});
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }

            return listFood;
        }
        public List<Food> SearchFoodByName(string nameFood)
        {
            List<Food> listFood = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" USP_SearchFoodByName @nameFood", new object[] {nameFood });
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }

            return listFood;
        }
        public List<Food> SearchFoodByPrice(float price)
        {
            List<Food> listFood = new List<Food>();
            string query = string.Format("SELECT * FROM dbo.Food WHERE Price = {0} ", price);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }

            return listFood;
        }
    }
}
