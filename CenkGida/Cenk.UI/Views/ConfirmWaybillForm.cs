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
using Cenk.UI.Model;
using DevExpress.XtraLayout;
using Cenk.UI.Utils;

namespace Cenk.UI.Views
{
    public partial class ConfirmWaybillForm : DevExpress.XtraEditors.XtraForm
    {
        public Dictionary<Product, int> Entries { get; set; }
        public List<Waybill> Waybills { get; set; }
        public Customer Customer { get; set; }
        public ConfirmWaybillForm(Customer customer, List<Product> Products)
        {
            InitializeComponent();
            Customer = customer;
            Entries = new Dictionary<Product, int>();
            List<BaseLayoutItem> controls = new List<BaseLayoutItem>();
            List<NumericUpDown> numbers = new List<NumericUpDown>();
            foreach (Product product in Products)
            {
                LayoutControlItem layControl = new LayoutControlItem();
                NumericUpDown number = new NumericUpDown();
                layControl.Text = product.ToString();
                number.Minimum = number.Value = 1;
                number.Tag = product;
                number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                number.ValueChanged += Number_ValueChanged;
                layControl.Control = number;
                Entries.Add(product, 1);
                numbers.Add(number);
                controls.Add(layControl);
            }
            this.layoutControlGroup1.Items.AddRange(controls.ToArray());
            txtCustomer.Text = customer.Name;
        }

        private void Number_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown number = sender as NumericUpDown;
            Product product = number.Tag as Product;
            Entries[product] = (int)number.Value;
        }

        private void btnApprove_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.VisibleIndex == 2)
            {
                if (Utilities.areNotNull(txtWaybillNumber.Text))
                {
                    Waybills = new List<Waybill>();
                    foreach (var entry in Entries)
                    {
                        Waybills.Add(new Waybill(
                            txtWaybillNumber.Text,
                            Customer,
                            entry.Key,
                            entry.Value,
                            chkIsBilled.Checked
                            ));
                    }
                    Close();
                }else
                {
                    MessageBox.Show("İrsaliye numarası boş olamaz.", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txtWaybillNumber.BackColor = layWaybillNumber.AppearanceItemCaption.BackColor = Color.PaleVioletRed;
                    
                }
            }
            else if (e.Button.Properties.VisibleIndex == 1)
            {
                Close();
            }
        }
    }
}