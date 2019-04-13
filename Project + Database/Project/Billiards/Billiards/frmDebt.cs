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
using System.Globalization;
namespace Billiards
{
    public partial class frmDebt : Form
    {
        BindingSource listDebt = new BindingSource();
        CultureInfo culture = new CultureInfo("vi-VN"); // tiền VNĐ
        public frmDebt()
        {
            InitializeComponent();
        }

        private void frmDebt_Load(object sender, EventArgs e)
        {
            try
            {
                dtgvDebt.DataSource = listDebt;

                LoadListDebt();
                AddDebtBingding();
                LoadBillIntoCombobox(cbbBill);
            }
            catch (Exception)
            {
            }
        }
        void LoadListDebt()
        {
            listDebt.DataSource = DebtDAO.Instance.GetListDebt();
        }
        void AddDebtBingding() // 17
        {
            txtIDDebt.DataBindings.Add(new Binding("Text", dtgvDebt.DataSource, "IDDebt", true, DataSourceUpdateMode.Never));
            txtNameDebt.DataBindings.Add(new Binding("Text", dtgvDebt.DataSource, "NameDebt", true, DataSourceUpdateMode.Never));
            nmMoney.DataBindings.Add(new Binding("Value", dtgvDebt.DataSource, "Money", true, DataSourceUpdateMode.Never));
            cbbStatusDebt.DataBindings.Add(new Binding("Text", dtgvDebt.DataSource, "StatusDebt", true, DataSourceUpdateMode.Never));
        }
        void LoadBillIntoCombobox(ComboBox cb) // 17
        {
            cbbBill.DataSource = BillDAO.Instance.GetListBill();
            cbbBill.ValueMember = "IDBill";
            cbbBill.DisplayMember = "IDBill";
        }
        private bool check = true;
        private void cbbBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                if (check)
                {
                    LoadBillIntoCombobox(cbbBill);
                }
                check = false;
                int idBill = int.Parse(cbbBill.SelectedValue.ToString());
                Bill bill = BillDAO.Instance.GetListBillByIDBill(idBill);
                lbDateCheckIn.Text = bill.DateCheckIn.ToString();
                lbDateCheckOut.Text = bill.DateCheckOut.ToString();
                lbHour.Text = bill.Hour.ToString();
                lbMinute.Text = bill.Minute.ToString();
                lbTotalPriceDebt.Text = bill.TotalPrice.ToString("c", culture);
            }
            catch (Exception)
            {
            }
        }

        private void cbbBill_Format(object sender, ListControlConvertEventArgs e)
        {
            try { 
                string dateCheckOut = ((Bill)e.ListItem).DateCheckOut.ToString();
                string idTable = ((Bill)e.ListItem).IDtable.ToString();
                string nameTable = TableDAO.Instance.GetNameTableByIdTable(int.Parse(idTable));
                e.Value += " - " + dateCheckOut + " - " + nameTable;
            }
            catch (Exception)
            {
            }
        }

        private void txtIDDebt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvDebt.SelectedCells.Count > 0)
                {
                    int idBill = (int)dtgvDebt.SelectedCells[0].OwningRow.Cells["IDBill"].Value;
                    Bill bill = BillDAO.Instance.GetListBillByIDBill(idBill);
                    cbbBill.SelectedItem = bill;

                    int index = -1;
                    int i = 0;
                    foreach (Bill item in cbbBill.Items)
                    {
                        if (item.IDBill == bill.IDBill)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbbBill.SelectedIndex = index;
                    lbDateCheckIn.Text = bill.DateCheckIn.ToString();
                    lbDateCheckOut.Text = bill.DateCheckOut.ToString();
                    lbHour.Text = bill.Hour.ToString();
                    lbMinute.Text = bill.Minute.ToString();
                    lbTotalPriceDebt.Text = bill.TotalPrice.ToString("c", culture);
                }

            }
            catch (Exception)
            {
            }
        }

        private void btnShowDebt_Click(object sender, EventArgs e)
        {
            try { 
                LoadListDebt();
            }
            catch (Exception)
            {
            }
        }

        private void btnAddDebt_Click(object sender, EventArgs e)
        {
            try
            {
                string nameDebt= txtNameDebt.Text;
                float money = (float)nmMoney.Value;
                int idBill = int.Parse(cbbBill.SelectedValue.ToString());
                if (nameDebt == "")
                {
                    MessageBox.Show("Hãy nhập tên người nợ !", "Thông báo");
                    txtNameDebt.Focus();
                    return;
                }
                if (money < 1000)
                {
                    MessageBox.Show("Số tiền nợ phải lớn hơn 1000 !", "Thông báo");
                    nmMoney.Focus();
                    return;
                }
                if (DebtDAO.Instance.InsertDebt(nameDebt, money, idBill))
                {
                    MessageBox.Show("Thêm người nợ ( " + nameDebt + " ) thành công", "Thông báo");
                    LoadListDebt();
                }
                else
                {
                    MessageBox.Show("Thêm người nợ ( " + nameDebt + " ) thất bại !", "Thông báo");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm người nợ thất bại !", "Thông báo");
            }
        }

        private void btnEditDebt_Click(object sender, EventArgs e)
        {
            try
            {
                int idDebt = Convert.ToInt32(txtIDDebt.Text);
                string nameDebt = txtNameDebt.Text;
                float money = (float)nmMoney.Value;
                int idBill = int.Parse(cbbBill.SelectedValue.ToString());
                if (nameDebt == "")
                {
                    MessageBox.Show("Hãy nhập tên người nợ !", "Thông báo");
                    txtNameDebt.Focus();
                    return;
                }
                if (money < 1000)
                {
                    MessageBox.Show("Số tiền nợ phải lớn hơn 1000 !", "Thông báo");
                    nmMoney.Focus();
                    return;
                }
                if (DebtDAO.Instance.UpdateDebt(idDebt, nameDebt, money, idBill))
                {
                    MessageBox.Show("Sửa người nợ ( " + nameDebt + " ) thành công", "Thông báo");
                    LoadListDebt();
                }
                else
                {
                    MessageBox.Show("Sửa người nợ ( " + nameDebt + " ) thất bại !", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa người nợ thất bại !", "Thông báo");
            }
        }

        private void btnRefreshDebt_Click(object sender, EventArgs e)
        {
            try { 
                txtNameDebt.Text = "";
                nmMoney.Value = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}
