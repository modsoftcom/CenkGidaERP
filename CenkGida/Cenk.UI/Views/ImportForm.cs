using System;
using System.ComponentModel;
using DevExpress.Spreadsheet;
using Cenk.UI.Model;
using Cenk.UI.Utils;

namespace Cenk.UI.Views
{
    public partial class ImportForm : DevExpress.XtraEditors.XtraUserControl
    {
        string objName;
        public ImportForm(string objName)
        {
            this.objName = objName;
            InitializeComponent();
        }

        private void btnCreateEntities_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bg.RunWorkerAsync();
        }

        private void CreateCustomers()
        {
            Worksheet worksheet = spreadSheet.Document.Worksheets[0];
            for (int r = 3; r < worksheet.Rows.LastUsedIndex; r++)
            {
                Customer entity = new Customer();
                if (worksheet.Cells[r, 1].Value != null && !string.IsNullOrEmpty(worksheet.Cells[r, 1].Value.ToString()))
                    entity.Name = worksheet.Cells[r, 1].Value.ToString();
                if (worksheet.Cells[r, 2].Value != null && !string.IsNullOrEmpty(worksheet.Cells[r, 2].Value.ToString()))
                    entity.Address = worksheet.Cells[r, 2].Value.ToString();
                if (worksheet.Cells[r, 3].Value != null && !string.IsNullOrEmpty(worksheet.Cells[r, 3].Value.ToString()))
                    entity.TaxPlace = worksheet.Cells[r, 3].Value.ToString();
                if (worksheet.Cells[r, 4].Value != null && !string.IsNullOrEmpty(worksheet.Cells[r, 4].Value.ToString()))
                    entity.TaxNo = worksheet.Cells[r, 4].Value.ToString();
                Service<Customer>.AddOrUpdate(entity);
            }
        }

        private void CreateProducts()
        {
            throw new NotImplementedException();
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            loader.ShowWaitForm();
            loader.SetWaitFormCaption("Lütfen Bekleyiniz");
            loader.SetWaitFormDescription("İşlem yapılıyor...");
            switch (objName)
            {
                case "Customer":
                    CreateCustomers();
                    break;
                case "Product":
                    CreateProducts();
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