using Billiards.DAO;
using Billiards.DTO;
using Billiards.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiards
{
    public partial class frmTableManager : Form
    {
        public static List<DTO.Menu> listBillInfo;
        public static string NguoiLapPhieu = "";
        public static string Ban = "";
        public static int GiamGia = 0;
        public static string TongTienThanhToan = "";
        public static string TongThanhTien = "";
        public static string TongTienBangChu = "";
        public static string Hour = "";
        public static string Minute = "";
        public static DateTime DateCheckIn;
        public static DateTime DateCheckOut;
        public static string MoneyPlayTime = "";
        public static string Money = "";
        private float totalPriceCheckOut;
        private int moneyPlay;

        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            tênHiểnThịToolStripMenuItem.Text = LoginAccount.DisplayName;
        }
        public frmTableManager() { }
        public frmTableManager(Account acc)
        {
            InitializeComponent();
            try { 
                LoadAll();
                this.LoginAccount = acc;
            }
            catch (Exception)
            {
            }
        }

        System.Windows.Forms.Timer tmr = null;

        #region Methods
        void LoadAll()
        {
            LoadTable();
            StartTimer();
            LoadPlayTimeCombobox();
            LoadCategory();
            LoadComboboxTable(cbbSwitchTable);
            lbMoneyPlayTime.Text = frmLogin.savePlayTime;
            if (lbMoneyPlayTime.Text != PlayTimeDAO.Instance.GetMoneyByIDPLayTime(1).ToString())
            {
                cbbStatusPlayTime.SelectedIndex = 1;
            }
        }
        void LoadPlayTimeCombobox()
        {
            cbbStatusPlayTime.DataSource = PlayTimeDAO.Instance.GetListPlayTime();
            cbbStatusPlayTime.DisplayMember = "StatusPlayTime";
            cbbStatusPlayTime.ValueMember = "IDPlayTime";
        }
        void LoadMoneyPlayTime()
        {
            int idPlayTime = int.Parse(cbbStatusPlayTime.SelectedValue.ToString());
            lbMoneyPlayTime.Text = PlayTimeDAO.Instance.GetMoneyByIDPLayTime(idPlayTime).ToString();
        }
        void StartTimer()
        {
            try { 
                tmr = new System.Windows.Forms.Timer();
                tmr.Interval = 1000;
                tmr.Tick += new EventHandler(tmr_Tick);
                tmr.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            try { 
                String sDate = DateTime.Now.ToString();
                DateTime date = (Convert.ToDateTime(sDate.ToString()));

                //DateTime dateValue = new DateTime(date.Year, date.Month, date.Day);

                string dayOfWeek = date.DayOfWeek.ToString();

                if (Tool.ChuyenThuTiengAnhSangTiengViet.Change(date.DayOfWeek.ToString()) != "")
                {
                    dayOfWeek = Tool.ChuyenThuTiengAnhSangTiengViet.Change(date.DayOfWeek.ToString());
                }

                lbShowTime.Text = dayOfWeek + " - Ngày: " + DateTime.Now.ToString();
                lbMinute.Text = date.Minute.ToString();
            }
            catch (Exception)
            {
            }
        }
        void LoadComboboxTable(ComboBox cb) // 13
        {
            cbbSwitchTable.DataSource = TableDAO.Instance.GetListTable();
            cbbSwitchTable.DisplayMember = "NameTable";
        }
        void LoadCategory()
        {
            List<Category> list = CategoryDAO.Instance.GetListCategory();
            cbbCategory.DataSource = list;
            cbbCategory.DisplayMember = "NameCategory";
        }
        void LoadListFoodByIDCategory(int idCategory)
        {
            List<Food> list = FoodDAO.Instance.GetListFoodByIDCategory(idCategory);
            cbbFood.DataSource = list;
            cbbFood.DisplayMember = "NameFood";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear(); // 12
            List<Table> list = TableDAO.Instance.GetListTable();
            foreach (Table item in list)
            {
                Button btn = new Button() { Width = 150, Height = 245 };
                //btn.Text = Environment.NewLine + Environment.NewLine + item.NameTable + "    " + Environment.NewLine + Environment.NewLine + item.StatusTable; // hiển thị text lên mỗi bàn
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10,FontStyle.Bold);
                btn.ForeColor = Color.FromArgb(230, 230, 0);

                btn.Click += btn_Click; // click vào button từng bàn // 9
                //btn.MouseDown += btn_MouseDown; // click chuột phải vào bàn // tự làm
                btn.Tag = item; // lưu table vô     //9

                String sDate = BillDAO.Instance.GetDateTimeByIDTable(item.IDTable).ToString();
                DateTime date = (Convert.ToDateTime(sDate.ToString()));

                //string ap = "AM";
                //int hour = date.Hour;
                //if (hour >= 12)
                //{
                //    ap = "PM";
                //    hour -= 12;
                //}

                switch (item.StatusTable)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(255, 0, 0);
                        btn.BackgroundImage = Billiards.Properties.Resources.billiards2;
                        btn.Text = item.NameTable + Environment.NewLine + Environment.NewLine + 
                            Environment.NewLine + Environment.NewLine + item.StatusTable + Environment.NewLine  + 
                            Environment.NewLine + Environment.NewLine  + Environment.NewLine + Environment.NewLine  ; // hiển thị text lên mỗi bàn
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(79, 163, 6);
                        btn.BackgroundImage = Billiards.Properties.Resources.billiards;
                        btn.Text = item.NameTable + Environment.NewLine  + Environment.NewLine + Environment.NewLine +
                            Environment.NewLine + item.StatusTable + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                            date.Hour + " : " + date.Minute + " " + date.ToString("tt", CultureInfo.InvariantCulture) + 
                            Environment.NewLine + date.Day + "/" + date.Month + "/" + date.Year; // hiển thị text lên mỗi bàn
                        //btn.Text = Environment.NewLine + Environment.NewLine + item.NameTable + "    " + Environment.NewLine + hour + " : " + date.Minute + " " + ap + Environment.NewLine + item.Status; // hiển thị text lên mỗi bàn
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int idTable) // 9
        {
            lvBill.Items.Clear();
            listBillInfo = MenuDAO.Instance.GetListMenuByIDTable(idTable); // lấy được danh sách BillInfo 

            float totalPrice = 0;  // 10
            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem((lvBill.Items.Count + 1).ToString());
                lsvItem.SubItems.Add(item.NameFood.ToString());
                lsvItem.SubItems.Add(item.Unit.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                totalPrice += item.TotalPrice; // 10

                lvBill.Items.Add(lsvItem);
            }
            //CultureInfo culture = new CultureInfo("en-US"); // tiền $
            CultureInfo culture = new CultureInfo("vi-VN"); // tiền VNĐ

            txtTotalPriceBill.Text = totalPrice.ToString("c", culture); // hiển thị tiền hóa đơn
            lbTotalPriceBillFormat.Text = totalPrice.ToString();

            //hourPlay = BillDAO.Instance.GetHourByIDTable(idTable);
            //minutePlay = BillDAO.Instance.GetMinuteByIDTable(idTable);

            LoadPlayTime(idTable);

            //MessageBox.Show("" + BillDAO.Instance.GetDateTimeByIDTable(idTable) + "\n" + 
            //    DateTime.Now + "\n" + 
            //    dateSubstract  + "\n" +
            //    dateSubstract.Days + "\n" +
            //    dateSubstract.Hours + "\n" + 
            //    dateSubstract.Minutes);

        }
        void LoadPlayTime(int idTable)
        {
            CultureInfo culture = new CultureInfo("vi-VN"); // tiền VNĐ
            TimeSpan dateSubstract = (DateTime.Now).Subtract(BillDAO.Instance.GetDateTimeByIDTable(idTable)); // lấy giờ hiện tại - giờ DateCheckIn
            lbHourPLayTime.Text = (dateSubstract.Days * 24 + dateSubstract.Hours).ToString();
            lbMinutePLayTime.Text = dateSubstract.Minutes.ToString();

            moneyPlay = (int.Parse(lbHourPLayTime.Text) * int.Parse((lbMoneyPlayTime.Text))) + (int.Parse(lbMinutePLayTime.Text) * int.Parse(lbMoneyPlayTime.Text) / 60); // tính tiền giờ

            txtTotalPriceTimePlay.Text = moneyPlay.ToString("c", culture); // hiển thị tiền giờ
            lbTotalPriceTimePlayFormat.Text = moneyPlay.ToString();

            totalPriceCheckOut = float.Parse(lbTotalPriceBillFormat.Text) + float.Parse(lbTotalPriceTimePlayFormat.Text); // tính tổng tiền hóa đơn + tiền giờ

            lbTotalPriceFormat.Text = totalPriceCheckOut.ToString();
            txtTotalPrice.Text = totalPriceCheckOut.ToString("c", culture);  // hiển thị tổng thành tiền
            TongTienThanhToan = txtTotalPrice.Text;
        }

        #endregion


        #region Events
        private int idTableToChangeDateTime = 0;
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int idTable = ((sender as Button).Tag as Table).IDTable;
                lvBill.Tag = (sender as Button).Tag;
                ShowBill(idTable);
                Ban = ((sender as Button).Tag as Table).NameTable;
                idTableToChangeDateTime = idTable;

                DateCheckIn = BillDAO.Instance.GetDateTimeByIDTable(idTable);
                DateCheckOut = DateTime.Now;
                Hour = lbHourPLayTime.Text;
                Minute = lbMinutePLayTime.Text;
                MoneyPlayTime = lbTotalPriceTimePlayFormat.Text;

            }
            catch (Exception)
            {
            }
        }
        private void btnChangePlayTime_Click(object sender, EventArgs e)
        {
            try { 
                string password = txtPassword.Text;
                if (password == "")
                {
                    MessageBox.Show("Hãy nhập mật khẩu trước khi thay đổi !", "Thông báo");
                    return;
                }
                if (AccountDAO.Instance.CheckPasswordForChangeMoneyPlayTime(Tool.MaHoaMD5.MaHoa(password,password)))
                {
                    int idPlayTime = int.Parse(cbbStatusPlayTime.SelectedValue.ToString());
                    MessageBox.Show("Đổi tiền giờ từ " + lbMoneyPlayTime.Text + " sang " + PlayTimeDAO.Instance.GetMoneyByIDPLayTime(idPlayTime).ToString() + " thành công", "Thông báo");
                    txtPassword.Text = "";
                    LoadMoneyPlayTime();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác !", "Thông báo");
                    txtPassword.Focus();
                }
            }
            catch (Exception)
            {
            }
        }
        
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                frmAdmin f = new frmAdmin();

                f.InsertFood += f_InsertFood;
                f.UpdateFood += f_UpdateFood;
                f.DeleteFood += f_DeleteFood;

                f.InsertCategory += f_InsertCategory;
                f.UpdateCategory += f_UpdateCategory;
                f.DeleteCategory += f_DeleteCategory;

                f.InsertTable += f_InsertTable;
                f.UpdateTable += f_UpdateTable;
                f.DeleteTable += f_DeleteTable;

                f.UpdateAccount += f_UpdateAccount;

                f.InsertPlayTime += f_InsertPlayTime;
                f.UpdatePlayTime += f_UpdatePlayTime;
                f.DeletePlayTime += f_DeletePlayTime;
            
                f.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        void f_DeletePlayTime(object sender, EventArgs e)
        {
            try { 
                LoadMoneyPlayTime();
                LoadPlayTimeCombobox();
            }
            catch (Exception)
            {
            }
        }

        void f_UpdatePlayTime(object sender, EventArgs e)
        {
            try{
                LoadMoneyPlayTime();
                LoadPlayTimeCombobox();
              }
            catch (Exception)
            {
            }
        }

        void f_InsertPlayTime(object sender, EventArgs e)
        {
            try { 
                LoadMoneyPlayTime();
                LoadPlayTimeCombobox();
            }
            catch (Exception)
            {
            }
        }

        void f_UpdateAccount(object sender, EventArgs e)
        {
            try { 
                this.Close();
            }
            catch (Exception)
            {
            }
        }

        void f_DeleteTable(object sender, EventArgs e)
        {
            try { 
                LoadTable();
                LoadComboboxTable(cbbSwitchTable);
            }
            catch (Exception)
            {
            }
        }

        void f_UpdateTable(object sender, EventArgs e)
        {
            try { 
                LoadTable();
                LoadComboboxTable(cbbSwitchTable);
            }
            catch (Exception)
            {
            }
        }

        void f_InsertTable(object sender, EventArgs e)
        {
            try { 
                LoadTable();
                LoadComboboxTable(cbbSwitchTable);
            }
            catch (Exception)
            {
            }
        }

        void f_DeleteCategory(object sender, EventArgs e)
        {
            try { 
                LoadCategory();
                LoadListFoodByIDCategory((cbbCategory.SelectedItem as Category).IDCategory);
                if (lvBill.Tag != null)
                    ShowBill((lvBill.Tag as Table).IDTable);
                LoadTable();
            }
            catch (Exception)
            {
            }
        }

        void f_UpdateCategory(object sender, EventArgs e)
        {
            try { 
                LoadCategory();
            }
            catch (Exception)
            {
            }
        }

        void f_InsertCategory(object sender, EventArgs e)
        {
            try { 
                LoadCategory();
            }
            catch (Exception)
            {
            }
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            try { 
                LoadCategory();
                LoadListFoodByIDCategory((cbbCategory.SelectedItem as Category).IDCategory);
                if (lvBill.Tag != null)
                    ShowBill((lvBill.Tag as Table).IDTable);
                LoadTable();
            }
            catch (Exception)
            {
            }
        }

        void f_UpdateFood(object sender, EventArgs e)
        {
            try { 
                LoadListFoodByIDCategory((cbbCategory.SelectedItem as Category).IDCategory);
                if (lvBill.Tag != null)
                    ShowBill((lvBill.Tag as Table).IDTable);
            }
            catch (Exception)
            {
            }
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            try { 
                LoadListFoodByIDCategory((cbbCategory.SelectedItem as Category).IDCategory);
                if (lvBill.Tag != null)
                    ShowBill((lvBill.Tag as Table).IDTable);
            }
            catch (Exception)
            {
            }
        }
        public static bool checkUpdateAccout = false;
        private void tênHiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                frmAccountProfile f = new frmAccountProfile(loginAccount);
                f.UpdateAcount += f_UpdateAcount;
                f.ShowDialog();
                checkUpdateAccout = true;
            }
            catch (Exception)
            {
            }
        }
       
        void f_UpdateAcount(object sender, frmAccountProfile.AccountEvent e)
        {
            try { 
                tênHiểnThịToolStripMenuItem.Text = e.Acc.DisplayName;
            }
            catch (Exception)
            {
            }
        }
        private void thêmNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                frmDebt f = new frmDebt();
                f.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                this.Close();
            }
            catch (Exception)
            {
            }
        }
        private void frmTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { 
                frmLogin.savePlayTime = lbMoneyPlayTime.Text;
            }
            catch (Exception)
            {
            }
        }
        private void lbTotalPriceFormat_TextChanged(object sender, EventArgs e)
        {
            try { 
                lbTotalPrice.Text = ReadNumber.ByWords(decimal.Parse(lbTotalPriceFormat.Text)) + " đồng";
                TongTienBangChu = lbTotalPrice.Text;
            }
            catch (Exception)
            {
            }
        }

        private void lbMinute_TextChanged(object sender, EventArgs e)
        {
            try {
                LoadPlayTime(idTableToChangeDateTime);
            }
            catch (Exception)
            {
            }
        }
        private void lbMoneyPlayTime_TextChanged(object sender, EventArgs e)
        {
            try { 
                LoadPlayTime(idTableToChangeDateTime);
            }
            catch (Exception)
            {
            }
        }


        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                int idCategory = 0;
                ComboBox cb = sender as ComboBox;
                if (cb.SelectedItem == null)
                    return;
                Category selected = cb.SelectedItem as Category;
                idCategory = selected.IDCategory;
                LoadListFoodByIDCategory(idCategory);
            }
            catch (Exception)
            {
            }
        }

        private void cbbFood_Format(object sender, ListControlConvertEventArgs e)
        {
            try { 
                string name = ((Food)e.ListItem).NameFood;
                float price = ((Food)e.ListItem).Price;
                string unit = ((Food)e.ListItem).Unit;
                e.Value = name + " - " + unit + " - " + price + " đ";
            }
            catch (Exception)
            {
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvBill.Tag as Table;
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn để thêm hàng !", "Thông báo");
                    return;
                }

                int idBill = BillDAO.Instance.GetUncheckIDBillByIDTable(table.IDTable);
                int idFood = (cbbFood.SelectedItem as Food).IDFood;
                int count = (int)nmFoodCount.Value;
                if (count == 0)
                {
                    MessageBox.Show("Hãy nhập số lượng khác 0 !", "Thông báo" );
                    return;
                }
              
                if (idBill == -1) // không có bill nào(thêm bill mới)
                {
                    if (count < 0)
                    {
                        MessageBox.Show("Hãy nhập số lượng lớn hơn 0 !", "Thông báo" );
                        return;
                    }
                    BillDAO.Instance.InsertBill(table.IDTable);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), idFood, count);

                }
                else //  bill đã tồn tại
                {
                    if (count + BillInfoDAO.Instance.GetCountByIDBillAndIDFood(idBill, idFood) < 0)
                    {
                        MessageBox.Show("Hãy nhập số lượng lớn hơn " + " - " +(BillInfoDAO.Instance.GetCountByIDBillAndIDFood(idBill, idFood)+1) + " !", "Thông báo");
                        return;
                    }
                    else
                        BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
                }

                ShowBill(table.IDTable); // load mới lại sau khi thêm món

                LoadTable(); // chỉ thêm món mới load table // 12
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm món ăn thất bại !", "Thông báo");
            }
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvBill.Tag as Table;
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn để thanh toán !", "Thông báo");
                    return;
                }
                int idBill = BillDAO.Instance.GetUncheckIDBillByIDTable(table.IDTable);
                int discount = (int)nmDiscount.Value;  // lấy giá trị giảm giá // 13

                decimal totalPrice = decimal.Parse(Regex.Replace(txtTotalPrice.Text, @"[^\d]", ""));
                decimal finalTotalPrice = totalPrice - (totalPrice / 100) * discount; // 13
                if (idBill == -1)
                {
                    MessageBox.Show("Hãy chọn bàn Đang đánh để thanh toán !", "Thống báo");
                    return;
                }
                if (idBill != -1)
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn thanh toán hóa đơn cho {0} không ?\nSố giờ đánh = {1} \nTổng thành tiền toán = {2} VNĐ \nGiảm giá: {3} %\nTổng cộng = {4} VNĐ",
                           table.NameTable,lbHourPLayTime.Text + " : "+ lbMinutePLayTime.Text, totalPrice / 100, discount, finalTotalPrice / 100),
                           "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) // nếu nhấn OK
                    {
                        CultureInfo culture = new CultureInfo("vi-VN"); // tiền VNĐ
                        txtTotalPrice.Text = (finalTotalPrice / 100).ToString("c", culture);
                        lbTotalPriceFormat.Text = (finalTotalPrice / 100).ToString();
                        GiamGia = discount;
                        TongThanhTien = lbTotalPriceBillFormat.Text;
                        TongTienThanhToan = lbTotalPriceFormat.Text;
                        Money = lbMoneyPlayTime.Text;

                        if (MessageBox.Show("Bạn có muốn in hóa đơn cho " + table.NameTable + " không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) // nếu nhấn OK
                        {
                            frmPrintCheckout f = new frmPrintCheckout();
                            f.ShowDialog();
                        }

                        BillDAO.Instance.CheckOut(idBill, int.Parse(lbHourPLayTime.Text), int.Parse(lbMinutePLayTime.Text), discount, (float)finalTotalPrice / 100); // thanh toán
                        ShowBill(table.IDTable);

                        LoadTable(); // chỉ thanh toán mới load table // 12
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thanh toán thất bại !", "Thông báo");
            }
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvBill.Tag as Table;
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn để bắt đầu tính giờ !", "Thông báo");
                    return;
                }
                if (table.StatusTable.Equals("Trống"))
                {
                    BillDAO.Instance.InsertBill(table.IDTable);
                    TableDAO.Instance.UpdateTableWhenClickStart(table.IDTable);
                    LoadTable(); // chỉ thêm món mới load table // 12
                }
                else
                {
                    MessageBox.Show("Hãy chọn bàn Trống bắt đầu tính giờ !", "Thông báo");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm món ăn thất bại !", "Thông báo");
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvBill.Tag as Table;
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn để chuyển !", "Thông báo");
                    return;
                }
                int idTable1 = (lvBill.Tag as Table).IDTable;
                int idTable2 = (cbbSwitchTable.SelectedItem as Table).IDTable;
                string statusTable2 = TableDAO.Instance.GetStatusTableByIDTable(idTable2);
                int idBill2 = BillDAO.Instance.GetIDBillByIDTable(idTable2);
                if ((lvBill.Tag as Table).StatusTable.Equals(statusTable2))
                {
                    MessageBox.Show("Hãy chọn bàn khác để chuyển !", "Thông báo");
                    return;
                }
                else
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn chuyển {0} sang {1} không ?", (lvBill.Tag as Table).NameTable, (cbbSwitchTable.SelectedItem as Table).NameTable), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        TableDAO.Instance.SwitchTable(idTable1, idTable2);
                     
                        if ((lvBill.Tag as Table).StatusTable.Equals("Trống")) // khi click vào bàn trống trước khi chuyển
                        {
                            if (!BillInfoDAO.Instance.CheckIDBillNotInOnBillInfo(idBill2))
                            {
                                TableDAO.Instance.UpdateTableAfterSwitchTale(idTable1);
                            }
                            BillDAO.Instance.DeleteBillAfterSwitchTable(idTable2);
                        }
                        else
                        {
                            if (!BillInfoDAO.Instance.CheckIDBillNotInOnBillInfo(idBill2))
                            {
                                TableDAO.Instance.UpdateTableAfterSwitchTale(idTable2);
                            }
                            BillDAO.Instance.DeleteBillAfterSwitchTable(idTable1);
                        }
                       
                        LoadTable();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chuyển bàn thất bại !", "Thông báo");
            }
        }

        
        private void bắtĐầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                btnStart_Click(this, new EventArgs());
            }
            catch (Exception)
            {
            }
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                btnAddFood_Click(this, new EventArgs());
            }
            catch (Exception)
            {
            }
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                btnSwitchTable_Click(this, new EventArgs());
            }
            catch (Exception)
            {
            }
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                btnCheckOut_Click(this, new EventArgs());
            }
            catch (Exception)
            {
            }
        }

        #endregion
    }
}
