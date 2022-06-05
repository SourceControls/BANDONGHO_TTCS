using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BANDONGHO_TTCS
{
    public partial class XrptHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptHoaDon(string maPD)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maPD;
            this.sqlDataSource1.Fill();
        }

    }
}