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
        public ComboBox.ObjectCollection depNameComboBoxItems
        {
            get
            {
                return this.depNameComboBox.Items;
            }
            set
            {
                depNameComboBox.Items.Clear();
                depNameComboBox.Items.Add(value);
            }
        }
            


        public CalculatingBalances()
        {
            InitializeComponent();
            depNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            table.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            table.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

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

        private void table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }
    }
}

