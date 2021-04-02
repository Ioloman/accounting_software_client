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
    public partial class InventarizationDocumentEdit : UserControl
    {
        public InventarizationDocumentEdit()
        {
            InitializeComponent();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            inventarizationTable.Rows.Clear();
            progressBar.Visible = true;

            Thread thread = new Thread(fillTable);
            thread.Start();
        }

        private void fillTable()
        {
            var vedomosts = getVedomostsList();
            if (inventarizationTable.InvokeRequired)
            {
                inventarizationTable.Invoke(new MethodInvoker(delegate
                {
                    foreach (var vedomost in (List<Vedomost>)vedomosts)
                        inventarizationTable.Rows.Add(vedomost.doc_num, vedomost.creation_date);
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
