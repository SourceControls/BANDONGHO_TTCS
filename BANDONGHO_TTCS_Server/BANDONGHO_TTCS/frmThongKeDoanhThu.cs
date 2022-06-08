using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace BANDONGHO_TTCS
{
    public partial class frmThongKeDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                rpDOANHTHU_KH rp = new rpDOANHTHU_KH(dateEdit1.DateTime.ToShortDateString(), dateEdit2.DateTime.ToShortDateString());
                rp.ShowPreview();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                rpDOANHTHU_HANG rp = new rpDOANHTHU_HANG(dateEdit1.DateTime.ToShortDateString(), dateEdit2.DateTime.ToShortDateString());
                rp.ShowPreview();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                rpDOANHTHU_SP rp = new rpDOANHTHU_SP(dateEdit1.DateTime.ToShortDateString(), dateEdit2.DateTime.ToShortDateString());
                rp.ShowPreview();
            }
        }
    }
}