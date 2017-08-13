namespace Cenk.UI.Views.Order
{
    partial class OrderList
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.waybills = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWaybillNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOrders = new DevExpress.XtraGrid.GridControl();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWaybillsCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.waybills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.waybills.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWaybillNumber1,
            this.colDateCreated1,
            this.colProduct,
            this.colQuantity});
            this.waybills.GridControl = this.gridOrders;
            this.waybills.Name = "gridView2";
            this.waybills.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.waybills.OptionsBehavior.Editable = true;
            this.waybills.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.waybills.OptionsView.EnableAppearanceEvenRow = true;
            this.waybills.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // colWaybillNumber1
            // 
            this.colWaybillNumber1.FieldName = "WaybillNumber";
            this.colWaybillNumber1.Name = "colWaybillNumber1";
            this.colWaybillNumber1.Visible = true;
            this.colWaybillNumber1.VisibleIndex = 0;
            // 
            // colDateCreated1
            // 
            this.colDateCreated1.FieldName = "DateCreated";
            this.colDateCreated1.Name = "colDateCreated1";
            this.colDateCreated1.Visible = true;
            this.colDateCreated1.VisibleIndex = 1;
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
            // gridOrders
            // 
            this.gridOrders.DataSource = this.orderBindingSource;
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.waybills;
            gridLevelNode1.RelationName = "Waybills";
            this.gridOrders.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridOrders.Location = new System.Drawing.Point(0, 0);
            this.gridOrders.MainView = this.orders;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(870, 601);
            this.gridOrders.TabIndex = 0;
            this.gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.orders,
            this.waybills});
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Cenk.UI.Model.Order);
            // 
            // gridView1
            // 
            this.orders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer,
            this.colWaybillsCount,
            this.colDateCreated});
            this.orders.GridControl = this.gridOrders;
            this.orders.Name = "gridView1";
            this.orders.OptionsBehavior.Editable = true;
            this.orders.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.orders.OptionsView.EnableAppearanceEvenRow = true;
            this.orders.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 0;
            // 
            // colWaybillsCount
            // 
            this.colWaybillsCount.Caption = "İrsaliye Sayısı";
            this.colWaybillsCount.FieldName = "Waybills";
            this.colWaybillsCount.Name = "colWaybillsCount";
            this.colWaybillsCount.Visible = true;
            this.colWaybillsCount.VisibleIndex = 1;
            // 
            // colDateCreated
            // 
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 2;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridOrders);
            this.Name = "OrderList";
            this.Size = new System.Drawing.Size(870, 601);
            ((System.ComponentModel.ISupportInitialize)(this.waybills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraGrid.Views.Grid.GridView orders;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private System.Windows.Forms.BindingSource orderBindingSource;
        public DevExpress.XtraGrid.Views.Grid.GridView waybills;
        private DevExpress.XtraGrid.Columns.GridColumn colWaybillNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colWaybillsCount;
        public DevExpress.XtraGrid.GridControl gridOrders;
    }
}
