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
    public partial class InventarizationDocument : UserControl
    {
        public DataGridView GetTable
        {
            get
            {
                return table;
            }
        }

        public TextBox GetDocNumberTextBox
        {
            get
            {
                return docNumberTextBox;
            }
        }

        public DateTimePicker GetDocCreateDate
        {
            get
            {
                return docCreateDate;
            }
        }
        public ComboBox GetDepComboBox
        {
            get
            {
                return depTextBox;
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
                (table.Columns[0] as DataGridViewComboBoxColumn).Items.Clear();
                foreach (string str in detailsNames)
                    (table.Columns[0] as DataGridViewComboBoxColumn).Items.Add(str);
            }
        }

        public ComboBox.ObjectCollection depNameComboBoxItems
        {
            get
            {
                return this.depTextBox.Items;
            }
        }
        public InventarizationDocument()
        {
            InitializeComponent();
            depTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            table.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            table.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            table.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(table_EditingControlShowing);
        }
        void table_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                // вставить массу в сырье
                if ((sender as DataGridView).CurrentCell.ColumnIndex == 0)
                {
                    (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(InsertCodeOKP);

                }
            }
            catch { }
        }
        private void InsertCodeOKP(object sender, EventArgs e)
        {
            try
            {
                if ((sender as ComboBox) != null)
                    if ((sender as ComboBox).SelectedIndex != -1)
                        table.CurrentRow.Cells[1].Value = details[(sender as ComboBox).SelectedIndex].cipher_detail;
            }
            catch { };
        }


        private void saveChages()
        {
            Vedomost vedomost = new Vedomost();
            var workshop = ApiConnector.getWorkshop(depTextBox.Text);
            if (workshop == null)
            {
                MessageBox.Show("Цех с таким названием не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Detail> details = (List<Detail>)ApiConnector.getDetails(); // Возможно, можно удалить эту строку

            vedomost.creation_date = docCreateDate.Value.ToString("yyyy-MM-dd");
            vedomost.doc_num = Convert.ToInt32(docNumberTextBox.Text);
            vedomost.workshop_pk = workshop.workshop_pk;
            vedomost.vedomost_lines = new List<VedomostLine>();
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                var vedomostLine = new VedomostLine();
                vedomostLine.detail_pk = details.Find(detail => detail.detail_name == table.Rows[i].Cells[0].Value.ToString()).detail_pk;
                vedomostLine.amount = Convert.ToInt32(table.Rows[i].Cells[2].Value);
                vedomost.vedomost_lines.Add(vedomostLine);
            }

            if (Parent is EditingInventarization)
            {
                vedomost.url = (Parent as EditingInventarization).vedomostLast.url;
                ApiConnector.editVedomost(vedomost);
                MessageBox.Show("Ведомость была успешно изменена.", "Редактирование ведомости", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ApiConnector.createVedomost(vedomost);
                MessageBox.Show("Ведомость была успешно создана.", "Добавление ведомости", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            progressBar1.Visible = false;
        }



        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            Thread savingProcces = new Thread(saveChages);
            progressBar1.Visible = true;
            savingProcces.Start();
        }

        private void table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < table.Rows.Count - 1; i++)
                table.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }
    }
}
