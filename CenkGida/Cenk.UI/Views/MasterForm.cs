using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Cenk.UI.Model;
using DevExpress.XtraBars;
using Cenk.UI.Utils;
using System.Collections.Generic;
using MoreLinq;

namespace Cenk.UI.Views
{
    public partial class MasterForm : DevExpress.XtraBars.TabForm
    {
        BaseForm<Customer> CustomerForm;
        BaseForm<Product> ProductForm;
        BaseForm<Waybill> WaybillForm;
        BaseForm<Order> OrderForm;

        public MasterForm()
        {
            InitializeComponent();
            CustomerForm = new BaseForm<Customer>();
            ProductForm = new BaseForm<Product>();
            WaybillForm = new BaseForm<Waybill>();
            OrderForm = new BaseForm<Order>();

            xtraScrollableControl1.Controls.Add(CustomerForm);
            xtraScrollableControl2.Controls.Add(ProductForm);
            xtraScrollableControl3.Controls.Add(WaybillForm);
            xtraScrollableControl4.Controls.Add(OrderForm);
            tabFormControl1.SelectedPage = tabFormControl1.Pages[0];

            CustomerForm.CreateWaybillClick += CreateWaybillClick;
            ProductForm.CreateWaybillClick += CreateWaybillClick;
            WaybillForm.CreateOrderClick += CreateOrderClick;
        }

        private void CreateOrderClick(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Seçilen bu irsaliyeler ile fatura fatura oluşturmak istiyor musunuz?\n" +
                "", "Fatura Oluşturma Onay Ekranı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<string> ids = new List<string>();
                foreach (Waybill distId in WaybillForm.Entities)
                {
                    if (ids.Contains(distId.Customer.ToString()))
                        continue;
                    else
                        ids.Add(distId.Customer.ToString());
                    Order order = new Order();
                    foreach (Waybill waybill in WaybillForm.Entities.Where(w => w.Customer.Id == distId.Customer.Id))
                    {
                        order.Customer = waybill.Customer;
                        order.Waybills.Add(waybill);
                    }
                    Service<Order>.AddOrUpdate(order);
                }
            }
        }

        private void CreateWaybillClick(object sender, System.EventArgs e)
        {
            if (CustomerForm.Entity != null && ProductForm.Entities.Count > 0)
            {
                ConfirmWaybillForm dialog = new ConfirmWaybillForm(CustomerForm.Entity, ProductForm.Entities);
                dialog.ShowDialog();
                if (dialog.Waybills != null)
                {
                    foreach (Waybill waybill in dialog.Waybills)
                    {
                        Service<Waybill>.AddOrUpdate(waybill);
                    }
                    tabFormControl1.SelectedPage = tabFormControl1.Pages[2];
                }
            }

        }


        private void btnLoadList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string name = e.Item.Tag.ToString();
            if (tabFormControl1.Pages.Count(p => p.Name.Equals(name)) == 0)
            {
                TabFormPage page = new TabFormPage();
                page.Name = name;
                page.Text = getTranslatedName(name);
                XtraScrollableControl inner = new XtraScrollableControl();
                ImportForm form = new ImportForm(e.Item.Tag.ToString());
                form.Dock = DockStyle.Fill;
                inner.Controls.Add(form);
                page.ContentContainer = inner;
                this.tabFormControl1.Pages.Add(page);
            }
            tabFormControl1.SelectedPage = tabFormControl1.Pages.SingleOrDefault(p => p.Name.Equals(name));
        }

        private string getTranslatedName(string name)
        {
            switch (name)
            {
                case "Customer":
                    return "Müşteri Listesi Yükleme";
                case "Product":
                    return "Ürün Listesi Yükleme";
                default:
                    return "";
            }
        }

        private void btnEraseCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            bg.RunWorkerAsync("EraseCustomers");

        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            loader.ShowWaitForm();
            loader.SetWaitFormCaption("Lütfen Bekleyiniz");
            loader.SetWaitFormDescription("İşlem yapılıyor...");
            string option = sender.ToString();
            switch (option)
            {
                case "EraseCustomers":
                    var list = Service<Customer>.SelectAll();
                    foreach (var customer in list)
                    {
                        Service<Customer>.Delete(customer);
                        BaseForm<Customer> table = xtraScrollableControl1.Controls[0] as BaseForm<Customer>;
                        table.itemGrid.Refresh();
                    }
                    break;
                default:
                    break;
            }
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loader.CloseWaitForm();
        }
    }
}