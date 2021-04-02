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
    public partial class CalculatingBalances : UserControl
    {
        public CalculatingBalances()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            progressBar.Visible = true;

            Thread thread = new Thread(fillTable);
            thread.Start();
        }
        IEnumerable<Leftover> getLeftoversList()
        {
            List<Leftover> leftovers = null;
            try
            {
                string depName = "";
                if (depNameComboBox.InvokeRequired)
                    depNameComboBox.Invoke(new MethodInvoker(delegate
                    {
                        depName = depNameComboBox.Text;
                    }));
                var workshop = ApiConnector.getWorkshop(depName);
                if (workshop != null)
                    leftovers = (List<Leftover>)ApiConnector.getLeftovers(workshop, this.date.Value);
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Отсутствует подключение к сети Интернет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Leftover>();
            }

            return leftovers;
        }

        private void fillTable()
        {
            List<Leftover> leftovers = (List<Leftover>)getLeftoversList();

            if (table.InvokeRequired)
            {
                table.Invoke(new MethodInvoker(delegate
                {
                    foreach (var leftover in leftovers)
                        table.Rows.Add(leftover.detail_name, leftover.cipher_detail, leftover.amount);
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

