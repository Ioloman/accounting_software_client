using System;

using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LR4_Team_programming
{
    public static class Program
    {

        [STAThreadAttribute]
        static void Main()
        {
            string format = "yyyy-MM-dd";
            var result = DateTime.ParseExact("2020-12-22", format, CultureInfo.InvariantCulture);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
        public static string GetPathToTemplatesFolder()
        {
            string path = Environment.CurrentDirectory;
            short countSlash = 0;
            int curIndex;
            for (curIndex = path.Length - 1; curIndex > 0; curIndex--)
            {
                if (path[curIndex] == '\\')
                    countSlash++;
                if (countSlash == 3)
                    break;
            }
            path = path.Substring(0, curIndex);
            path = path + "\\" + "document templates\\";
            path = path.Replace("Source", "source").Replace("Repos", "repos");
            return path;
        }

    }
}
