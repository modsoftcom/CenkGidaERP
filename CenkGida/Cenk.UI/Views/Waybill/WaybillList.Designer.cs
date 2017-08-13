namespace Cenk.UI.Views.Waybill
{
    partial class WaybillList
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
            this.waybillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridWaybills = new DevExpress.XtraGrid.GridControl();
            this.waybills = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWaybillNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.waybillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWaybills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybills)).BeginInit();
            this.SuspendLayout();
            // 
            // waybillBindingSource
            // 
            this.waybillBindingSource.DataSource = typeof(Cenk.UI.Model.Waybill);
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(906, 725);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridWaybills.DataSource = this.waybillBindingSource;
            this.gridWaybills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWaybills.Location = new System.Drawing.Point(0, 0);
            this.gridWaybills.MainView = this.waybills;
            this.gridWaybills.Name = "gridControl1";
            this.gridWaybills.Size = new System.Drawing.Size(906, 725);
            this.gridWaybills.TabIndex = 0;
            this.gridWaybills.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.waybills});
            // 
            // gridView1
            // 
            this.waybills.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWaybillNumber,
            this.colCustomer,
            this.colProduct,
            this.colQuantity,
            this.colDateCreated});
            this.waybills.GridControl = this.gridWaybills;
            this.waybills.Name = "gridView1";
            this.waybills.OptionsBehavior.Editable = true;
            this.waybills.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.waybills.OptionsView.EnableAppearanceEvenRow = true;
            this.waybills.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // colWaybillNumber
            // 
            this.colWaybillNumber.FieldName = "WaybillNumber";
            this.colWaybillNumber.Name = "colWaybillNumber";
            this.colWaybillNumber.Visible = true;
            this.colWaybillNumber.VisibleIndex = 0;
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            // 
            // colProduct
            // 
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 2;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            // 
            // colDateCreated
            // 
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 4;
            // 
            // WaybillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridWaybills);
            this.Name = "WaybillList";
            this.Size = new System.Drawing.Size(906, 725);
            ((System.ComponentModel.ISupportInitialize)(this.waybillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWaybills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource waybillBindingSource;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        public DevExpress.XtraGrid.Views.Grid.GridView waybills;
        private DevExpress.XtraGrid.Columns.GridColumn colWaybillNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        public DevExpress.XtraGrid.GridControl gridWaybills;
    }
}
