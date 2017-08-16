using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenk.UI.Model
{
    public class Log
    {
        public Log(Exception ex)
        {
            this.Exception = ex;
            this.DateCreated = DateTime.Now;
        }
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Hata")]
        public Exception Exception { get; set; }        

        [Display(Name = "Eklenme Tarihi")]
        public DateTime DateCreated { get; set; }

        public override string ToString()
        {
            if (Exception.InnerException != null)
            {
                return Exception.ToString() + "\n" + Exception.InnerException.ToString();
            }
            else
            {
                return Exception.ToString();
            }
        }
    }
}
