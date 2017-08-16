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

namespace Cenk.UI.Views.Waybill
{
    public partial class WaybillList : DevExpress.XtraEditors.XtraUserControl
    {
        public WaybillList()
        {
            InitializeComponent();
            try
            {
                InitializeComponent();
                waybillBindingSource.DataSource = Service<Cenk.UI.Model.Waybill>.toBindingList;
                waybills.BestFitColumns();
            }
            catch (Exception e)
            {
                Logger.Add(e);
            }
        }

        private void waybills_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                Cenk.UI.Model.Waybill Entity = e.Row as Cenk.UI.Model.Waybill;
                Service<Cenk.UI.Model.Waybill>.AddOrUpdate(Entity);
                waybills.RefreshData();
                waybills.BestFitColumns();
            }
            catch (Exception)
            {

            }
        }
    }
}
