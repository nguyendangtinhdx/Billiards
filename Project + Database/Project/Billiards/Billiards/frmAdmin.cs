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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiards
{
    public partial class frmAdmin : Form
    {
        BindingSource listFood = new BindingSource();
        BindingSource listCategory = new BindingSource();
        BindingSource listTable = new BindingSource();
        BindingSource listAccount = new BindingSource();
        BindingSource listDebt= new BindingSource();
        BindingSource listPlayTime = new BindingSource();
        public static List<Convenue> listConvenue = new List<Convenue>();
        private int rowOfPage = 10;
        public static string TongDoanhThu = "";
        public static string TongTienBangChu = "";
        CultureInfo culture = new CultureInfo("vi-VN"); // tiền VNĐ
        public frmAdmin()
        {
            InitializeComponent();
            LoadAll();
            btnAddPlayTime.Enabled = false;
            btnDeletePlayTime.Enabled = false;
        }
      
        void LoadAll()
        {
            var currentDateTime = DateTime.Now;
            var day = currentDateTime.Day;
            var month = currentDateTime.Month;
            var year = currentDateTime.Year;

            lbDate.Text = MCBill.SelectionRange.Start.ToShortDateString();

            listConvenue = ConvenueDAO.Instance.GetListBillByDateAndPage(day, month, year, Convert.ToInt32(lbPageBill.Text), rowOfPage);

            dtgvPlayTime.DataSource = listPlayTime;
            dtgvDebt.DataSource = listDebt;
            dtgvAccount.DataSource = listAccount;
            dtgvTable.DataSource = listTable;
            dtgvCategory.DataSource = listCategory;
            dtgvFood.DataSource = listFood;
            dtgvBill.DataSource = listConvenue;

            LoadSumTotalPriceBill();
            LoadSumPageBill(day,month,year);

            LoadListFood();
            AddFoodBingding();
            LoadFoodCategoryIntoCombobox(cbbFoodCategory);

            LoadListCategory();
            AddCategoryBingding();

            LoadListTable();
            AddTableBingding();

            LoadListAccount();
            AddAccountBingding();

            LoadListDebt();
            AddDebtBingding();
            LoadBillIntoCombobox(cbbBill);

            LoadListPlayTime();
            AddPlayTimeBingding();
        }
        void LoadSumPageBill(int day, int month, int year)
        {
            int sumRecord = ConvenueDAO.Instance.GetNumListBillByDate(day,month,year);
            int lastPage = sumRecord / rowOfPage;
            if (sumRecord % rowOfPage != 0)
                lastPage++;
            lbSumPageBill.Text = lastPage.ToString();
        }
        void LoadSumTotalPriceBill()
        {
            float sum = 0;
            for (int i = 0; i < dtgvBill.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dtgvBill.Rows[i].Cells[6].Value);
            }
            
            txtTotalPrice.Text = sum.ToString("c", culture);
            lbTotalPriceFormat.Text = sum.ToString();

        }
        void LoadListBillByDateAndPage(int day, int month, int year) // 14
        {
            listConvenue = ConvenueDAO.Instance.GetListBillByDateAndPage(day, month, year, Convert.ToInt32(lbPageBill.Text), rowOfPage);
            LoadSumTotalPriceBill();
            dtgvBill.DataSource = listConvenue;
        }
        void LoadListFood()
        {
            listFood.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddFoodBingding() // 17
        {
            txtIDFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "IDFood", true, DataSourceUpdateMode.Never));
            txtNameFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "NameFood", true, DataSourceUpdateMode.Never));
            txtUnit.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Unit", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadFoodCategoryIntoCombobox(ComboBox cb) // 17
        {
            cbbFoodCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cbbFoodCategory.DisplayMember = "NameCategory";
        }
        void LoadListCategory()
        {
            listCategory.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void AddCategoryBingding() // 17
        {
            txtIDCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "IDCategory", true, DataSourceUpdateMode.Never));
            txtNameCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "NameCategory", true, DataSourceUpdateMode.Never));
        }
        void LoadListTable()
        {
            listTable.DataSource = TableDAO.Instance.GetListTable();
        }
        void AddTableBingding() // 17
        {
            txtIDTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "IDTable", true, DataSourceUpdateMode.Never));
            txtNameTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "NameTable", true, DataSourceUpdateMode.Never));
        }
        void LoadListAccount()
        {
            listAccount.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccountBingding() // 17
        {
            txtUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            lbAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
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

        void LoadListPlayTime()
        {
            listPlayTime.DataSource = PlayTimeDAO.Instance.GetListPlayTime();
        }
        void AddPlayTimeBingding() // 17
        {
            txtIDPlayTime.DataBindings.Add(new Binding("Text", dtgvPlayTime.DataSource, "IDPlayTime", true, DataSourceUpdateMode.Never));
            nmMoneyPlayTime.DataBindings.Add(new Binding("Value", dtgvPlayTime.DataSource, "MoneyPlayTime", true, DataSourceUpdateMode.Never));
            cbbStatusPlayTime.DataBindings.Add(new Binding("Text", dtgvPlayTime.DataSource, "StatusPlayTime", true, DataSourceUpdateMode.Never));
        }
        private void dtgvBill_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                DataGridView gridView = sender as DataGridView;
                if (null != gridView)
                {
                    foreach (DataGridViewRow r in gridView.Rows)
                    {
                        gridView.Rows[r.Index].HeaderCell.Value =
                                            (r.Index + 1).ToString();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private int d = 1, m = 1, y = 2020;
        private void MCBill_DateChanged(object sender, DateRangeEventArgs e)
        {
            try { 
                // thống kê theo ngày được chọn
                var day = e.Start;
                listConvenue = ConvenueDAO.Instance.GetListBillByDateAndPage(day.Day, day.Month, day.Year, Convert.ToInt32(lbPageBill.Text), rowOfPage);
                dtgvBill.DataSource = listConvenue;

                LoadSumTotalPriceBill();
                LoadSumPageBill(day.Day, day.Month, day.Year);

                lbDate.Text = MCBill.SelectionRange.Start.ToShortDateString();

                d = day.Day;
                m = day.Month;
                y = day.Year;
            }
            catch (Exception)
            {
            }
        }

        private void btnViewAllBill_Click(object sender, EventArgs e)
        {
            try { 
                listConvenue = ConvenueDAO.Instance.GetListBill();
                dtgvBill.DataSource = listConvenue;
                LoadSumTotalPriceBill();
            }
            catch (Exception)
            {
            }
        }
        private void btnViewYearBill_Click(object sender, EventArgs e)
        {
            try { 
                listConvenue = ConvenueDAO.Instance.GetListBillByYear(MCBill.SelectionRange.Start.Year);
                dtgvBill.DataSource = listConvenue;
                LoadSumTotalPriceBill();
            }
            catch (Exception)
            {
            }
        }
        private void btnViewMonthBill_Click(object sender, EventArgs e)
        {
            try { 
                listConvenue = ConvenueDAO.Instance.GetListBillByMonth(MCBill.SelectionRange.Start.Month, MCBill.SelectionRange.Start.Year);
                dtgvBill.DataSource = listConvenue;
                LoadSumTotalPriceBill();
            }
            catch (Exception)
            {
            }
        }
        private void lbTotalPriceFormat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTotalPrice.Text = ReadNumber.ByWords(decimal.Parse(lbTotalPriceFormat.Text)) + " đồng";
            }
            catch (Exception)
            {

            }
        }

        private void btnFirstBillPage_Click(object sender, EventArgs e)
        {
            try
            {
                lbPageBill.Text = "1";
            }
            catch (Exception)
            {
            }
        }

        private void btnNextBillPage_Click(object sender, EventArgs e)
        {
            try
            {
                int page = Convert.ToInt32(lbPageBill.Text);
                int sumRecord = ConvenueDAO.Instance.GetNumListBillByDate(d,m,y);
                int lastPage = sumRecord / rowOfPage;
                if (page < sumRecord)
                    page++;
                if (sumRecord % rowOfPage != 0)
                    lastPage++;
                if (page <= lastPage)
                {
                    lbPageBill.Text = page.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPreviousBillPage_Click(object sender, EventArgs e)
        {
            try
            {
                int page = Convert.ToInt32(lbPageBill.Text);
                if (page > 1)
                    page--;
                lbPageBill.Text = page.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnLastBillPage_Click(object sender, EventArgs e)
        {
            try
            {
                int page = Convert.ToInt32(lbPageBill.Text);
                int sumRecord = ConvenueDAO.Instance.GetNumListBillByDate(d, m, y);
                int lastPage = sumRecord / rowOfPage;
                if (page < sumRecord)
                    page++;
                if (sumRecord % rowOfPage != 0)
                    lastPage++;
                if (page <= lastPage)
                {
                    lbPageBill.Text = lastPage.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void lbPageBill_TextChanged(object sender, EventArgs e)
        {
            try { 
                listConvenue = ConvenueDAO.Instance.GetListBillByDateAndPage(d, m, y, Convert.ToInt32(lbPageBill.Text), rowOfPage);
                LoadSumTotalPriceBill();
                dtgvBill.DataSource = listConvenue;
            }
            catch (Exception)
            {
            }
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            try { 
                LoadListFood();
            }
            catch (Exception)
            {
            }
        }

        private void txtIDFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // lấy category ra
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int idCategory= (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IDFoodCategory"].Value;
                    Category category = CategoryDAO.Instance.GetNameCategoryByIDCategory(idCategory);
                    cbbFoodCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbbFoodCategory.Items)
                    {
                        if (item.IDCategory == category.IDCategory)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbbFoodCategory.SelectedIndex = index;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string nameFood = txtNameFood.Text;
                string unit = txtUnit.Text;
                float price = (float)nmPrice.Value;
                int idCategory = (cbbFoodCategory.SelectedItem as Category).IDCategory;
                if (nameFood == "")
                {
                    MessageBox.Show("Hãy nhập tên hàng !", "Thông báo");
                    txtNameFood.Focus();
                    return;
                }
                if (unit == "")
                {
                    MessageBox.Show("Hãy nhập đơn vị tính !", "Thông báo");
                    txtUnit.Focus();
                    return;
                }
                if (price <= 1000)
                {
                    MessageBox.Show("Giá hàng phải lớn hơn hoặc bằng 1000 !", "Thông báo");
                    nmPrice.Focus();
                    return;
                }
                if (FoodDAO.Instance.InsertFood(nameFood, unit, price, idCategory))
                {
                    MessageBox.Show("Thêm hàng ( " + nameFood + " ) thành công", "Thông báo");
                    LoadListFood();
                    if (insertFood != null)
                    {
                        insertFood(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Thêm hàng ( " + nameFood + " ) thất bại !", "Thông báo");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm món ăn thất bại !", "Thông báo");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            try
            {
                int idFood = Convert.ToInt32(txtIDFood.Text);
                string nameFood = txtNameFood.Text;
                string unit = txtUnit.Text;
                float price = (float)nmPrice.Value;
                int idCategory = (cbbFoodCategory.SelectedItem as Category).IDCategory;
                if (nameFood == "")
                {
                    MessageBox.Show("Hãy nhập tên hàng !", "Thông báo");
                    txtNameFood.Focus();
                    return;
                }
                if (unit == "")
                {
                    MessageBox.Show("Hãy nhập đơn vị tính !", "Thông báo");
                    txtUnit.Focus();
                    return;
                }
                if (price <= 1000)
                {
                    MessageBox.Show("Giá hàng phải lớn hơn hoặc bằng 1000 !", "Thông báo");
                    nmPrice.Focus();
                    return;
                }
                if (FoodDAO.Instance.UpdateFood(idFood, nameFood,unit, price,idCategory))
                {
                    MessageBox.Show("Sửa hàng thành ( " + nameFood + " ) thành công", "Thông báo");
                    LoadListFood();
                    if (updateFood != null)
                    {
                        updateFood(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Sửa hàng thành ( " + nameFood + " ) thất bại !", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa món ăn thất bại !", "Thông báo");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            try
            {
                int idFood = Convert.ToInt32(txtIDFood.Text);
                string nameFood = txtNameFood.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hàng ( " + nameFood + " ) không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (FoodDAO.Instance.DeleteFood(idFood))
                    {
                        MessageBox.Show("Xóa hàng ( " + nameFood + " ) thành công", "Thông báo");
                        LoadListFood();
                        if (deleteFood != null)
                        {
                            deleteFood(this, new EventArgs());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa hàng ( " + nameFood + " ) thất bại !", "Thông báo");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa món ăn thất bại !", "Thông báo");
            }
        }

        private event EventHandler insertFood; // khi thêm thì bên dtgvTable sẽ load lại       // 18
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (nmSeachPriceFood.Value == 0)
                {
                    listFood.DataSource = FoodDAO.Instance.SearchFoodByName(txtSearchFood.Text);
                }
                else if (txtSearchFood.Text == "" || txtSearchFood.Text == null)
                {
                    listFood.DataSource = FoodDAO.Instance.SearchFoodByPrice((float)nmSeachPriceFood.Value);
                }
                else if (nmSeachPriceFood.Value != 0 && (txtSearchFood.Text != "" || txtSearchFood.Text != null))
                    listFood.DataSource = FoodDAO.Instance.SearchFoodByNameOrByPrice(txtSearchFood.Text, (float)nmSeachPriceFood.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy hàng!", "Thông báo");
            }
        }
        private void btnRefreshFood_Click(object sender, EventArgs e)
        {
            try { 
                txtNameFood.Text = "";
                txtUnit.Text = "";
                nmPrice.Value = 0;
            }
            catch (Exception)
            {
            }
        }

        private void dtgvFood_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try { 
                DataGridView gridView = sender as DataGridView;
                if (null != gridView)
                {
                    foreach (DataGridViewRow r in gridView.Rows)
                    {
                        gridView.Rows[r.Index].HeaderCell.Value =
                                            (r.Index + 1).ToString();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            try { 
               LoadListCategory();
            }
            catch (Exception)
            {
            }
        }

        private void dtgvCategory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try { 
                DataGridView gridView = sender as DataGridView;
                if (null != gridView)
                {
                    foreach (DataGridViewRow r in gridView.Rows)
                    {
                        gridView.Rows[r.Index].HeaderCell.Value =
                                            (r.Index + 1).ToString();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string nameCategory = txtNameCategory.Text;
                if (nameCategory == "")
                {
                    MessageBox.Show("Hãy nhập tên danh mục hàng !", "Thông báo");
                    return;
                }

                if (CategoryDAO.Instance.InsertCategory(nameCategory))
                {
                    MessageBox.Show("Thêm danh mục ( " + nameCategory + " ) thành công", "Thông báo");
                    LoadListCategory();
                    LoadFoodCategoryIntoCombobox(cbbFoodCategory);
                    if (insertCategory != null)
                    {
                        insertCategory(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Thêm danh mục ( " + nameCategory + " ) thất bại !", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm danh mục món ăn thất bại !", "Thông báo");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategory = Convert.ToInt32(txtIDCategory.Text);
                string nameCategory = txtNameCategory.Text;
                if (nameCategory == "")
                {
                    MessageBox.Show("Hãy nhập tên danh mục hàng !", "Thông báo");
                    return;
                }

                if (CategoryDAO.Instance.UpdateCategory(idCategory, nameCategory))
                {
                    MessageBox.Show("Sửa danh mục thành ( " + nameCategory + " ) thành công", "Thông báo");
                    LoadListCategory();
                    LoadFoodCategoryIntoCombobox(cbbFoodCategory);
                    if (updateCategory != null)
                    {
                        updateCategory(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Sửa danh mục thành ( " + nameCategory + " ) thất bại !", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa danh mục món ăn thất bại !", "Thông báo");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategory = Convert.ToInt32(txtIDCategory.Text);
                string nameCategory = txtNameCategory.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục ( " + nameCategory + " ) không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (CategoryDAO.Instance.DeleteCategory(idCategory))
                    {
                        MessageBox.Show("Xóa danh mục ( " + nameCategory + " ) thành công", "Thông báo");
                        LoadListCategory();
                        LoadFoodCategoryIntoCombobox(cbbFoodCategory);
                        if (deleteCategory != null)
                        {
                            deleteCategory(this, new EventArgs());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa danh mục ( " + nameCategory + " ) thất bại !", "Thông báo");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa danh mục món ăn thất bại !", "Thông báo");
            }
        }

        private event EventHandler insertCategory; // khi thêm thì bên dtgvTable sẽ load lại       // 18
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        private void btnRefreshCategory_Click(object sender, EventArgs e)
        {
            try { 
                txtNameCategory.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            try
            {
                listCategory.DataSource = CategoryDAO.Instance.SearchCategory(txtSearchCategory.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy danh mục !", "Thông báo");
            }
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            try{
                LoadListTable();
               }
            catch (Exception)
            {
            }
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                string nameTable = txtNameTable.Text;
                if (nameTable == "")
                {
                    MessageBox.Show("Hãy nhập tên bàn !", "Thông báo");
                    txtNameTable.Focus();
                    return;
                }

                if (TableDAO.Instance.InsertTable(nameTable))
                {
                    MessageBox.Show("Thêm ( " + nameTable + " ) thành công", "Thông báo");
                    LoadListTable();
                    if (insertTable != null)
                    {
                        insertTable(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Thêm ( " + nameTable + " ) thất bại !", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm bàn ăn thất bại !", "Thông báo");
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            try
            {
                int idTable = Convert.ToInt32(txtIDTable.Text);
                string nameTable = txtNameTable.Text;
                if (nameTable == "")
                {
                    MessageBox.Show("Hãy nhập tên bàn !", "Thông báo");
                    txtNameTable.Focus();
                    return;
                }

                if (TableDAO.Instance.UpdateTable(idTable, nameTable))
                {
                    MessageBox.Show("Sửa thành ( " + nameTable + " ) thành công", "Thông báo");
                    LoadListTable();
                    if (updateTable != null)
                    {
                        updateTable(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Sửa thành ( " + nameTable + " ) thất bại !", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm bàn ăn thất bại !", "Thông báo");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            try
            {
                int idTable = Convert.ToInt32(txtIDTable.Text);
                string nameTable = txtNameTable.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa ( " + nameTable + " ) không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (TableDAO.Instance.DeleteTable(idTable))
                    {
                        MessageBox.Show("Xóa ( " + nameTable + " ) thành công", "Thông báo");
                        LoadListTable();
                        if (deleteTable != null)
                        {
                            deleteTable(this, new EventArgs());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa ( " + nameTable + " ) thất bại !", "Thông báo");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa bàn ăn thất bại !", "Thông báo");
            }
        }
        private event EventHandler insertTable; // khi thêm thì bên dtgvTable sẽ load lại       // 18
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }
        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }
        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            try { 
                if (rdAll.Checked)
                {
                    listTable.DataSource = TableDAO.Instance.SearchTableAll();
                }
                if (rdPlaying.Checked)
                {
                    listTable.DataSource = TableDAO.Instance.SearchTablePlaying();
                }
                if (rdEmpty.Checked)
                {
                    listTable.DataSource = TableDAO.Instance.SearchTableEmpty();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            try { 
                txtNameTable.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            try { 
                LoadListAccount();
            }
            catch (Exception)
            {
            }
        }
        private void lbAccountType_TextChanged(object sender, EventArgs e)
        {
            try { 
                cbbType.Text = "Nhân viên";
                if (lbAccountType.Text == "1")
                {
                    cbbType.Text = "Quản lý";
                }
                lbAccountType.Visible = false;
            }
            catch (Exception)
            {
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string displayName = txtDisplayName.Text;
                string password = txtPassword.Text;
                string reEnterPasswordNew = txtReEnterPasswordNew.Text;
                string typeAccount = cbbType.Text;
                int type = 0;
                if (typeAccount.Equals("Quản lý"))
                {
                    type = 1;
                }
                if (username == "")
                {
                    MessageBox.Show("Hãy nhập tên tài khoản !", "Thông báo");
                    txtUsername.Focus();
                    return;
                }
                if (displayName == "")
                {
                    MessageBox.Show("Hãy nhập tên hiển thị !", "Thông báo");
                    txtDisplayName.Focus();
                    return;
                }
                if (password == "")
                {
                    MessageBox.Show("Hãy nhập mật khẩu !", "Thông báo");
                    txtPassword.Focus();
                    return;
                }
                if (password != reEnterPasswordNew)
                {
                    MessageBox.Show("Xác nhận mật khẩu không giống nhau !", "Thông báo");
                    txtReEnterPasswordNew.Focus();
                    return;
                }
                if (AccountDAO.Instance.CheckAccount(username))
                {
                    MessageBox.Show("Tên tài khoản ( " + username + " ) đã tồn tại, Hãy nhập tên tài khoản khác !", "Thông báo");
                    txtUsername.Focus();
                    return;
                }
                else
                {
                    if (AccountDAO.Instance.InsertAccount(username, displayName, Tool.MaHoaMD5.MaHoa(password, password), type))
                    {
                        MessageBox.Show("Thêm tài khoản ( " + username + " ) thành công", "Thông báo");
                        LoadListAccount();
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản ( " + username + " ) thất bại !", "Thông báo");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm tài khoản thất bại !", "Thông báo");
            }
        }
        
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string displayName = txtDisplayName.Text;
                string password = txtPassword.Text;
                string reEnterPasswordNew = txtReEnterPasswordNew.Text;
                string typeAccount = cbbType.Text;
                int type = 0;
                if (typeAccount.Equals("Quản lý"))
                {
                    type = 1;
                }
                if (username == "")
                {
                    MessageBox.Show("Hãy nhập tên tài khoản !", "Thông báo");
                    txtUsername.Focus();
                    return;
                }
                if (displayName == "")
                {
                    MessageBox.Show("Hãy nhập tên hiển thị !", "Thông báo");
                    txtDisplayName.Focus();
                    return;
                }
                if (password == "")
                {
                    MessageBox.Show("Hãy nhập mật khẩu !", "Thông báo");
                    txtPassword.Focus();
                    return;
                }
                if (password != reEnterPasswordNew)
                {
                    MessageBox.Show("Xác nhận mật khẩu không giống nhau !", "Thông báo");
                    txtReEnterPasswordNew.Focus();
                    return;
                }
                if (!AccountDAO.Instance.CheckPasswordForUpdateAccount(Tool.MaHoaMD5.MaHoa(password,password)))
                {
                    MessageBox.Show("Mật khẩu không chính xác !", "Thông báo");
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    if (AccountDAO.Instance.UpdateAccount(username, displayName, type))
                    {
                        MessageBox.Show("Sửa tài khoản ( " + username + " ) thành công", "Thông báo");
                        LoadListAccount();
                        if (updateAccount != null)
                        {
                            updateAccount(this, new EventArgs());
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa tài khoản ( " + username + " ) thất bại !", "Thông báo");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa tài khoản thất bại !", "Thông báo");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản ( " + username + " ) không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (frmLogin.usernameLogin.Equals(username))
                    {
                        MessageBox.Show("Xóa tài khoản ( " + username + " ) của chính bạn thất bại !", "Thông báo");
                        return;
                    }
                    if (AccountDAO.Instance.DeleteAccount(username))
                    {
                        MessageBox.Show("Xóa tài khoản ( " + username + " ) thành công", "Thông báo");
                        LoadListAccount();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản ( " + username + " ) thất bại !", "Thông báo");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Xóa tài khoản thất bại !", "Thông báo");
            }
        }
        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try { 
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtReEnterPasswordNew.Text = "";
                txtDisplayName.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string reEnterPasswordNew = txtReEnterPasswordNew.Text;
                if (username == "")
                {
                    MessageBox.Show("Hãy nhập tên tài khoản !", "Thông báo");
                    txtUsername.Focus();
                    return;
                }
                if (password == "")
                {
                    MessageBox.Show("Hãy nhập mật khẩu !", "Thông báo");
                    txtPassword.Focus();
                    return;
                }
                if (password != reEnterPasswordNew)
                {
                    MessageBox.Show("Xác nhận mật khẩu không giống nhau !", "Thông báo");
                    txtReEnterPasswordNew.Focus();
                    return;
                }
                else
                {
                    if (AccountDAO.Instance.ResetPasswordAccount(username, Tool.MaHoaMD5.MaHoa(password, password)))
                    {
                        MessageBox.Show("Đặt lại mật khẩu của tài khoản ( " + username + " ) thành công", "Thông báo");
                        LoadListAccount();
                    }
                    else
                    {
                        MessageBox.Show("Đặt lại mật khẩu của tài khoản ( " + username + " ) thất bại !", "Thông báo");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại !", "Thông báo");
            }
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdAdmin.Checked == false && rdStaff.Checked == false)
                {
                    listAccount.DataSource = AccountDAO.Instance.SearchAccount(txtSearchAccount.Text);
                }
                if (rdAdmin.Checked == true)
                {
                    listAccount.DataSource = AccountDAO.Instance.SearchAccountByDisplayNameOrAdmin(txtSearchAccount.Text);
                }
                if (rdStaff.Checked == true)
                {
                    listAccount.DataSource = AccountDAO.Instance.SearchAccountByDisplayNameOrStaff(txtSearchAccount.Text);
                }
                if (rdAdmin.Checked == true && (txtSearchAccount.Text == "" || txtSearchAccount.Text == null))
                {
                    listAccount.DataSource = AccountDAO.Instance.SearchAccountByAdmin();
                }
                if (rdStaff.Checked == true && (txtSearchAccount.Text == "" || txtSearchAccount.Text == null))
                {
                    listAccount.DataSource = AccountDAO.Instance.SearchAccountByStaff();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Tìm tài khoản thất bại !", "Thông báo");
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
                int idDebt= Convert.ToInt32(txtIDDebt.Text);
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
                if (DebtDAO.Instance.UpdateDebt(idDebt, nameDebt,money,idBill))
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

        private void btnDeleteDebt_Click(object sender, EventArgs e)
        {
            try
            {
                int idDebt = Convert.ToInt32(txtIDDebt.Text);
                string nameDebt = txtNameDebt.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa người nợ ( " + nameDebt + " ) không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (DebtDAO.Instance.DeleteDebt(idDebt))
                    {
                        MessageBox.Show("Xóa người nợ ( " + nameDebt + " ) thành công", "Thông báo");
                        LoadListDebt();
                    }
                    else
                    {
                        MessageBox.Show("Xóa người nợ ( " + nameDebt + " ) thất bại !", "Thông báo");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa người nợ thất bại !", "Thông báo");
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
        private void btnSearchDebt_Click(object sender, EventArgs e)
        {
            try
            {
                if (nmSearchDebt.Value == 0)
                {
                    listDebt.DataSource = DebtDAO.Instance.SearchDebtByNameDebt(txtSearchDebt.Text);
                }
                else if (txtSearchDebt.Text == "" || txtSearchDebt.Text == null)
                {
                    listDebt.DataSource = DebtDAO.Instance.SearchDebtByMoney((float)nmSearchDebt.Value);
                }
                else if (nmSearchDebt.Value != 0 && (txtSearchDebt.Text != "" || txtSearchDebt.Text != null))
                    listDebt.DataSource = DebtDAO.Instance.SearchDebtByNameDebtOrMoney(txtSearchDebt.Text, (float)nmSearchDebt.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy người nợ!", "Thông báo");
            }
        }

        private void btnShowPlayTime_Click(object sender, EventArgs e)
        {
            try { 
                LoadListPlayTime();
            }
            catch (Exception)
            {
            }
        }

        private void btnAddTimePlay_Click(object sender, EventArgs e)
        {
            try
            {
                float moneyPlayTime = (float)nmMoneyPlayTime.Value;
                string statusPlayTime = cbbStatusPlayTime.Text;
                if (moneyPlayTime < 1000)
                {
                    MessageBox.Show("Số tiền giờ phải lớn hơn 1000 !", "Thông báo");
                    nmMoneyPlayTime.Focus();
                    return;
                }
                if (PlayTimeDAO.Instance.InsertPlayTime(moneyPlayTime, statusPlayTime))
                {
                    MessageBox.Show("Thêm tiền giờ ( " + statusPlayTime + " ) thành công", "Thông báo");
                    LoadListPlayTime();
                    if (insertPlayTime!= null)
                    {
                        insertPlayTime(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Thêm tiền giờ ( " + statusPlayTime + " ) thất bại !", "Thông báo");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm người nợ thất bại !", "Thông báo");
            }
        }

        private void btnRefreshPlayTime_Click(object sender, EventArgs e)
        {
            try { 
                nmMoneyPlayTime.Value = 0;
            }
            catch (Exception)
            {
            }
        }

        private void btnEditTimePlay_Click(object sender, EventArgs e)
        {
            try
            {
                int idDPlayTime = Convert.ToInt32(txtIDPlayTime.Text);
                float moneyPlayTime = (float)nmMoneyPlayTime.Value;
                string statusPlayTime = cbbStatusPlayTime.Text;
                if (moneyPlayTime < 1000)
                {
                    MessageBox.Show("Số tiền giờ phải lớn hơn 1000 !", "Thông báo");
                    nmMoneyPlayTime.Focus();
                    return;
                }
                if (PlayTimeDAO.Instance.UpdatePlayTime(idDPlayTime, moneyPlayTime, statusPlayTime))
                {
                    MessageBox.Show("Sửa tiền giờ ( " + statusPlayTime + " ) thành công", "Thông báo");
                    LoadListPlayTime();
                    if (updatePlayTime != null)
                    {
                        updatePlayTime(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Sửa tiền giờ ( " + statusPlayTime + " ) thất bại !", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa tiền giờ thất bại !", "Thông báo");
            }
        }

        private void btnDeleteTimePlay_Click(object sender, EventArgs e)
        {
            try
            {
                int idDPlayTime = Convert.ToInt32(txtIDPlayTime.Text);
                string statusPlayTime = cbbStatusPlayTime.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tiền giờ ( " + statusPlayTime + " ) không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (PlayTimeDAO.Instance.DeletePlayTime(idDPlayTime))
                    {
                        MessageBox.Show("Xóa tiền giờ ( " + statusPlayTime + " ) thành công", "Thông báo");
                        LoadListPlayTime();
                        if (deletePlayTime != null)
                        {
                            deletePlayTime(this, new EventArgs());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa tiền giờ ( " + statusPlayTime + " ) thất bại !", "Thông báo");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa tiền giờ thất bại !", "Thông báo");
            }
        }
        private event EventHandler insertPlayTime; // khi thêm thì bên dtgvTable sẽ load lại       // 18
        public event EventHandler InsertPlayTime
        {
            add { insertPlayTime += value; }
            remove { insertPlayTime -= value; }
        }
        private event EventHandler updatePlayTime;
        public event EventHandler UpdatePlayTime
        {
            add { updatePlayTime += value; }
            remove { updatePlayTime -= value; }
        }
        private event EventHandler deletePlayTime;
        public event EventHandler DeletePlayTime
        {
            add { deletePlayTime += value; }
            remove { deletePlayTime -= value; }
        }

        private void btnSearchPlayTime_Click(object sender, EventArgs e)
        {
            try { 
                if (rdHasAir.Checked)
                {
                    listPlayTime.DataSource = PlayTimeDAO.Instance.SearchPlayTimeHasAir();
                }
                if (rdNotAir.Checked)
                {
                    listPlayTime.DataSource = PlayTimeDAO.Instance.SearchPlayTimeNotAir();
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            try { 
                if (txtKey.Text == "812237559")
                {
                    btnAddPlayTime.Enabled = true;
                    btnDeletePlayTime.Enabled = true;
                }
                else
                {
                    btnAddPlayTime.Enabled = false;
                    btnDeletePlayTime.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPrintRevenue_Click(object sender, EventArgs e)
        {
            try { 
                TongDoanhThu = lbTotalPriceFormat.Text;
                TongTienBangChu = lbTotalPrice.Text;
                frmPrintConvenue f = new frmPrintConvenue();
                f.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

       








    }
}
