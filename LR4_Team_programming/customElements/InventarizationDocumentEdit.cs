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

        Vedomost getVedomostsList(int documentNumber)
        {
            List<Vedomost> vedomosts = (List<Vedomost>) ApiConnector.getVedomosts();
            var vedomost = vedomosts.Find(vedomost => vedomost.doc_num == documentNumber);
            return vedomost;
        }

        IEnumerable<Vedomost> getVedomostsList(DateTime date, string senderWorkshop = "")
        {
            string format = "yyyy-MM-dd";
            var result = DateTime.ParseExact("2020-12-22", format, CultureInfo.InvariantCulture);

            List<Vedomost> _vedomosts = (List<Vedomost>)ApiConnector.getVedomosts();
            var vedomosts = _vedomosts.FindAll(vedomost =>
            DateTime.ParseExact(vedomost.creation_date, format, CultureInfo.InvariantCulture) == date);

            var workshop = ApiConnector.getWorkshop(senderWorkshop);

            if (senderWorkshop != string.Empty)
                vedomosts = vedomosts.FindAll(vedomost => vedomost.workshop_pk == workshop.workshop_pk);

            return vedomosts;
        }

        IEnumerable<Vedomost> getVedomostsList(DateTime lowestDate = default(DateTime), DateTime highestDate = default(DateTime), string senderWorkshop = "")
        {
            string format = "yyyy-MM-dd";
            var result = DateTime.ParseExact("2020-12-22", format, CultureInfo.InvariantCulture);

            List<Vedomost> _vedomosts = (List<Vedomost>)ApiConnector.getVedomosts();
            var vedomosts = _vedomosts.FindAll(vedomost =>
            DateTime.ParseExact(vedomost.creation_date, format, CultureInfo.InvariantCulture) >= lowestDate &&
            DateTime.ParseExact(vedomost.creation_date, format, CultureInfo.InvariantCulture) <= highestDate);

            var workshop = ApiConnector.getWorkshop(senderWorkshop);

            if (senderWorkshop != string.Empty)
                vedomosts = vedomosts.FindAll(vedomost => vedomost.workshop_pk == workshop.workshop_pk);

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
            if (searchFilterBar1.isDocumentNumberChecked())
            {
                var vedomost = getVedomostsList(searchFilterBar1.documentNumber());
                inventarizationTable.Rows.Add(vedomost.doc_num, vedomost.creation_date);
            }
            else if (searchFilterBar1.isDateSelected())
            {
                var vedomosts = getVedomostsList(searchFilterBar1.getDate(), searchFilterBar1.getWorkshop());
                foreach (var vedomost in vedomosts)
                    inventarizationTable.Rows.Add(vedomost.doc_num, vedomost.creation_date);
            }
            else if (searchFilterBar1.isPeriodSelected())
            {
                var vedomosts = getVedomostsList(searchFilterBar1.getLowestDate(), searchFilterBar1.getHighestDate(), searchFilterBar1.getWorkshop());
                foreach (var vedomost in vedomosts)
                    inventarizationTable.Rows.Add(vedomost.doc_num, vedomost.creation_date);
            }
            else if (searchFilterBar1.isWorkshopChecked())
            {
                var vedomosts = getVedomostsList(DateTime.MinValue, DateTime.MaxValue, searchFilterBar1.getWorkshop());
                foreach (var vedomost in vedomosts)
                    inventarizationTable.Rows.Add(vedomost.doc_num, vedomost.creation_date);
            }
            else
            {
                var vedomosts = ApiConnector.getVedomosts();
                foreach (var vedomost in vedomosts)
                    inventarizationTable.Rows.Add(vedomost.doc_num, vedomost.creation_date);
            }
            finishThread();
        }

        void finishThread()
        {
            progressBar.Visible = false;
        }
    }
}
