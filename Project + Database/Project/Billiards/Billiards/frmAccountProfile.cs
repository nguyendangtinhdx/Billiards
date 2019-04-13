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
    public partial class frmAccountProfile : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        void ChangeAccount(Account acc)
        {
            txtUsername.Text = LoginAccount.Username;
            txtDisplayName.Text = LoginAccount.DisplayName;
        }
        void UpdateAccount()
        {
            string username = txtUsername.Text;
            string displayName = txtDisplayName.Text;
            string passwordOld = txtPasswordOld.Text;
            string passwordNew = txtPasswordNew.Text;
            string reEnterPasswordNew = txtReEnterPasswordNew.Text;



            //if (passwordNew == "" && reEnterPasswordNew == "")
            //{
            //    if (AccountDAO.Instance.Login(username, Tool.MaHoaMD5.MaHoa(passwordOld, passwordOld)))
            //    {
            //        AccountDAO.Instance.UpdateUsernameProfile(username, displayName);
            //        MessageBox.Show("Cập nhật Tên hiển thị ( " + displayName + " ) thành công", "Thông báo");
            //        if (updateAccount != null)
            //        {
            //            updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUsername(username)));
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng điền đúng thông tin mật khẩu !", "Thông báo");
            //    }
            //}
            //else
            //{
            if (passwordOld == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu trước khi đổi !", "Thông báo");
                txtPasswordOld.Focus();
                return;
            }
            if (passwordNew == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu mới !", "Thông báo");
                txtPasswordNew.Focus();
                return;
            }
            if (!passwordNew.Equals(reEnterPasswordNew))
            {
                MessageBox.Show("Xác nhận mật khẩu mới không giống nhau !", "Thông báo");
                txtReEnterPasswordNew.Focus();
                return;
            }
            if (passwordOld.Equals(passwordNew))
            {
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ !", "Thông báo");
                txtPasswordNew.Focus();
                return;
            }
            if (AccountDAO.Instance.Login(username, Tool.MaHoaMD5.MaHoa(passwordOld, passwordOld)))
            {
                AccountDAO.Instance.UpdatePasswordProfile(username,Tool.MaHoaMD5.MaHoa(passwordNew, passwordNew));
                MessageBox.Show("Cập nhật mật khẩu của tài khoản ( " + username + " ) thành công", "Thông báo");
                if (updateAccount != null)
                {
                    updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUsername(username)));
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đúng thông tin mật khẩu !", "Thông báo");
                txtPasswordOld.Focus();
            }
        }
        // xử lý khi đổi displayName nó sẽ cập nhật trên thanh jTableManager luôn 
        private event EventHandler<AccountEvent> updateAccount;  // 15
        public event EventHandler<AccountEvent> UpdateAcount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        public frmAccountProfile(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateAccount();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật tài khoản cá nhân thất bại !", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class AccountEvent : EventArgs  // 15
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }

            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }

        private void frmAccountProfile_Load(object sender, EventArgs e)
        {
        }

    }
}
