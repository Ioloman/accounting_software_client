﻿using System;
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
        public DataGridView GetTable
        {
            get
            {
                return table;
            }
        }

        public DateTimePicker GetDocCreateDate
        {
            get
            {
                return date;
            }
        }
        public ComboBox GetDepComboBox
        {
            get
            {
                return depNameComboBox;
            }
        }


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
            UseWaitCursor = true;
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
            string dep = GetDepComboBox.Text;
            string createDate = GetDocCreateDate.Text;
            string docNum = String.Empty;

            List<List<string>> data = new List<List<string>>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                data.Add(new List<string>());
                data[i].Add((i + 1).ToString());
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    data[i].Add(table.Rows[i].Cells[j].Value.ToString());
                }
            }

            Thread thread = new Thread((s) =>
            {
                showPrintForm(dep, createDate, docNum, data);
                this.progressBar.BeginInvoke((MethodInvoker)(() => this.progressBar.Visible = false));

            });
            thread.Start();
        }

        private void showPrintForm(string dep, string createDate, string docNum, List<List<string>> data)
        {
            string path = Program.GetPathToTemplatesFolder() + "calculating balances template.docx";
            docViewerForm docViewerForm = new docViewerForm(docNum, dep, createDate, data, mainForm.docTypes.balances, path);
            docViewerForm.ShowDialog();
        }
    }
}

