using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get {
                if (instance == null)
                    instance = new TableDAO();
                return TableDAO.instance; 
            }
            private set { TableDAO.instance = value; }
        }
        private TableDAO() { }
        public List<Table> GetListTable()  // tự làm
        {
            List<Table> listTable = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT * FROM TableFood ");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }
            return listTable;
        }
        public string GetNameTableByIdTable(int idTable)  // tự làm
        {
            return (string)DataProvider.Instance.ExecuteScalar("SELECT NameTable FROM TableFood WHERE IDTable = " + idTable);
        }
        public bool UpdateTableWhenClickStart(int idTable)  // tự làm
        {
            string query = " UPDATE dbo.TableFood SET StatusTable = N'Đang đánh' WHERE IDTable = " + idTable;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void SwitchTable(int idTable1, int idTable2) // 13
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { idTable1, idTable2 });
        }
        public string GetStatusTableByIDTable(int idTable) // lấy tổng số trang  // 24
        {
            return (string)DataProvider.Instance.ExecuteScalar("SELECT StatusTable FROM TableFood WHERE IDTable = " + idTable);
        }
        public bool UpdateTableAfterSwitchTale(int idTable)  // tự làm
        {
            string query = " UPDATE dbo.TableFood SET StatusTable = N'Đang đánh' WHERE IDTable = " + idTable;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool InsertTable(string nameTable)  // tự làm
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_InsertTable @nameTable ", new object[]{nameTable});

            return result > 0;
        }
        public bool UpdateTable(int idTable, string nameTable)  // tự làm
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_UpdateTable @idTable , @nameTable ",new object[]{idTable, nameTable});

            return result > 0;
        }
        public bool DeleteTable(int idTable) // tự làm
        {
            string query = "DELETE dbo.TableFood WHERE IDTable = " + idTable;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<Table> SearchTableAll()
        {
            List<Table> listTable = new List<Table>();
            string query = string.Format(" SELECT * FROM TableFood ");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }

            return listTable;
        }
        public List<Table> SearchTablePlaying()
        {
            List<Table> listTable = new List<Table>();
            string query = string.Format(" SELECT * FROM TableFood WHERE StatusTable = N'Đang đánh' ");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }

            return listTable;
        }
        public List<Table> SearchTableEmpty()
        {
            List<Table> listTable = new List<Table>();
            string query = string.Format(" SELECT * FROM TableFood WHERE StatusTable = N'Trống' ");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }

            return listTable;
        }
    }
}
