using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get {
                if (instance == null)
                    instance = new CategoryDAO();
                return CategoryDAO.instance; 
            }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = " SELECT * FROM FoodCategory ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }
        public Category GetNameCategoryByIDCategory(int idCategory) // 17
        {
            Category category = null;

            string query = "SELECT * FROM dbo.FoodCategory WHERE IDCategory = " + idCategory;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
            }

            return category;
        }
        public bool InsertCategory(string nameCategory)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_InsertCategory @nameCategory ", new object[]{nameCategory});

            return result > 0;

        }
        public bool UpdateCategory(int idCategory, string nameCategory)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_UpdateCategory @idCategory , @nameCategory ", new object[]{idCategory,nameCategory});

            return result > 0;
        }
        public bool DeleteCategory(int idCategory)
        {
            string query = "DELETE dbo.FoodCategory WHERE IDCategory = " + idCategory;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<Category> SearchCategory(string nameCategory)
        {
            List<Category> listCategory = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" USP_SearchCategory @nameCategory ", new object[]{nameCategory});
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                listCategory.Add(category);
            }

            return listCategory;
        }
    }
}
