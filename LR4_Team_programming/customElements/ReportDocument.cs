using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Models;

namespace LR4_Team_programming.customElements
{
    public partial class ReportDocument : UserControl
    {
        public ReportDocument()
        {
            InitializeComponent();
        }

        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            var workshop = ApiConnector.getWorkshop(senderTextBox.Text);
            if (workshop == null)
            {
                MessageBox.Show("Цех с таким названием не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Detail> details = (List<Detail>)ApiConnector.getDetails();
            List<Workshop> workshops = (List<Workshop>)ApiConnector.getWorkshops(); 
            report.date = creationDate.Value.ToString("yyyy-MM-dd");
            report.doc_num = Convert.ToInt32(docNumber.Text);
            report.workshop_sender_pk = workshop.workshop_pk;
            report.report_lines = new List<ReportLine>();
            for (int i = 0; i < productsGrid.Rows.Count - 1; i++)
            {
                var reportLine = new ReportLine();
                reportLine.detail_pk = details.Find(detail => detail.detail_name == productsGrid.Rows[i].Cells[0].Value.ToString()).detail_pk;
                reportLine.workshop_receiver_pk = workshops.Find(workshop => workshop.workshop_name == productsGrid.Rows[i].Cells[3].Value.ToString()).workshop_pk;
                report.report_lines.Add(reportLine);
            }
            ApiConnector.createReport(report);
            MessageBox.Show("Report успешное создать!\n +1500 social_credits великий Xi гордится тобой!", "Поздравлений!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
