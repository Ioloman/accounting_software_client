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
        public DataGridView GetTable
        {
            get
            {
                return productsGrid;
            }
        }
        public TextBox GetDocNumberTextBox
        {
            get
            {
                return docNumber;
            }
        }
        public DateTimePicker GetDocCreationTime
        {
            get
            {
                return creationDate;
            }
        }

        public ComboBox GetDepSender
        {
            get
            {
                return senderComboBox;
            }
        }
        List<Detail> details = new List<Detail>();
        public List<Detail> SetDetails
        {
            set
            {
                details.Clear();
                foreach (Detail detail in value)
                    details.Add(detail);
                List<string> detailsNames = new List<string>();
                foreach (Detail detail in details)
                    detailsNames.Add(detail.detail_name);
                (productsGrid.Columns[0] as DataGridViewComboBoxColumn).Items.Clear();
                foreach (string str in detailsNames)
                    (productsGrid.Columns[0] as DataGridViewComboBoxColumn).Items.Add(str);
            }
        }

        public ComboBox.ObjectCollection depNameComboBoxItems
        {
            get
            {
                return senderComboBox.Items;
            }
        }

        public  DataGridViewComboBoxCell.ObjectCollection depComboBoxItemsInTable
        {
            get
            {
                return (productsGrid.Columns[3] as DataGridViewComboBoxColumn).Items;
            }
        }

        public ReportDocument()
        {
            InitializeComponent();
            senderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productsGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            productsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            productsGrid.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(productsGrid_EditingControlShowing);
        }


        void productsGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                // вставить массу в сырье
                if ((sender as DataGridView).CurrentCell.ColumnIndex == 0)          
                    (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(InsertCodeOKP);               
            }
            catch { }
        }
        private void InsertCodeOKP(object sender, EventArgs e)
        {
            try
            {
                if ((sender as ComboBox) != null)
                    if (productsGrid.CurrentCell.ColumnIndex == 0)
                        if ((sender as ComboBox).SelectedIndex != -1)
                            productsGrid.CurrentRow.Cells[1].Value = details[(sender as ComboBox).SelectedIndex].cipher_detail;
            }
            catch { };
        }
        private void savingProccessing()
        {
            Report report = new Report();
            var workshop = ApiConnector.getWorkshop(senderComboBox.Text);
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
                reportLine.produced = Convert.ToInt32(productsGrid.Rows[i].Cells[2].Value);
                reportLine.workshop_receiver_pk = workshops.Find(workshop => workshop.workshop_name == productsGrid.Rows[i].Cells[3].Value.ToString()).workshop_pk;
                report.report_lines.Add(reportLine);
            }
            if (Parent is EditingReportForm)
            {
                report.url = (Parent as EditingReportForm).reportLast.url;
                ApiConnector.editReport(report);
                MessageBox.Show("Рапорт был успешно изменен.", "Редактирование рапорта", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ApiConnector.createReport(report);
                MessageBox.Show("Рапорт был успешно создан.", "Добавление рапорта", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            progressBar1.Visible = false;
        }


        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            Thread saveThread = new Thread(savingProccessing);
            progressBar1.Visible = true;
            saveThread.Start();

        }

        private void productsGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < productsGrid.Rows.Count - 1; i++)
                productsGrid.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }

        private void reportPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
