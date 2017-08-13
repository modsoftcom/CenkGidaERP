using DevExpress.XtraEditors;
using System;

namespace Cenk.UI.Views.Tools
{
    public partial class ListViewBase : DevExpress.XtraEditors.XtraUserControl
    {
        int page = 0;
        public ListViewBase()
        {
            InitializeComponent();
        }

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            switch (e.Item.Text)
            {
                case "Müşteriler":
                    page = 0;
                    break;
                case "Ürünler":
                    page = 1;
                    break;
                case "İrsaliyeler":
                    page = 2;
                    break;
                case "Faturalar":
                    page = 3;
                    break;
                default:
                    break;
            }
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (page == 0)
            {
                customerList.customers.AddNewRow();
            }
        }

        private void btnDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(page == 0)
            {
                Cenk.UI.Model.Customer customer = (Cenk.UI.Model.Customer)customerList.customers.FocusedValue;
                XtraMessageBox.Show(customer.ToString());
            }
        }
    }
}
