using Cenk.UI.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cenk.UI.Utils
{
    public static class Logger
    {
        public static void Add(Exception e)
        {
            Service<Log>.AddOrUpdate(new Log(e));
            MessageBox.Show("Lütfen, yazılımcı firma ile irtibata geçiniz.\n" +
                "\n" + e.Message +
                "\n" + e.StackTrace.Split(')').First().TrimStart() + ")" +
                "\n" + e.StackTrace.Split(')').Last()
                , "Hata Oluştu!");
        }
    }
}
