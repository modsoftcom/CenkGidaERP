using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cenk.UI.Model
{
    [DisplayName("Müşteriler")]
    public class Customer
    {
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Vergi Dairesi")]
        public string TaxPlace { get; set; }

        [Display(Name = "Vergi No")]
        public string TaxNo { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime DateCreated { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    
}
