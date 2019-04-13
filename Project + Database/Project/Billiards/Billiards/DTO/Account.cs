using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DTO
{
    public class Account
    {
        public Account(string username, string displayName, string password, int type)
        {
            this.Username = username;
            this.DisplayName = displayName;
            this.Password = password;
            this.Type = type;
        }
        public Account(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Password = row["Password"].ToString();
            this.Type = (int)row["Type"];
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
