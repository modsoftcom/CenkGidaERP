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
using DevExpress.XtraBars;
using Cenk.UI.Utils;

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

        private void btnLoadList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string name = e.Item.Tag.ToString();
            if (tabFormControl1.Pages.Count(p=>p.Name.Equals(name)) == 0)
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