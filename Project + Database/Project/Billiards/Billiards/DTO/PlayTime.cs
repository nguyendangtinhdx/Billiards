using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class PlayTime
    {
        public PlayTime(int iDPlayTime, float moneyPlayTime, string statusPlayTime)
        {
            this.IDPlayTime = iDPlayTime;
            this.MoneyPlayTime = moneyPlayTime;
            this.StatusPlayTime = statusPlayTime;
        }
        public PlayTime(DataRow row)
        {
            this.IDPlayTime = (int)row["IDPlayTime"];
            this.MoneyPlayTime = (float)Convert.ToDouble(row["MoneyPlayTime"].ToString());
            this.StatusPlayTime = row["StatusPlayTime"].ToString();
        }
        private int iDPlayTime;

        public int IDPlayTime
        {
            get { return iDPlayTime; }
            set { iDPlayTime = value; }
        }
        private float moneyPlayTime;

        public float MoneyPlayTime
        {
            get { return moneyPlayTime; }
            set { moneyPlayTime = value; }
        }
        private string statusPlayTime;

        public string StatusPlayTime
        {
            get { return statusPlayTime; }
            set { statusPlayTime = value; }
        }
    }
}
