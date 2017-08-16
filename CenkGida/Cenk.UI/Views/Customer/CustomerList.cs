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
using Cenk.UI.Model;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars;
using System.IO;

namespace Cenk.UI.Views.Customer
{
    public partial class CustomerList : DevExpress.XtraEditors.XtraForm
    {
        #region UI
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroup;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar navBar;
        private DevExpress.XtraGrid.GridControl gridItems;
        private DevExpress.XtraGrid.Views.Grid.GridView items;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDetails;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnPreview;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnXLS;
        private DevExpress.XtraBars.BarButtonItem btnPDF;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem theme;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Navigation.NavigationBarItem Müşteriler;
        private DevExpress.XtraBars.Navigation.NavigationBarItem Ürünler;
        private DevExpress.XtraBars.Navigation.NavigationBarItem İrsaliyeler;
        private DevExpress.XtraBars.Navigation.NavigationBarItem Faturalar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.BindingSource bindingSource;

        private void initUI()
        {
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetails = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnXLS = new DevExpress.XtraBars.BarButtonItem();
            this.btnPDF = new DevExpress.XtraBars.BarButtonItem();
            this.theme = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.Müşteriler = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.Ürünler = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.İrsaliyeler = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.Faturalar = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.gridItems = new DevExpress.XtraGrid.GridControl();
            this.items = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNew,
            this.btnDetails,
            this.btnEdit,
            this.btnRefresh,
            this.btnDelete,
            this.btnPreview,
            this.btnPrint,
            this.btnXLS,
            this.btnPDF,
            this.theme});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1029, 139);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "Yeni";
            this.btnNew.Id = 1;
            this.btnNew.ImageUri.Uri = "AddItem";
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += this.btnNewClick;
            // 
            // btnDetails
            // 
            this.btnDetails.Caption = "Görüntüle";
            this.btnDetails.Id = 2;
            this.btnDetails.ImageUri.Uri = "Show";
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ItemClick += this.btnDetailsClick;
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Düzenle";
            this.btnEdit.Id = 3;
            this.btnEdit.ImageUri.Uri = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += this.btnEditClick;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Yenile";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageUri.Uri = "Reset";
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += this.btnRefreshClick;
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Sil";
            this.btnDelete.Id = 5;
            this.btnDelete.ImageUri.Uri = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += this.btnDeleteClick;
            // 
            // btnPreview
            // 
            this.btnPreview.Caption = "Önizleme";
            this.btnPreview.Id = 6;
            this.btnPreview.ImageUri.Uri = "Zoom";
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ItemClick += this.btnPreviewClick;
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Yazdır";
            this.btnPrint.Id = 7;
            this.btnPrint.ImageUri.Uri = "Print";
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += this.btnPrintClick;
            // 
            // btnXLS
            // 
            this.btnXLS.Caption = "Excel\'e Aktar";
            this.btnXLS.Id = 8;
            this.btnXLS.ImageUri.Uri = "ExportToXLSX";
            this.btnXLS.Name = "btnXLS";
            this.btnXLS.ItemClick += this.btnExcelClick;
            // 
            // btnPDF
            // 
            this.btnPDF.Caption = "PDF\'e Aktar";
            this.btnPDF.Id = 9;
            this.btnPDF.ImageUri.Uri = "ExportToPDF";
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.ItemClick += this.btnPDFClick;
            // 
            // theme
            // 
            this.theme.Caption = "Tema Seçimi";
            this.theme.Id = 11;
            this.theme.Name = "theme";
            this.theme.GalleryItemClick += this.GalleryItemClick;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "İşlemler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDetails);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Kayıt İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPreview);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXLS);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPDF);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Çıktı İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.theme);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Görünüm Ayarları";
            // 
            // navBar
            // 
            this.navBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navBar.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.Müşteriler,
            this.Ürünler,
            this.İrsaliyeler,
            this.Faturalar});
            this.navBar.Location = new System.Drawing.Point(0, 681);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1029, 45);
            this.navBar.TabIndex = 1;
            // 
            // Müşteriler
            // 
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.Tag = "Customer";
            this.Müşteriler.Text = "Müşteriler";
            // 
            // Ürünler
            // 
            this.Ürünler.Name = "Ürünler";
            this.Ürünler.Tag = "Product";
            this.Ürünler.Text = "Ürünler";
            // 
            // İrsaliyeler
            // 
            this.İrsaliyeler.Name = "İrsaliyeler";
            this.İrsaliyeler.Tag = "Waybill";
            this.İrsaliyeler.Text = "İrsaliyeler";
            // 
            // Faturalar
            // 
            this.Faturalar.Name = "Faturalar";
            this.Faturalar.Tag = "Order";
            this.Faturalar.Text = "Faturalar";
            // 
            // customerBindingSource
            // 
            this.bindingSource.DataSource = typeof(Cenk.UI.Model.Customer);
            // 
            // gridItems
            // 
            this.gridItems.DataSource = this.bindingSource;
            this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItems.Location = new System.Drawing.Point(0, 139);
            this.gridItems.MainView = this.items;
            this.gridItems.Name = "gridItems";
            this.gridItems.Size = new System.Drawing.Size(1029, 542);
            this.gridItems.TabIndex = 2;
            this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.items});
            // 
            // items
            // 
            this.items.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.items.Appearance.EvenRow.Options.UseBackColor = true;
            this.items.GridControl = this.gridItems;
            this.items.Name = "items";
            this.items.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.items.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.items.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.items.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.items.OptionsEditForm.EditFormColumnCount = 2;
            this.items.OptionsFind.AlwaysVisible = true;
            this.items.OptionsFind.FindDelay = 100;
            this.items.OptionsFind.SearchInPreview = true;
            this.items.OptionsView.AllowHtmlDrawHeaders = true;
            this.items.OptionsView.EnableAppearanceEvenRow = true;
            this.items.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.items.OptionsView.ShowFooter = true;
            this.items.RowUpdated += this.RowUpdated;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";


            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.ribbon);

            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        } 
        #endregion
        public CustomerList()
        {
            try
            {
                InitializeComponent();
                initUI();
                //System.Data.DataSet xmlDataSet = new System.Data.DataSet("XML DataSet");
                //xmlDataSet.ReadXml(@"C:\Users\USER\Documents\Customers.xml");
                //gridItems.DataSource = xmlDataSet.Tables["Customer"];

                bindingSource.DataSource = Service<Cenk.UI.Model.Customer>.toBindingList;
                items.BestFitColumns();
            }
            catch (Exception e)
            {
                Logger.Add(e);
            }
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
                Cenk.UI.Model.Customer entity = (Cenk.UI.Model.Customer)items.FocusedValue;
                XtraMessageBox.Show(entity.ToString());
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
                items.RefreshData();
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
                    Cenk.UI.Model.Customer entity = (Cenk.UI.Model.Customer)items.GetRow(index);
                    Service<Cenk.UI.Model.Customer>.Delete(entity);
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


        public void NavigationItemClick(object sender, NavigationBarItemEventArgs e)
        {
            try
            {
                switch (e.Item.Tag.ToString())
                {
                    case "Cenk.UI.Model.Customer":

                        break;
                    case "Product":

                        break;
                    case "Waybill":

                        break;
                    case "Order":

                        break;
                    default:
                        break;
                }
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
                Cenk.UI.Model.Customer Entity = (Cenk.UI.Model.Customer)e.Row;
                Service<Cenk.UI.Model.Customer>.AddOrUpdate(Entity);
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
