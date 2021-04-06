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
    public partial class DeviationAnalysis : UserControl
    {
        public DataGridView GetTable
        {
            get
            {
                return table;
            }
        }

        public DateTimePicker GetDocStartDate
        {
            get
            {
                return startDate;
            }
        }
        public DateTimePicker GetDocEndDate
        {
            get
            {
                return endDate;
            }
        }

        public ComboBox GetDepComboBox
        {
            get
            {
                return depComboBox;
            }
        }








        public ComboBox.ObjectCollection depNameComboBoxItems
        {
            get
            {
                return this.depComboBox.Items;
            }
            set
            {
                depComboBox.Items.Clear();
                depComboBox.Items.Add(value);
            }
        }



        bool downMove = true;
        public DeviationAnalysis()
        {
            InitializeComponent();
            depComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            table.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            table.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

        }

        private void searchInAllDebCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            depComboBox.Enabled = !searchInAllDebCheckBox.Checked;

        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            // 17; 207 - старт
            // 17; 359 - финиш
            extraSettingPanel.Visible = true;
            timerForShiftingTable.Enabled = true;
            timerForShiftingTable.Interval = 10;
        }

        private void timerForShiftingTable_Tick(object sender, EventArgs e)
        {
            if (downMove)
            {
                table.Location = new Point(table.Location.X, table.Location.Y + 2);
                if (table.Location.Y >= 376)
                {
                    timerForShiftingTable.Enabled = false;
                    downMove = false;
                }
            }
            else
            {
                table.Location = new Point(table.Location.X, table.Location.Y - 2);
                if (table.Location.Y <= 239)
                {
                    timerForShiftingTable.Enabled = false;
                    downMove = true;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            progressBar.Visible = true;
            UseWaitCursor = true;
            Thread thread = new Thread(fillTable);
            thread.Start();
        }
        IEnumerable<Accounting> getAccounting()
        {
            List<Accounting> accountings = null;
            try
            {
                string depName = "";
                if (depComboBox.InvokeRequired)
                    depComboBox.Invoke(new MethodInvoker(delegate
                    {
                        depName = depComboBox.Text;
                    }));
                var workshop = ApiConnector.getWorkshop(depName);
                if (workshop != null)
                    accountings = (List<Accounting>)ApiConnector.getAccountings(workshop, this.startDate.Value, this.endDate.Value);
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Отсутствует подключение к сети Интернет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Accounting>();
            }

            return accountings;
        }

        private void fillTable()
        {
            List<Accounting> accountings = (List<Accounting>)getAccounting();

            if (table.InvokeRequired)
            {
                table.Invoke(new MethodInvoker(delegate
                {
                    foreach (var accounting in accountings)
                        table.Rows.Add(accounting.detail_name, accounting.cipher_detail, accounting.planned_amount, accounting.actual_amount, accounting.deviation);
                    finishThread();
                }));
            }

        }

        void finishThread()
        {
            progressBar.Visible = false;
            UseWaitCursor = false;
        }

        private void table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            this.progressBar.Visible = true;

            DataGridView table = GetTable;
            string startDate = GetDocStartDate.Text;
            string endDate = GetDocEndDate.Text;
            string dep = GetDepComboBox.Text;

            List<List<string>> data = new List<List<string>>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                data.Add(new List<string>());
                data[i].Add((i + 1).ToString());
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    try
                    {
                        data[i].Add(table.Rows[i].Cells[j].Value.ToString());
                    }
                    catch { };
                }
            }

            Thread thread = new Thread((s) =>
            {
                showPrintForm(dep, startDate, endDate, data);
                this.progressBar.BeginInvoke((MethodInvoker)(() => this.progressBar.Visible = false));

            });
            thread.Start();
        }
        private void showPrintForm(string dep, string startDate, string endDate, List<List<string>> data)
        {
            string path = Program.GetPathToTemplatesFolder() + "summary accounting template.docx";
            docViewerForm docViewerForm = new docViewerForm(dep, startDate, endDate, data, path);

            docViewerForm.ShowDialog();
        }
    }
}
