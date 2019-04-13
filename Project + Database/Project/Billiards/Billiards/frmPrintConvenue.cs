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
    public partial class frmPrintConvenue : Form
    {
        public frmPrintConvenue()
        {
            InitializeComponent();
        }

        private void frmPrintConvenue_Load(object sender, EventArgs e)
        {
            CrystalReport1 r = new CrystalReport1();
            r.SetDataSource(frmAdmin.listConvenue);
            r.SetParameterValue("User", frmLogin.usernameLogin);
            r.SetParameterValue("SumConvenue", frmAdmin.TongDoanhThu);
            r.SetParameterValue("SumConvenueByWord", frmAdmin.TongTienBangChu);

            crystalReportViewer1.ReportSource = r;
        }
    }
}
