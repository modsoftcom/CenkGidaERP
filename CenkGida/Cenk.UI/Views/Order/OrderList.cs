using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Cenk.UI.Utils;

namespace Cenk.UI.Views.Order
{
    public partial class OrderList : DevExpress.XtraEditors.XtraUserControl
    {
        public OrderList()
        {
            InitializeComponent();
            try
            {
                InitializeComponent();
                orderBindingSource.DataSource = Service<Cenk.UI.Model.Order>.toBindingList;
                orders.BestFitColumns();
            }
            catch (Exception e)
            {
                Logger.Add(e);
            }
        }

        private void orders_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                Cenk.UI.Model.Order Entity = e.Row as Cenk.UI.Model.Order;
                Service<Cenk.UI.Model.Order>.AddOrUpdate(Entity);
                orders.RefreshData();
                orders.BestFitColumns();
            }
            catch (Exception)
            {

            }
        }
    }
}
