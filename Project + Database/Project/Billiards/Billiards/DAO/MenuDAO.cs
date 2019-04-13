using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return MenuDAO.instance;
            }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByIDTable(int idTable)
        {
            List<Menu> list = new List<Menu>();
            string query = " SELECT f.NameFood,f.Unit, bi.Count ,f.Price, f.Price*bi.Count AS TotalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b ,dbo.Food AS f WHERE bi.IDBill = b.IDBill AND bi.IDFood = f.IDFood AND b.StatusBill = 0 AND b.IDTable = " + idTable;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                list.Add(menu);
            }
            return list;
        }
    }
}
