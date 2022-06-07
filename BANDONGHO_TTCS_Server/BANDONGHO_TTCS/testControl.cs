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

namespace BANDONGHO_TTCS
{
    public partial class testControl : DevExpress.XtraEditors.XtraUserControl
    {

        //coppy từ đoạn này
        private static testControl _instance;
        public static testControl Instance
        { 
           get
           {
                if (_instance == null)
                    _instance = new testControl();
                return _instance;
            }    
        }
        //đến đoạn này, lưu ý đổi tất cả class "testControl" cho phù hợp

            public testControl()
        {
            InitializeComponent();
        }
    }
}
