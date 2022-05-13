using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BANDONGHO_TTCS
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void openForm(Form newFrm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == newFrm.GetType())
                {
                    MessageBox.Show("Form đã mở sẵn");
                    f.Activate();
                    return;
                }
            }
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        public void closeAllForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

        }
    }
}
