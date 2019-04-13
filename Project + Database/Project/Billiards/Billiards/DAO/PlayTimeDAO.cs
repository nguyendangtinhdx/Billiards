using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class PlayTimeDAO
    {
        private static PlayTimeDAO instance;

        public static PlayTimeDAO Instance
        {
            get {
                if (instance == null)
                    instance = new PlayTimeDAO();
                return PlayTimeDAO.instance; 
            }
            private set { PlayTimeDAO.instance = value; }
        }
        private PlayTimeDAO() { }
        public List<PlayTime> GetListPlayTime()
        {
            List<PlayTime> list = new List<PlayTime>();
            string query = " SELECT * FROM PlayTime ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PlayTime playTime = new PlayTime(item);
                list.Add(playTime);
            }
            return list;
        }
        public int GetMoneyByIDPLayTime(int idPlayTime) // lấy tổng số trang  // 24
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MoneyPlayTime FROM PLayTime WHERE IDPlayTime = " + idPlayTime);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool InsertPlayTime(float moneyPlayTime, string statusPlayTime) // 18
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_InsertPlayTime @moneyPlayTime , @statusPlayTime ", new object[] { moneyPlayTime, statusPlayTime });

            return result > 0;
        }
        public bool UpdatePlayTime(int idPlayTime, float moneyPlayTime, string statusPlayTime) // 18
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" USP_UpdatePlayTime @idPlayTime , @moneyPlayTime , @statusPlayTime ", new object[] { idPlayTime, moneyPlayTime, statusPlayTime });

            return result > 0;
        }
        public bool DeletePlayTime(int idPlayTime) // 18
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PlayTime WHERE IDPlayTime = " + idPlayTime);

            return result > 0;
        }
        public List<PlayTime> SearchPlayTimeHasAir()
        {
            List<PlayTime> list = new List<PlayTime>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT * FROM PlayTime WHERE StatusPlayTime = N'Có máy lạnh' ");
            foreach (DataRow item in data.Rows)
            {
                PlayTime playTime = new PlayTime(item);
                list.Add(playTime);
            }

            return list;
        }
        public List<PlayTime> SearchPlayTimeNotAir()
        {
            List<PlayTime> list = new List<PlayTime>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT * FROM PlayTime WHERE StatusPlayTime = N'Không máy lạnh' ");
            foreach (DataRow item in data.Rows)
            {
                PlayTime playTime = new PlayTime(item);
                list.Add(playTime);
            }

            return list;
        }
    }
}
