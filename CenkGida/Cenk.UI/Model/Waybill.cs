using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenk.UI.Model
{
    [DisplayName("İrsaliyalar")]
    public class Waybill
    {
        public Waybill()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">İrsale Numarası</param>
        /// <param name="customer">Müşteri</param>
        /// <param name="product">Ürün</param>
        /// <param name="quantity">Miktar</param>
        /// <param name="isBilled">Faturalandırılmış mı?</param>
        public Waybill(string number, Customer customer, Product product, int quantity, bool isBilled)
        {
            this.WaybillNumber = number;
            this.Customer = customer;
            this.Product = product;
            this.Quantity = quantity;
            this.IsBilled = isBilled;
        }
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "İsraliye Numarası")]
        public string WaybillNumber { get; set; }

        [Display(Name = "Müşteri")]
        public Customer Customer { get; set; }

        [Display(Name = "Ürün")]
        public Product Product { get; set; }

        [Display(Name = "Miktar")]
        public int Quantity { get; set; }

        [Display(Name = "Faturalanmış mı?")]
        public bool IsBilled { get; set; }

        [Display(Name =  "Tarih")]
        public DateTime DateCreated { get; set; }
    }
}
