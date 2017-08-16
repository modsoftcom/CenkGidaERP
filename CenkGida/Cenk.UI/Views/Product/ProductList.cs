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

namespace Cenk.UI.Views.Product
{
    public partial class ProductList : DevExpress.XtraEditors.XtraUserControl
    {
        public ProductList()
        {
            InitializeComponent();
            try
            {
                InitializeComponent();
                productBindingSource.DataSource = Service<Cenk.UI.Model.Product>.toBindingList;
                products.BestFitColumns();
            }
            catch (Exception e)
            {
                Logger.Add(e);
            }
        }

        private void products_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                Cenk.UI.Model.Product Entity = e.Row as Cenk.UI.Model.Product;
                Service<Cenk.UI.Model.Product>.AddOrUpdate(Entity);
                products.RefreshData();
                products.BestFitColumns();
            }
            catch (Exception)
            {

            }
        }
    }
}
