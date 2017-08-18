using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cenk.UI.Model
{
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
            return string.Format("MÜŞTERİ BİLGİLERİ\nAdı\t:{0}\nAdres\t:{1}\nV.No\t:{2}({3}", Name, Address, TaxNo, TaxPlace);
        }
    }

    //public class WhatHeBuys
    //{
    //    [Display(Name = "Şişe")]
    //    public bool Bottle { get; set; }
    //    [Display(Name = "Özer Hisar")]
    //    public bool OH { get; set; }
    //    [Display(Name = "Çayır Hisar")]
    //    public bool CH { get; set; }
    //    [Display(Name = "Tombik")]
    //    public bool Tombik { get; set; }
    //    [Display(Name = "İadesiz")]
    //    public bool NonDeposit { get; set; }
    //}
}
