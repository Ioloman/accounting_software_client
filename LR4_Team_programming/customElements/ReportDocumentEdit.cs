using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using System.Globalization;
using System.Threading;



namespace LR4_Team_programming.customElements
{
    public partial class ReportDocumentEdit : UserControl
    {
        public ReportDocumentEdit()
        {
            InitializeComponent();
        }

        IEnumerable<Report> getReportstsList()
        {
            List<Report> reports = null;
            try
            {
                reports = (List<Report>)ApiConnector.getReports();
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Отсутствует подключение к сети Интернет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Report>();
            }

            if (searchFilterBar1.isDocumentNumberChecked())
            {
                int documentNumber = searchFilterBar1.documentNumber();
                var report = reports.Find(report => report.doc_num == documentNumber);
                if (report != null)
                    reports = new List<Report> { report };
                else
                    reports.Clear();
            }
            else
            {
                if (searchFilterBar1.isDateSelected())
                {
                    DateTime date = searchFilterBar1.getDate();

                    string format = "yyyy-MM-dd";
                    reports = reports.FindAll(report =>
                    DateTime.ParseExact(report.date, format, CultureInfo.InvariantCulture) == date);
                }

                if (searchFilterBar1.isPeriodSelected())
                {
                    DateTime lowestDate = searchFilterBar1.getLowestDate();
                    DateTime highestDate = searchFilterBar1.getHighestDate();

                    string format = "yyyy-MM-dd";
                    reports = reports.FindAll(report =>
                    DateTime.ParseExact(report.date, format, CultureInfo.InvariantCulture) >= lowestDate &&
                    DateTime.ParseExact(report.date, format, CultureInfo.InvariantCulture) <= highestDate);
                }

                if (searchFilterBar1.isWorkshopChecked())
                {
                    string senderWorkshop = searchFilterBar1.getWorkshop();

                    var workshop = ApiConnector.getWorkshop(senderWorkshop);
                    reports = reports.FindAll(report => report.workshop_sender_pk == workshop.workshop_pk);
                }
            }

            return reports;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            reportsGrid.Rows.Clear();
            progressBar.Visible = true;

            Thread thread = new Thread(fillTable);
            thread.Start();
        }

        private void fillTable()
        {
            var reports = getReportstsList();
            List<int> workshops = new List<int>();
            foreach (var report in reports)
                workshops.Add(report.workshop_sender_pk);
            List<Workshop> workshopsModels = (List<Workshop>)ApiConnector.getWorkshops(workshops);

            if (reportsGrid.InvokeRequired)
            {
                reportsGrid.Invoke(new MethodInvoker(delegate
                {
                    foreach (var report in (List<Report>)reports)
                        reportsGrid.Rows.Add(report.doc_num, report.date, workshopsModels.Find(workshop => workshop.workshop_pk == report.workshop_sender_pk).workshop_name);
                    finishThread();
                }));
            }

        }

        void finishThread()
        {
            progressBar.Visible = false;
        }
    }
}
