namespace Cenk.UI.Views
{
    partial class ConfirmWaybillForm
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
            this.btnApprove = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkIsBilled = new DevExpress.XtraEditors.CheckEdit();
            this.txtWaybillNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layWaybillNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource = new System.Windows.Forms.BindingSource();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsBilled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWaybillNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layWaybillNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.AllowGlyphSkinning = false;
            this.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApprove.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("VAZGEÇ", "Cancel", DevExpress.XtraBars.Docking2010.ImageLocation.BeforeText, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, 0, true, null, true, false, true, null, null, -1, false, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(null, true, 1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("ONAYLA", "Apply", DevExpress.XtraBars.Docking2010.ImageLocation.BeforeText, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, 2, true, null, true, false, true, null, null, -1, false, false)});
            this.btnApprove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnApprove.Location = new System.Drawing.Point(0, 260);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(473, 70);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "windowsUIButtonPanel1";
            this.btnApprove.UseButtonBackgroundImages = false;
            this.btnApprove.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.btnApprove_ButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkIsBilled);
            this.layoutControl1.Controls.Add(this.txtWaybillNumber);
            this.layoutControl1.Controls.Add(this.txtCustomer);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(473, 260);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkIsBilled
            // 
            this.chkIsBilled.Location = new System.Drawing.Point(12, 60);
            this.chkIsBilled.Name = "chkIsBilled";
            this.chkIsBilled.Properties.Caption = "Fatura Kesilmiş mi";
            this.chkIsBilled.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkIsBilled.Size = new System.Drawing.Size(449, 19);
            this.chkIsBilled.StyleController = this.layoutControl1;
            this.chkIsBilled.TabIndex = 7;
            // 
            // txtWaybillNumber
            // 
            this.txtWaybillNumber.Location = new System.Drawing.Point(97, 12);
            this.txtWaybillNumber.Name = "txtWaybillNumber";
            this.txtWaybillNumber.Properties.Mask.BeepOnError = true;
            this.txtWaybillNumber.Properties.Mask.EditMask = "d";
            this.txtWaybillNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWaybillNumber.Size = new System.Drawing.Size(364, 20);
            this.txtWaybillNumber.StyleController = this.layoutControl1;
            this.txtWaybillNumber.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layWaybillNumber,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(473, 260);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCustomer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(453, 24);
            this.layoutControlItem1.Text = "Müşteri";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layWaybillNumber
            // 
            this.layWaybillNumber.Control = this.txtWaybillNumber;
            this.layWaybillNumber.Location = new System.Drawing.Point(0, 0);
            this.layWaybillNumber.Name = "layWaybillNumber";
            this.layWaybillNumber.Size = new System.Drawing.Size(453, 24);
            this.layWaybillNumber.Text = "İrsaliye Numarası";
            this.layWaybillNumber.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkIsBilled;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(453, 192);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(97, 36);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(364, 20);
            this.txtCustomer.StyleController = this.layoutControl1;
            this.txtCustomer.TabIndex = 4;
            // 
            // ConfirmWaybillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 330);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.btnApprove);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 460);
            this.MinimizeBox = false;
            this.Name = "ConfirmWaybillForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İrsaliye Oluşturma Ekranı";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkIsBilled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWaybillNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layWaybillNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnApprove;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.TextEdit txtWaybillNumber;
        private DevExpress.XtraLayout.LayoutControlItem layWaybillNumber;
        private DevExpress.XtraEditors.CheckEdit chkIsBilled;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
    }
}