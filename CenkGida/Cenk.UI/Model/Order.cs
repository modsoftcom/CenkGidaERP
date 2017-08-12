using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenk.UI.Model
{
    public class Order
    {
        public Order()
        {
            Waybills = new List<Waybill>();
        }
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Müşteri")]
        public Customer Customer { get; set; }

        [Display(Name = "İrsaliyeler")]
        public List<Waybill> Waybills { get; set; }

        [Display(Name = "Tarih")]
        public DateTime DateCreated { get; set; }
    }
}
