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
        bool downMove = true;
        public DeviationAnalysis()
        {
            InitializeComponent();
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
                if (table.Location.Y >= 359)
                {
                    timerForShiftingTable.Enabled = false;
                    downMove = false;
                }
            }
            else
            {
                table.Location = new Point(table.Location.X, table.Location.Y - 2);
                if (table.Location.Y <= 207)
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
        }
    }
}
