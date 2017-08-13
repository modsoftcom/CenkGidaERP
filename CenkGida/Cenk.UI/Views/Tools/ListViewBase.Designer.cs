namespace Cenk.UI.Views.Tools
{
    partial class ListViewBase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewBase));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetails = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPDF = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.content = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.Müşteriler = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customerList = new Cenk.UI.Views.Customer.CustomerList();
            this.Ürünler = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.productList = new Cenk.UI.Views.Product.ProductList();
            this.İrsaliyeler = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.waybillList = new Cenk.UI.Views.Waybill.WaybillList();
            this.Faturalar = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.orderList = new Cenk.UI.Views.Order.OrderList();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.content)).BeginInit();
            this.content.SuspendLayout();
            this.Müşteriler.SuspendLayout();
            this.Ürünler.SuspendLayout();
            this.İrsaliyeler.SuspendLayout();
            this.Faturalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNew,
            this.btnDetails,
            this.btnEdit,
            this.btnDelete,
            this.btnPreview,
            this.btnPrint,
            this.btnExcel,
            this.btnPDF});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(783, 139);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "Ekle";
            this.btnNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNew.Glyph")));
            this.btnNew.Id = 1;
            this.btnNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNew.LargeGlyph")));
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnDetails
            // 
            this.btnDetails.Caption = "Detay Görüntüle";
            this.btnDetails.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDetails.Glyph")));
            this.btnDetails.Id = 2;
            this.btnDetails.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDetails.LargeGlyph")));
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetails_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Düzenle";
            this.btnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.Glyph")));
            this.btnEdit.Id = 3;
            this.btnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.LargeGlyph")));
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Sil";
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 5;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            // 
            // btnPreview
            // 
            this.btnPreview.Caption = "Önizleme";
            this.btnPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPreview.Glyph")));
            this.btnPreview.Id = 6;
            this.btnPreview.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPreview.LargeGlyph")));
            this.btnPreview.Name = "btnPreview";
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Yazdır";
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.Glyph")));
            this.btnPrint.Id = 7;
            this.btnPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.LargeGlyph")));
            this.btnPrint.Name = "btnPrint";
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Excele Aktar";
            this.btnExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExcel.Glyph")));
            this.btnExcel.Id = 8;
            this.btnExcel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExcel.LargeGlyph")));
            this.btnExcel.Name = "btnExcel";
            // 
            // btnPDF
            // 
            this.btnPDF.Caption = "PDFe Aktar";
            this.btnPDF.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPDF.Glyph")));
            this.btnPDF.Id = 9;
            this.btnPDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPDF.LargeGlyph")));
            this.btnPDF.Name = "btnPDF";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kayıt İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDetails);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Çıktı İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPreview);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnExcel);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPDF);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 598);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.NavigationClient = this.content;
            this.officeNavigationBar1.Size = new System.Drawing.Size(783, 45);
            this.officeNavigationBar1.TabIndex = 1;
            this.officeNavigationBar1.ItemClick += new DevExpress.XtraBars.Navigation.NavigationBarItemClickEventHandler(this.officeNavigationBar1_ItemClick);
            // 
            // content
            // 
            this.content.Controls.Add(this.Müşteriler);
            this.content.Controls.Add(this.Ürünler);
            this.content.Controls.Add(this.İrsaliyeler);
            this.content.Controls.Add(this.Faturalar);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 139);
            this.content.Name = "content";
            this.content.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Müşteriler,
            this.Ürünler,
            this.İrsaliyeler,
            this.Faturalar});
            this.content.SelectedPage = this.Müşteriler;
            this.content.Size = new System.Drawing.Size(783, 459);
            this.content.TabIndex = 2;
            this.content.Text = "navigationFrame1";
            // 
            // Müşteriler
            // 
            this.Müşteriler.Caption = "Müşteriler";
            this.Müşteriler.Controls.Add(this.customerList);
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.Size = new System.Drawing.Size(783, 459);
            // 
            // customerList
            // 
            this.customerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerList.Location = new System.Drawing.Point(0, 0);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(783, 459);
            this.customerList.TabIndex = 0;
            // 
            // Ürünler
            // 
            this.Ürünler.Caption = "Ürünler";
            this.Ürünler.Controls.Add(this.productList);
            this.Ürünler.Name = "Ürünler";
            this.Ürünler.Size = new System.Drawing.Size(783, 459);
            // 
            // productList
            // 
            this.productList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productList.Location = new System.Drawing.Point(0, 0);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(783, 459);
            this.productList.TabIndex = 0;
            // 
            // İrsaliyeler
            // 
            this.İrsaliyeler.Caption = "İrsaliyeler";
            this.İrsaliyeler.Controls.Add(this.waybillList);
            this.İrsaliyeler.Name = "İrsaliyeler";
            this.İrsaliyeler.Size = new System.Drawing.Size(783, 459);
            // 
            // waybillList
            // 
            this.waybillList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waybillList.Location = new System.Drawing.Point(0, 0);
            this.waybillList.Name = "waybillList";
            this.waybillList.Size = new System.Drawing.Size(783, 459);
            this.waybillList.TabIndex = 0;
            // 
            // Faturalar
            // 
            this.Faturalar.Caption = "Faturalar";
            this.Faturalar.Controls.Add(this.orderList);
            this.Faturalar.Name = "Faturalar";
            this.Faturalar.Size = new System.Drawing.Size(783, 459);
            // 
            // orderList
            // 
            this.orderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderList.Location = new System.Drawing.Point(0, 0);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(783, 459);
            this.orderList.TabIndex = 0;
            // 
            // ListViewBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.content);
            this.Controls.Add(this.officeNavigationBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ListViewBase";
            this.Size = new System.Drawing.Size(783, 643);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.content)).EndInit();
            this.content.ResumeLayout(false);
            this.Müşteriler.ResumeLayout(false);
            this.Ürünler.ResumeLayout(false);
            this.İrsaliyeler.ResumeLayout(false);
            this.Faturalar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDetails;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnPreview;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnPDF;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationFrame content;
        private DevExpress.XtraBars.Navigation.NavigationPage Müşteriler;
        private DevExpress.XtraBars.Navigation.NavigationPage Ürünler;
        private Customer.CustomerList customerList;
        private Product.ProductList productList;
        private DevExpress.XtraBars.Navigation.NavigationPage İrsaliyeler;
        private Waybill.WaybillList waybillList;
        private DevExpress.XtraBars.Navigation.NavigationPage Faturalar;
        private Order.OrderList orderList;
    }
}
