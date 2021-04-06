using System;

using System.IO;
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
        private delegate DialogResult ShowSaveFileDialogInvoker();

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
                if (this.table.CurrentCell.ColumnIndex == 0)
                {
                    ComboBox c = e.Control as ComboBox;
                    c.DropDownStyle = ComboBoxStyle.DropDown;
                    c.AutoCompleteMode = AutoCompleteMode.Suggest;
                    c.AutoCompleteSource = AutoCompleteSource.ListItems;
                }

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


        private void saveChages(object depName)
        {
            Vedomost vedomost = new Vedomost();
            var workshop = ApiConnector.getWorkshop((depName as string));
            if (workshop == null)
            {
                MessageBox.Show("Цех с таким названием не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //List<Detail> details = (List<Detail>)ApiConnector.getDetails(); // Возможно, можно удалить эту строку

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
            UseWaitCursor = false;
        }



        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            Thread savingProcces = new Thread(new ParameterizedThreadStart(saveChages));
            progressBar1.Visible = true;
            UseWaitCursor = true;
            savingProcces.Start(depTextBox.Text);
        }

        private void table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < table.Rows.Count - 1; i++)
                table.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }

        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (table.CurrentRow.Index != table.Rows.Count - 1)
                    table.Rows.RemoveAt(table.CurrentRow.Index);
            }
        }

        private void table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < table.Rows.Count - 1; i++)
                table.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            this.progressBar1.Visible = true;

            DataGridView table = GetTable;
            string dep = GetDepComboBox.Text;
            string createDate = GetDocCreateDate.Text;
            string docNum = GetDocNumberTextBox.Text;

            List<List<string>> data = new List<List<string>>();
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                data.Add(new List<string>());
                data[i].Add((i + 1).ToString());
                for (int j = 0; j < table.Columns.Count - 1; j++)
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
                showPrintForm(dep, createDate, docNum, data);
                this.progressBar1.BeginInvoke((MethodInvoker)(() => this.progressBar1.Visible = false));

            });
            thread.Start();            
        }

        private void showPrintForm(string dep, string createDate, string docNum, List<List<string>> data)
        {
            string path = Program.GetPathToTemplatesFolder() + "inventarization template.docx";
            docViewerForm docViewerForm = new docViewerForm(docNum, dep, createDate, data, mainForm.docTypes.vedomost, path);
            docViewerForm.ShowDialog();
        }

        private void table_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == this.table.Columns[0].Index)
            {
                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)this.table.Columns[0];
                object eFV = e.FormattedValue;
                if (!comboBoxColumn.Items.Contains(eFV))
                {
                    comboBoxColumn.Items.Add(eFV);
                    this.table.CurrentCell.Value = e.FormattedValue;
                }
            }
        }
    }
}
