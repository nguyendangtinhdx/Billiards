using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get {
                if (instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance; 
            }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int idBill)
        {
            List<BillInfo> list = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE IDBill = " + idBill);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                list.Add(info);
            }
            return list;
        }
        public int GetCountByIDBillAndIDFood(int idBill, int idFood) // lấy tổng số trang  // 24
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT Count FROM BillInfo WHERE IDBill = " + idBill + " AND IDFood = " + idFood);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public void InsertBillInfo(int idBill, int idFood, int count) // 11
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
        public bool CheckIDBillNotInOnBillInfo(int idBill)
        {
            string query = " SELECT IDBillInfo FROM BillInfo WHERE IDBill = " + idBill;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;// số dòng trả ra > 0
        }
      
    }
}
