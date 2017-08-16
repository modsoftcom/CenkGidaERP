using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Cenk.UI.Model;

namespace Cenk.UI.Views
{
    public partial class MasterForm : DevExpress.XtraBars.TabForm
    {
        public MasterForm()
        {
            InitializeComponent();
            xtraScrollableControl1.Controls.Add(new BaseForm<Cenk.UI.Model.Customer>());
            xtraScrollableControl2.Controls.Add(new BaseForm<Cenk.UI.Model.Product>());
            xtraScrollableControl3.Controls.Add(new BaseForm<Cenk.UI.Model.Waybill>());
            xtraScrollableControl4.Controls.Add(new BaseForm<Cenk.UI.Model.Order>());
            tabFormControl1.SelectedPage = tabFormControl1.Pages[0];
        }
        
        
    }
}