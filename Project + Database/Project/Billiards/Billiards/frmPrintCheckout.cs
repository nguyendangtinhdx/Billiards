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
    public partial class frmPrintCheckout : Form
    {
        public frmPrintCheckout()
        {
            InitializeComponent();
        }

        private void frmPrintCheckout_Load(object sender, EventArgs e)
        {
            CrystalReport2 r = new CrystalReport2();
            r.SetDataSource(frmTableManager.listBillInfo);
            r.SetParameterValue("Table", frmTableManager.Ban);
            r.SetParameterValue("User", frmLogin.usernameLogin);
            r.SetParameterValue("DateCheckIn", frmTableManager.DateCheckIn);
            r.SetParameterValue("DateCheckOut", frmTableManager.DateCheckOut);
            r.SetParameterValue("Hour", frmTableManager.Hour);
            r.SetParameterValue("Minute", frmTableManager.Minute);

            r.SetParameterValue("SumMoney", frmTableManager.TongThanhTien);
            r.SetParameterValue("Discount", frmTableManager.GiamGia + " %");
            r.SetParameterValue("MoneyPlayTime", frmTableManager.MoneyPlayTime);
            r.SetParameterValue("SumMoneyCheckOut", frmTableManager.TongTienThanhToan);
            r.SetParameterValue("SumMoneyByWord", frmTableManager.TongTienBangChu);

            r.SetParameterValue("Money", frmTableManager.Money);
            crystalReportViewer1.ReportSource = r;
        }
    }
}
