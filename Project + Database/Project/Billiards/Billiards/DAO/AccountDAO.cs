using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = " USP_Login @userName , @passWord ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password /* list*/});
            return result.Rows.Count > 0;// số dòng trả ra > 0
        }
        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();
            string query = " SELECT * FROM Account ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }
        public Account GetAccountByUsername(string username) // 15
        {
            string query = " USP_GetAccountByUsername @userName ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{username});

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool CheckPasswordForChangeMoneyPlayTime(string password)
        {
            string query = " USP_CheckPasswordForChangeMoneyPlayTime @passWord ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {password});
            return result.Rows.Count > 0;// số dòng trả ra > 0
        }
        public bool UpdatePasswordProfile(string username, string passwordNew) // 15
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccountProfile @userName , @passwordNew", new object[]{username , passwordNew});

            return result > 0;// số dòng thây đổi > 0
        }
        public bool CheckAccount(string username)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery(" USP_CheckAccount @username ",new object[]{username});
            return result.Rows.Count > 0;// số dòng trả ra > 0
        }
        public bool InsertAccount(string username, string displayName, string password, int type)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_InsertAccount @username , @displayName , @password , @type ", new object[]{username,displayName,password,type});

            return result > 0;
        }
        public bool CheckPasswordForUpdateAccount(string password)
        {
            string query = " USP_CheckPasswordForUpdateAccount @password ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { password });
            return result.Rows.Count > 0;// số dòng trả ra > 0
        }
        public bool UpdateAccount(string username, string displayName, int type)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_UpdateAccount @username , @displayName , @type ", new object[] { username, displayName, type });

            return result > 0;
        }
        public bool DeleteAccount(string username) // 18
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_DeleteAccount @username ", new object[]{username});

            return result > 0;
        }
        public bool ResetPasswordAccount(string username, string password)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_ResetPassword @username , @password ", new object []{username,password});

            return result > 0;
        }
        public List<Account> SearchAccount(string displayName)
        {
            List<Account> listAccount = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" USP_SearchAccount @displayName ",new object[]{displayName});
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }

            return listAccount;
        }
        public List<Account> SearchAccountByDisplayNameOrAdmin(string displayName)
        {
            List<Account> listAccount = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" USP_SearchAccountByDisplayNameOrAdmin @displayName ", new object[] { displayName });
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }

            return listAccount;
        }
        public List<Account> SearchAccountByDisplayNameOrStaff(string displayName)
        {
            List<Account> listAccount = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" USP_SearchAccountByDisplayNameOrStaff @displayName ", new object[] { displayName });
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }

            return listAccount;
        }
        public List<Account> SearchAccountByAdmin()
        {
            List<Account> listAccount = new List<Account>();
            string query = string.Format("SELECT * FROM dbo.Account WHERE Type = 1");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }

            return listAccount;
        }
        public List<Account> SearchAccountByStaff()
        {
            List<Account> listAccount = new List<Account>();
            string query = string.Format("SELECT * FROM dbo.Account WHERE Type = 0");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }

            return listAccount;
        }
    }
}
