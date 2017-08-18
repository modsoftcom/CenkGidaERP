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