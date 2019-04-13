using Billiards.DAO;
using Billiards.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiards
{
    public partial class frmLogin : Form
    {
        public static string savePlayTime = "";
        public static string usernameLogin = "";
        public frmLogin()
        {
            InitializeComponent();
            try { 
                savePlayTime = PlayTimeDAO.Instance.GetMoneyByIDPLayTime(1).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (Login(username, password))
                {
                    Account loginAccount = AccountDAO.Instance.GetAccountByUsername(username);
                    usernameLogin = username;
                    frmTableManager f = new frmTableManager(loginAccount);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập thất bại !", "Thông báo");
            }
        }
        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, Tool.MaHoaMD5.MaHoa(password, password));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { 
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
