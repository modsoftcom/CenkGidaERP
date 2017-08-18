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
using Cenk.UI.Utils;

namespace Cenk.UI.Views.DetailForms
{
    public partial class CustomerDetails<T> : DevExpress.XtraEditors.XtraForm
    {
        public CustomerDetails(T Entity)
        {
            InitializeComponent();
            vGridBills.DataSource = Service<Customer>.toBindingList;
        }
    }
}