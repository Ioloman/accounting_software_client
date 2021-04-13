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
        public List<Report> reports;
        public List<Detail> details;
        public List<Workshop> workshops;
        private Report editingReport;
        private int indexEditingReport;

        public AutoCompleteStringCollection AutoCompleteSourceForDocNum
        {
            get
            {
                return searchFilterBar1.AutoCompleteSourceForDocNum;
            }
        }


        public ComboBox.ObjectCollection depNameComboBoxItems
        {
            get
            {
                return searchFilterBar1.depNameComboBoxItems;
            }
        }
        public ReportDocumentEdit()
        {
            InitializeComponent();
            reportsGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            reportsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
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
            reports = (List<Report>)getReportstsList();
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
                    
                    AutoCompleteSourceForDocNum.Clear();
                    foreach (Report report in reports)
                        AutoCompleteSourceForDocNum.Add(report.doc_num.ToString());
                    finishThread();
                }));
            }

        }

        void finishThread()
        {
            progressBar.Visible = false;
        }

        private void reportsGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < reportsGrid.Rows.Count; i++)
                reportsGrid.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }

        private void reportsGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = imageList1.Images[0].Width;
                var h = imageList1.Images[0].Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(imageList1.Images[0], new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = imageList1.Images[1].Width;
                var h = imageList1.Images[1].Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(imageList1.Images[1], new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void reportsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                // удалить здесь
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить рапорт №" +
                   reportsGrid.CurrentRow.Cells[0].Value.ToString() + "?", "Удаление", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    int index = e.RowIndex;
                    ApiConnector.deleteReport(reports[index]);
                    reports.RemoveAt(index);
                    AutoCompleteSourceForDocNum.RemoveAt(index);
                    reportsGrid.Rows.RemoveAt(index);
                    MessageBox.Show("Рапорт был успешно удален.", "Удаление рапорта",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }


            }
            if (e.ColumnIndex == 3)
            {
                var identificationTable = new Dictionary<DataGridViewRow, ReportLine>();

                // открыть форму для редактирования рапорта

                Report currReport = reports.Find(report => reportsGrid.CurrentRow.Cells[0].Value.ToString() == report.doc_num.ToString());
                editingReport = currReport;
                indexEditingReport = e.RowIndex;

                EditingReportForm editingReportForm = new EditingReportForm(currReport);
                ReportDocument reportDocument = editingReportForm.GetPanel;

                reportDocument.GetDocCreationTime.Value = DateTime.Parse(currReport.date);
                reportDocument.GetDocNumberTextBox = currReport.doc_num.ToString();

                for (int i = 0; i < depNameComboBoxItems.Count; i++)
                    reportDocument.GetDepSender.Items.Add(depNameComboBoxItems[i]);
                string workshopName = ApiConnector.getWorkshop(currReport.workshop_sender_pk).workshop_name;
                int index = depNameComboBoxItems.IndexOf(workshopName);
                reportDocument.GetDepSender.SelectedIndex = index;

                DataGridView table = reportDocument.GetTable;
                table.AllowUserToAddRows = false;         
                reportDocument.SetDetails = details;

                foreach (var workshop in workshops)
                    (table.Columns[3] as DataGridViewComboBoxColumn).Items.Add(workshop.workshop_name);

                for (int i = 0; i < currReport.report_lines.Count; i++)
                {
                    table.Rows.Add();
                    table.Rows[i].Cells[1].Value = currReport.report_lines[i].detail.cipher_detail;
                    table.Rows[i].Cells[2].Value = currReport.report_lines[i].produced.ToString();
                    (table.Rows[i].Cells[0]).Value = currReport.report_lines[i].detail.detail_name;
                    table.Rows[i].Cells[3].Value = 
                       workshops.Find(workshop => workshop.workshop_pk == currReport.report_lines[i].workshop_receiver_pk).workshop_name;
                    identificationTable.Add(table.Rows[i], currReport.report_lines[i]);
                }
                reportDocument.identificationTable = identificationTable;
                table.AllowUserToAddRows = true;
                editingReportForm.Show();
                editingReportForm.FormClosed += new FormClosedEventHandler(refreshFunc);
            }
        }
        private void refreshFunc(object sender, FormClosedEventArgs e)
        {

            Report NewReport = ApiConnector.getReport(editingReport);
            reportsGrid.Rows[indexEditingReport].Cells[0].Value = NewReport.doc_num;
            reportsGrid.Rows[indexEditingReport].Cells[1].Value = NewReport.date;
            reportsGrid.Rows[indexEditingReport].Cells[2].Value = workshops.Find(workshops => workshops.workshop_pk == NewReport.workshop_sender_pk).workshop_name.ToString();
            reports[reports.IndexOf(editingReport)] = NewReport;


            //reportsGrid.Rows.Clear();
            //progressBar.Visible = true;
            //Thread thread = new Thread(fillTable);
            //thread.Start();
        }
    }
}
