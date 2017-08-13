namespace Cenk.UI.Views.Product
{
    partial class ProductList
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
            this.components = new System.ComponentModel.Container();
            this.gridProducts = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeposit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViolCapacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridProducts.DataSource = this.productBindingSource;
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProducts.Location = new System.Drawing.Point(0, 0);
            this.gridProducts.MainView = this.products;
            this.gridProducts.Name = "gridControl1";
            this.gridProducts.Size = new System.Drawing.Size(913, 764);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.products});
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Cenk.UI.Model.Product);
            // 
            // gridView1
            // 
            this.products.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colBrand,
            this.colTitle,
            this.colDeposit,
            this.colViolCapacity,
            this.colGsm,
            this.colUnit,
            this.colStockType,
            this.colDateCreated});
            this.products.GridControl = this.gridProducts;
            this.products.Name = "gridView1";
            this.products.OptionsBehavior.Editable = true;
            this.products.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.products.OptionsView.EnableAppearanceEvenRow = true;
            this.products.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // colNo
            // 
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colBrand
            // 
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 1;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 2;
            // 
            // colDeposit
            // 
            this.colDeposit.FieldName = "Deposit";
            this.colDeposit.Name = "colDeposit";
            this.colDeposit.Visible = true;
            this.colDeposit.VisibleIndex = 3;
            // 
            // colViolCapacity
            // 
            this.colViolCapacity.FieldName = "ViolCapacity";
            this.colViolCapacity.Name = "colViolCapacity";
            this.colViolCapacity.Visible = true;
            this.colViolCapacity.VisibleIndex = 4;
            // 
            // colGsm
            // 
            this.colGsm.FieldName = "Gsm";
            this.colGsm.Name = "colGsm";
            this.colGsm.Visible = true;
            this.colGsm.VisibleIndex = 5;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 6;
            // 
            // colStockType
            // 
            this.colStockType.FieldName = "StockType";
            this.colStockType.Name = "colStockType";
            this.colStockType.Visible = true;
            this.colStockType.VisibleIndex = 7;
            // 
            // colDateCreated
            // 
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 8;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridProducts);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(913, 764);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraGrid.Views.Grid.GridView products;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colDeposit;
        private DevExpress.XtraGrid.Columns.GridColumn colViolCapacity;
        private DevExpress.XtraGrid.Columns.GridColumn colGsm;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colStockType;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        public DevExpress.XtraGrid.GridControl gridProducts;
    }
}
