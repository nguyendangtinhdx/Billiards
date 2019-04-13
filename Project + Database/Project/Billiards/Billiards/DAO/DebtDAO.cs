using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class DebtDAO
    {
        private static DebtDAO instance;

        public static DebtDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DebtDAO();
                return DebtDAO.instance;
            }
            private set { DebtDAO.instance = value; }
        }
        private DebtDAO() { }
        public List<Debt> GetListDebt()
        {
            List<Debt> list = new List<Debt>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT * FROM Debt ");
            foreach (DataRow item in data.Rows)
            {
                Debt debt = new Debt(item);
                list.Add(debt);
            }
            return list;
        }
        
        public bool InsertDebt(string nameDebt, float money, int idBill) // 18
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_InsertDebt @nameDebt , @money , @idBill ", new object[] { nameDebt, money, idBill});

            return result > 0;
        }
        public bool UpdateDebt(int idDebt, string nameDebt, float money, int idBill) // 18
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_UpdateDebt @idDebt , @nameDebt , @money , @idBill ", new object[] { idDebt, nameDebt, money, idBill });
            
            return result > 0;
        }
        public bool DeleteDebt(int idDebt) // 18
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Debt WHERE IDDebt = " + idDebt);

            return result > 0;
        }
        public List<Debt> SearchDebtByNameDebt(string nameDebt)
        {
            List<Debt> list = new List<Debt>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" USP_SearchDebt @nameDebt", new object[] { nameDebt});
            foreach (DataRow item in data.Rows)
            {
                Debt debt = new Debt(item);
                list.Add(debt);
            }

            return list;
        }
        public List<Debt> SearchDebtByNameDebtOrMoney(string nameDebt, float money )
        {
            List<Debt> list = new List<Debt>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" USP_SearchDebtByNameDebtOrMoney @nameDebt , @money", new object[] { nameDebt, money });
            foreach (DataRow item in data.Rows)
            {
                Debt debt = new Debt(item);
                list.Add(debt);
            }

            return list;
        }

        public List<Debt> SearchDebtByMoney(float money)
        {
            List<Debt> list = new List<Debt>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT * FROM Debt WHERE Money = " + money);
            foreach (DataRow item in data.Rows)
            {
                Debt debt = new Debt(item);
                list.Add(debt);
            }

            return list;
        }
    }
}
