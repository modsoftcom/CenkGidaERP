﻿namespace Cenk.UI
{
    partial class Main
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
            this.listViewBase1 = new Cenk.UI.Views.Tools.ListViewBase();
            this.SuspendLayout();
            // 
            // listViewBase1
            // 
            this.listViewBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBase1.Location = new System.Drawing.Point(0, 0);
            this.listViewBase1.Name = "listViewBase1";
            this.listViewBase1.Size = new System.Drawing.Size(882, 610);
            this.listViewBase1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 610);
            this.Controls.Add(this.listViewBase1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.Tools.ListViewBase listViewBase1;
    }
}