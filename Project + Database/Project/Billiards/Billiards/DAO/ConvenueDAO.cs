using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class ConvenueDAO
    {
        private static ConvenueDAO instance;

        public static ConvenueDAO Instance
        {
            get {
                if (instance == null)
                    instance = new ConvenueDAO();
                return ConvenueDAO.instance; 
                }
            private set { ConvenueDAO.instance = value; }
        }
        private ConvenueDAO() { }
        public List<Convenue> GetListBill() // 14
        {
            List<Convenue> list = new List<Convenue>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT t.NameTable  , DateCheckIn , DateCheckOut , b.Hour, b.Minute, Discount  ,b.TotalPrice FROM dbo.Bill AS b, dbo.TableFood AS t WHERE b.StatusBill = 1 AND t.IDTable = b.IDTable ORDER BY b.DateCheckOut DESC ");
            foreach (DataRow item in data.Rows)
            {
                Convenue convenue = new Convenue(item);
                list.Add(convenue);
            }

            return list;
        }
        public List<Convenue> GetListBillByMonth(int month, int year) // 14
        {
            List<Convenue> list = new List<Convenue>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT t.NameTable  , DateCheckIn , DateCheckOut , b.Hour, b.Minute, Discount  ,b.TotalPrice FROM dbo.Bill AS b, dbo.TableFood AS t WHERE b.StatusBill = 1 AND t.IDTable = b.IDTable AND MONTH(b.DateCheckOut) = " + month + " AND YEAR(b.DateCheckOut) = " + year + " ORDER BY b.DateCheckOut DESC ");
            foreach (DataRow item in data.Rows)
            {
                Convenue convenue = new Convenue(item);
                list.Add(convenue);
            }

            return list;
        }
        public List<Convenue> GetListBillByYear(int year) // 14
        {
            List<Convenue> list = new List<Convenue>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT t.NameTable  , DateCheckIn , DateCheckOut , b.Hour, b.Minute, Discount  ,b.TotalPrice FROM dbo.Bill AS b, dbo.TableFood AS t WHERE b.StatusBill = 1 AND t.IDTable = b.IDTable AND YEAR(b.DateCheckOut) = " + year + " ORDER BY b.DateCheckOut DESC ");
            foreach (DataRow item in data.Rows)
            {
                Convenue convenue = new Convenue(item);
                list.Add(convenue);
            }

            return list;
        }
        public List<Convenue> GetListBillByDate(int day, int month, int year) // 14
        {
            List<Convenue> list = new List<Convenue>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate @day , @month , @year", new object[] { day, month, year});
            foreach (DataRow item in data.Rows)
            {
                Convenue convenue = new Convenue(item);
                list.Add(convenue);
            }

            return list;
        }
        public List<Convenue> GetListBillByDateAndPage(int day, int month, int year, int pageNum, int rowOfPage) // 14
        {
            List<Convenue> list = new List<Convenue>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDateAndPage @day , @month , @year , @page , @rowOfPage", new object[] { day, month, year,pageNum, rowOfPage });
            foreach (DataRow item in data.Rows)
            {
                Convenue bill = new Convenue(item);
                list.Add(bill);
            }

            return list;
        }
        public int GetNumListBillByDate(int day, int month, int year) // lấy tổng số trang  // 24
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumBillByDate @day , @month , @year", new object[] { day, month, year });
        }
    }
}
