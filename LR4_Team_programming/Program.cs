using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4_Team_programming
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var report = ApiConnector.getReports().ElementAt(0);
            report.report_lines.RemoveAt(0);
            var line = new Models.ReportLine();
            line.detail_pk = 1;
            line.produced = 100;
            line.workshop_receiver_pk = 1;
            report.report_lines.Add(line);
            report.report_lines.ElementAt(1).produced = 200;

            ApiConnector.editReport(report);


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
