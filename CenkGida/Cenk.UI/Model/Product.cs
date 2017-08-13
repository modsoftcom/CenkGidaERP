using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cenk.UI.Model
{
    public class Product
    {
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "No")]
        public int No { get; set; }

        [Display(Name = "Marka")]
        public string Brand { get; set; }

        [Display(Name = "Adı")]
        public string Title { get; set; }

        [Display(Name = "Depozito Durumu")]
        public bool Deposit { get; set; }

        [Display(Name = "Viyol Kapasitesi"), MaxLength(100, ErrorMessage = "Viyol kapasitesi maksimum 100 olabilir.")]
        public int ViolCapacity { get; set; }

        [Display(Name = "Gramaj")]
        public int Gsm { get; set; }

        [Display(Name = "Ölçü Birimi")]
        public string Unit { get; set; }

        [Display(Name = "Stok Türü")]
        public string StockType { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime DateCreated { get; set; }

        public override string ToString()
        {
            string no = No < 10 ? "0" + No : No.ToString();
            string deposit = Deposit ? "Depozitolu" : "İadesiz";
            string violEki = "";
            int option = ViolCapacity % 10 == 0 ? ViolCapacity : ViolCapacity % 10;
            switch (option)
            {
                case 1:
                case 2:
                case 5:
                case 7:
                case 8:
                case 20:
                case 50:
                case 70:
                case 80:
                    violEki = "'li";
                    break;
                case 3:
                case 4:
                case 100:
                    violEki = "'lü";
                    break;
                case 6:
                case 40:
                case 60:
                case 90:
                    violEki = "'lı";
                    break;
                case 9:
                case 10:
                case 30:
                    violEki = "'lu";
                    break;
                default:
                    break;
            }

            return string.Format("{0} {1} {2} ({3}{4} Viyol, {5}) {6} {7}", no, Brand, Title, ViolCapacity, violEki, deposit, Gsm, Unit);
        }

    }
}
