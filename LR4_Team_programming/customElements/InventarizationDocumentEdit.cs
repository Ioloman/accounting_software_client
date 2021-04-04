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
using System.Threading.Tasks;

namespace LR4_Team_programming.customElements
{
    public partial class InventarizationDocumentEdit : UserControl
    {
        public List<Vedomost> vedomosts;
        public List<Detail> details;

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
                return  searchFilterBar1.depNameComboBoxItems;
            }
        }

        public InventarizationDocumentEdit()
        {
            InitializeComponent();
            inventarizationTable.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            inventarizationTable.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }

        IEnumerable<Vedomost> getVedomostsList()
        {
            List<Vedomost> vedomosts = null;
            try
            {
                vedomosts = (List<Vedomost>)ApiConnector.getVedomosts();
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Отсутствует подключение к сети Интернет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Vedomost>();
            }

            if (searchFilterBar1.isDocumentNumberChecked())
            {
                int documentNumber = searchFilterBar1.documentNumber();
                var vedomost = vedomosts.Find(vedomost => vedomost.doc_num == documentNumber);
                if (vedomost != null)
                    vedomosts = new List<Vedomost> { vedomost };
                else
                    vedomosts.Clear();
            }
            else
            {
                if (searchFilterBar1.isDateSelected())
                {
                    DateTime date = searchFilterBar1.getDate();

                    string format = "yyyy-MM-dd";
                    vedomosts = vedomosts.FindAll(vedomost =>
                    DateTime.ParseExact(vedomost.creation_date, format, CultureInfo.InvariantCulture) == date);
                }

                if (searchFilterBar1.isPeriodSelected())
                {
                    DateTime lowestDate = searchFilterBar1.getLowestDate();
                    DateTime highestDate = searchFilterBar1.getHighestDate();

                    string format = "yyyy-MM-dd";
                    vedomosts = vedomosts.FindAll(vedomost =>
                    DateTime.ParseExact(vedomost.creation_date, format, CultureInfo.InvariantCulture) >= lowestDate &&
                    DateTime.ParseExact(vedomost.creation_date, format, CultureInfo.InvariantCulture) <= highestDate);
                }

                if (searchFilterBar1.isWorkshopChecked())
                {
                    string senderWorkshop = searchFilterBar1.getWorkshop();

                    var workshop = ApiConnector.getWorkshop(senderWorkshop);
                    if (workshop != null)
                        vedomosts = vedomosts.FindAll(vedomost => vedomost.workshop_pk == workshop.workshop_pk);
                    else
                        vedomosts.Clear();
                }
            }

            return vedomosts;
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            inventarizationTable.Rows.Clear();
            progressBar.Visible = true;
            UseWaitCursor = true;

            await Task.Run(() => fillTable());

  
            //Thread thread = new Thread(fillTable);
            //thread.Start();
        }

        private void fillTable()
        {
            vedomosts = (List<Vedomost>) getVedomostsList();
            if (inventarizationTable.InvokeRequired)
            {
                inventarizationTable.Invoke(new MethodInvoker(delegate
                {
                    foreach (var vedomost in (List<Vedomost>)vedomosts)
                        inventarizationTable.Rows.Add(vedomost.doc_num, vedomost.creation_date);

                    AutoCompleteSourceForDocNum.Clear();
                    foreach (Vedomost vedomost in vedomosts)
                        AutoCompleteSourceForDocNum.Add(vedomost.doc_num.ToString());
                    finishThread();
                }));
            }

        }

        void finishThread()
        {
            progressBar.Visible = false;           
            UseWaitCursor = false;

        }

        private void inventarizationTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < inventarizationTable.Rows.Count; i++)
                inventarizationTable.Rows[i].HeaderCell.Value = (i + 1).ToString();

        }

        private void inventarizationTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = imageList1.Images[0].Width;
                var h = imageList1.Images[0].Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(imageList1.Images[0], new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 3)
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

        private void inventarizationTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                // удалить здесь
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить ведомость №" +
                    inventarizationTable.CurrentRow.Cells[0].Value.ToString() + "?", "Удаление", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    int index = e.RowIndex;
                    ApiConnector.deleteVedomost(vedomosts[index]);
                    vedomosts.RemoveAt(index);
                    AutoCompleteSourceForDocNum.RemoveAt(index);
                    inventarizationTable.Rows.RemoveAt(index);
                    
                    MessageBox.Show("Ведомость была успешно удалена.", "Удаление ведомости", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                }    
            }
            if (e.ColumnIndex == 2)
            {
                // открыть форму для редактирования инвентаризации
                Vedomost currVedomost = vedomosts.Find(vedomost => inventarizationTable.CurrentRow.Cells[0].Value.ToString() == vedomost.doc_num.ToString());

                EditingInventarization editingInventarizationForm = new EditingInventarization(currVedomost);
                InventarizationDocument inventarization = editingInventarizationForm.GetPanel;
                inventarization.GetDocCreateDate.Value =  DateTime.Parse(currVedomost.creation_date);
                inventarization.GetDocNumberTextBox.Text = currVedomost.doc_num.ToString();

                for (int i = 0; i < depNameComboBoxItems.Count; i++)
                    inventarization.GetDepComboBox.Items.Add(depNameComboBoxItems[i]);

                string workshopName = ApiConnector.getWorkshop(currVedomost.workshop_pk).workshop_name;
                int index = depNameComboBoxItems.IndexOf(workshopName);
                inventarization.GetDepComboBox.SelectedIndex = index;
                DataGridView table = inventarization.GetTable;
                table.AllowUserToAddRows = false;

                inventarization.SetDetails = details;
                for (int i = 0; i<  currVedomost.vedomost_lines.Count; i++)
                {
                    table.Rows.Add();
                    table.Rows[i].Cells[1].Value = currVedomost.vedomost_lines[i].detail.cipher_detail;
                    table.Rows[i].Cells[2].Value = currVedomost.vedomost_lines[i].amount;
                    (table.Rows[i].Cells[0]).Value = currVedomost.vedomost_lines[i].detail.detail_name;
                }
                table.AllowUserToAddRows = true;
                editingInventarizationForm.Show();
                editingInventarizationForm.FormClosed += new FormClosedEventHandler(RefreshVedomosts);
            }
        }
        private async void RefreshVedomosts(object sender, FormClosedEventArgs e)
        {
            inventarizationTable.Rows.Clear();
            progressBar.Visible = true;


            await Task.Run(() => fillTable());


            //Thread thread = new Thread(fillTable);
            //thread.Start();
        }

        private void inventarizationTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < inventarizationTable.Rows.Count; i++)
                inventarizationTable.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }
    }
}
