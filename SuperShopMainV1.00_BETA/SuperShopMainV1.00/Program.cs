using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Contributor Name: Alimul Mahfuz Tushar
 * ID:19-39831-1*/
namespace SuperShopMainV1._00
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  //thread one
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoagingScreenFlashCard());
        }
    }
}
