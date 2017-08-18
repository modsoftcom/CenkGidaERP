using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using Cenk.UI.Utils;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraBars.Ribbon;
using System.IO;
using Cenk.UI.Model;
using System.Collections.Generic;
using System.Data;

namespace Cenk.UI.Views
{
    public partial class BaseForm<T> : DevExpress.XtraEditors.XtraUserControl
    {
        public T Entity { get; set; }
        public List<T> Entities { get; set; }
        public BaseForm()
        {
            this.Tag = typeof(T).Name;
            InitializeComponent();
            if (DesignMode == false)
                this.Dock = System.Windows.Forms.DockStyle.Fill;
            bindingSource.DataSource = Service<T>.toBindingList;
            items.BestFitColumns();
            items.FocusedRowHandle = -1;
            switch (this.Tag.ToString())
            {
                case "Customer":
                    this.items.OptionsSelection.MultiSelect = false;
                    waybillGroup.Visible = true;
                    break;
                case "Product":
                    waybillGroup.Visible = true;
                    break;
                case "Waybill":
                    DesignForWayBill();
                    break;
                case "Order":
                    //DesignForOrder();
                    break;
                default:
                    break;
            }
        }
        private void DesignForWayBill()
        {
            orderGroup.Visible = true;
        }
        private void DesignForOrder()
        {
            throw new NotImplementedException();
        }


        public void btnNewClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                items.AddNewRow();
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }

        public void btnEditClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                items.UpdateCurrentRow();
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }

        public void btnDetailsClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                int index = items.FocusedRowHandle;
                if (index != -1)
                {
                    T entity = (T)items.GetRow(index);
                    switch (typeof(T).Name)
                    {

                        case "Customer":
                            //new CustomerDetails<T>(entity).ShowDialog();
                            MessageBox.Show(entity.ToString());
                            break;
                        case "Product":
                            MessageBox.Show(entity.ToString());
                            break;
                        case "Waybill":

                            break;
                        case "Order":

                            break;
                        default:
                            break;
                    }

                    //
                }
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }
        public void btnRefreshClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                bindingSource.DataSource = Service<T>.toBindingList;
                items.BestFitColumns();
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }
        public void btnDeleteClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                int index = items.FocusedRowHandle;
                if (index != -1 && items.RowCount > 0)
                {
                    T entity = (T)items.GetRow(index);
                    Service<T>.Delete(entity);
                    items.DeleteRow(items.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }

        public void btnExcelClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = string.Format("Kaydedeceğiniz Dosya Adını Yazınız");
                sfd.InitialDirectory = Properties.Settings.Default.ExportInitialDir;
                sfd.Filter = "Excel Dosyası (*.xls)|*.xls";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    Properties.Settings.Default.ExportInitialDir = Path.GetDirectoryName(sfd.FileName);
                    Properties.Settings.Default.Save();
                    items.ExportToXls(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }

        public void btnPDFClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = string.Format("Kaydedeceğiniz Dosya Adını Yazınız");
                sfd.InitialDirectory = Properties.Settings.Default.ExportInitialDir;
                sfd.Filter = "PDF Dosyası (*.pdf)|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    Properties.Settings.Default.ExportInitialDir = Path.GetDirectoryName(sfd.FileName);
                    Properties.Settings.Default.Save();
                    items.ExportToPdf(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }

        public void btnPreviewClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                items.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }

        public void btnPrintClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                items.PrintDialog();
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }

        public void RowUpdated(object sender, RowObjectEventArgs e)
        {
            try
            {
                T Entity = (T)e.Row;
                Service<T>.AddOrUpdate(Entity);
                items.RefreshData();
                items.BestFitColumns();
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }

        public void GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            try
            {
                Properties.Settings.Default.Theme = e.Item.Tag as string;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Logger.Add(ex);
            }
        }

        private void items_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Entities = new List<T>();
            btnCreateOrder.Enabled = items.SelectedRowsCount > 0;
            btnCreateWaybill.Enabled = items.SelectedRowsCount > 0;
            if (items.SelectedRowsCount > 0)
            {
                Entity = (T)items.GetFocusedRow();
                foreach (int i in items.GetSelectedRows())
                {
                    Entities.Add((T)items.GetRow(i));
                }
            }
        }

        
        public event EventHandler CreateOrderClick;
        protected void CreateOrderClick_Click(object sender, ItemClickEventArgs e)
        {
            if (this.CreateOrderClick != null)
                this.CreateOrderClick(this, e);
        }
        private void btnCreateOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateOrderClick(sender, e);
        }

        public event EventHandler CreateWaybillClick;
        protected void CreateWaybillClick_Click(object sender, ItemClickEventArgs e)
        {
            if (this.CreateWaybillClick != null)
                this.CreateWaybillClick(this, e);
        }
        private void btnCreateWaybill_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateWaybillClick(sender, e);
        }
    }
}