using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get {
                if (instance == null)
                    instance = new BillDAO();
                    return BillDAO.instance; 
            }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetUncheckIDBillByIDTable(int idTable) // lấy IDbill  // 9
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE StatusBill = 0 AND IDTable = " + idTable);
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.IDBill;
            }
            return -1; // không có thằng nào hết
        }
        //public int GetHourByIDTable(int idTable) // lấy IDbill  // 9
        //{
        //    try
        //    {
        //        return (int)DataProvider.Instance.ExecuteScalar("SELECT Hour FROM dbo.Bill WHERE StatusBill = 0 AND IDTable = " + idTable);
        //    }
        //    catch (Exception)
        //    {
        //        return 0; // nghĩa là chưa có ID nào
        //    }
        //}
        //public int GetMinuteByIDTable(int idTable) // lấy IDbill  // 9
        //{
        //    try
        //    {
        //        return (int)DataProvider.Instance.ExecuteScalar("SELECT Minute FROM dbo.Bill WHERE StatusBill = 0 AND IDTable = " + idTable);
        //    }
        //    catch (Exception)
        //    {
        //        return 0; // nghĩa là chưa có ID nào
        //    }
        //}
        public DateTime GetDateTimeByIDTable(int idTable)  // tự làm
        {
            try
            {
                return (DateTime)DataProvider.Instance.ExecuteScalar(" SELECT DateCheckIn FROM Bill WHERE StatusBill = 0 AND IDTable = " + idTable);
            }
            catch
            {
                return DateTime.Now;
            }
        }
        public int GetMaxIDBill() // 11
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(IDBill) FROM dbo.Bill");
            }
            catch (Exception)
            {
                return 1; // nghĩa là chưa có ID nào
            }
        }
        public void InsertBill(int idTable)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { idTable });
        }
        public void CheckOut(int idBill,int hour,int minute , int discount, float totalPrice) // 12
        {
            string query = "UPDATE dbo.Bill SET DateCheckOut = GETDATE(), StatusBill = 1, Hour = " + hour + ", Minute = " + minute + ", Discount = " + discount + ", TotalPrice = " + totalPrice + " WHERE IDBill = " + idBill;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool DeleteBillAfterSwitchTable(int idTable) // tự làm
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" DELETE dbo.Bill WHERE StatusBill = 0 AND IDTable = " + idTable);
            return result > 0;
        }
        public int GetIDBillByIDTable(int idTable) // lấy tổng số trang  // 24
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT IDBill FROM Bill WHERE StatusBill = 0 AND IDTable = " + idTable);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public List<Bill> GetListBill()
        {
            List<Bill> list = new List<Bill>();
            string query = " SELECT * FROM Bill ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                list.Add(bill);
            }
            return list;
        }
        public Bill GetListBillByIDBill(int idBill)
        {
            Bill bill = null;

            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT * FROM Bill WHERE IDBill = " + idBill);
            foreach (DataRow item in data.Rows)
            {
                bill = new Bill(item);
            }

            return bill;
        }
    }
}
