using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenk.UI.Model
{
    public class Waybill
    {
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

        [Display(Name =  "Tarih")]
        public DateTime DateCreated { get; set; }
    }
}
