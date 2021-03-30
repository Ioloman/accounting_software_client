using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LR4_Team_programming
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            string format = "yyyy-MM-dd";
            var result = DateTime.ParseExact("2020-12-22", format, CultureInfo.InvariantCulture);





            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
