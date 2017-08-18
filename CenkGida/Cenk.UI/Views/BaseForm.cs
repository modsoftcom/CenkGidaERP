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
using DevExpress.XtraBars;
using Cenk.UI.Utils;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraBars.Ribbon;
using System.IO;
using Cenk.UI.Views.DetailForms;

namespace Cenk.UI.Views
{
    public partial class BaseForm<T> : DevExpress.XtraEditors.XtraUserControl
    {
        public BaseForm()
        {
            this.Tag = typeof(T).Name;
            InitializeComponent();
            if (DesignMode == false)
                this.Dock = System.Windows.Forms.DockStyle.Fill;
            bindingSource.DataSource = Service<T>.toBindingList;
            items.BestFitColumns();
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
                            XtraMessageBox.Show(entity.ToString());
                            break;
                        case "Product":
                            XtraMessageBox.Show(entity.ToString());
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
                if (index != -1)
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
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName) && !string.IsNullOrWhiteSpace(sfd.FileName))
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
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName) && !string.IsNullOrWhiteSpace(sfd.FileName))
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


    }
}