using Cenk.UI.Views;

namespace Cenk.UI.Views
{
    partial class BaseForm<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateWaybill = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.orderGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.waybillGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.itemGrid = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource();
            this.items = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNew,
            this.btnDetails,
            this.btnEdit,
            this.btnRefresh,
            this.btnDelete,
            this.btnPreview,
            this.btnPrint,
            this.btnXLS,
            this.btnPDF,
            this.theme,
            this.barButtonItem1,
            this.btnCreateOrder,
            this.btnCreateWaybill});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(957, 139);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "Yeni";
            this.btnNew.Id = 1;
            this.btnNew.ImageUri.Uri = "AddItem";
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewClick);
            // 
            // btnDetails
            // 
            this.btnDetails.Caption = "Görüntüle";
            this.btnDetails.Id = 2;
            this.btnDetails.ImageUri.Uri = "Show";
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailsClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Düzenle";
            this.btnEdit.Id = 3;
            this.btnEdit.ImageUri.Uri = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Yenile";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageUri.Uri = "Reset";
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Sil";
            this.btnDelete.Id = 5;
            this.btnDelete.ImageUri.Uri = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteClick);
            // 
            // btnPreview
            // 
            this.btnPreview.Caption = "Önizleme";
            this.btnPreview.Id = 6;
            this.btnPreview.ImageUri.Uri = "Zoom";
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreviewClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Yazdır";
            this.btnPrint.Id = 7;
            this.btnPrint.ImageUri.Uri = "Print";
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintClick);
            // 
            // btnXLS
            // 
            this.btnXLS.Caption = "Excel\'e Aktar";
            this.btnXLS.Id = 8;
            this.btnXLS.ImageUri.Uri = "ExportToXLSX";
            this.btnXLS.Name = "btnXLS";
            this.btnXLS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcelClick);
            // 
            // btnPDF
            // 
            this.btnPDF.Caption = "PDF\'e Aktar";
            this.btnPDF.Id = 9;
            this.btnPDF.ImageUri.Uri = "ExportToPDF";
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPDFClick);
            // 
            // theme
            // 
            this.theme.Caption = "Tema Seçimi";
            this.theme.Id = 11;
            this.theme.Name = "theme";
            this.theme.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.GalleryItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Caption = "Fatura Oluştur";
            this.btnCreateOrder.Id = 10;
            this.btnCreateOrder.ImageUri.Uri = "DoubleNext";
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCreateOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateOrder_ItemClick);
            // 
            // btnCreateWaybill
            // 
            this.btnCreateWaybill.Caption = "İrsaliye Oluştur";
            this.btnCreateWaybill.Id = 11;
            this.btnCreateWaybill.ImageUri.Uri = "TopAndBottom";
            this.btnCreateWaybill.Name = "btnCreateWaybill";
            this.btnCreateWaybill.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCreateWaybill.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateWaybill_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.orderGroup,
            this.waybillGroup});
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
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Kayıt İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPreview);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXLS);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPDF);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Çıktı İşlemleri";
            // 
            // orderGroup
            // 
            this.orderGroup.AllowTextClipping = false;
            this.orderGroup.ItemLinks.Add(this.btnCreateOrder);
            this.orderGroup.Name = "orderGroup";
            this.orderGroup.ShowCaptionButton = false;
            this.orderGroup.Text = "İrsaliye İşlemleri";
            this.orderGroup.Visible = false;
            // 
            // waybillGroup
            // 
            this.waybillGroup.AllowTextClipping = false;
            this.waybillGroup.ItemLinks.Add(this.btnCreateWaybill);
            this.waybillGroup.Name = "waybillGroup";
            this.waybillGroup.ShowCaptionButton = false;
            this.waybillGroup.Text = "Müşteri İşlemleri";
            this.waybillGroup.Visible = false;
            // 
            // itemGrid
            // 
            this.itemGrid.DataSource = this.bindingSource;
            this.itemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGrid.Location = new System.Drawing.Point(0, 139);
            this.itemGrid.MainView = this.items;
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.Size = new System.Drawing.Size(957, 349);
            this.itemGrid.TabIndex = 1;
            this.itemGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.items});
            // 
            // items
            // 
            this.items.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.items.Appearance.SelectedRow.Options.UseBackColor = true;
            this.items.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.items.GridControl = this.itemGrid;
            this.items.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", null, "")});
            this.items.Name = "items";
            this.items.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.items.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.items.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.items.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.items.OptionsEditForm.EditFormColumnCount = 2;
            this.items.OptionsFind.AlwaysVisible = true;
            this.items.OptionsFind.FindDelay = 100;
            this.items.OptionsFind.SearchInPreview = true;
            this.items.OptionsSelection.InvertSelection = true;
            this.items.OptionsSelection.MultiSelect = true;
            this.items.OptionsView.AllowHtmlDrawHeaders = true;
            this.items.OptionsView.EnableAppearanceEvenRow = true;
            this.items.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.items.OptionsView.ShowFooter = true;
            this.items.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.items_SelectionChanged);
            this.items.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.RowUpdated);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.itemGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BaseForm";
            this.Size = new System.Drawing.Size(957, 488);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
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
        private System.Windows.Forms.BindingSource bindingSource;
        public DevExpress.XtraGrid.GridControl itemGrid;
        public DevExpress.XtraGrid.Views.Grid.GridView items;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup orderGroup;
        private DevExpress.XtraBars.BarButtonItem btnCreateOrder;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup waybillGroup;
        public DevExpress.XtraBars.BarButtonItem btnCreateWaybill;
    }
}