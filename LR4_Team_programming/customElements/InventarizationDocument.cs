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
        public InventarizationDocument()
        {
            InitializeComponent();
        }
        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            Vedomost vedomost = new Vedomost();
            var workshop = ApiConnector.getWorkshop(depTextBox.Text);
            if (workshop == null) {
                MessageBox.Show("Цех с таким названием не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Detail> details = (List<Detail>)ApiConnector.getDetails();
     
            vedomost.creation_date = docCreateDate.Value.ToString("yyyy-MM-dd");
            vedomost.doc_num = Convert.ToInt32(docNumberTextBox.Text);
            vedomost.workshop_pk = workshop.workshop_pk;
            vedomost.vedomost_lines = new List<VedomostLine>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                var vedomostLine = new VedomostLine();
                vedomostLine.detail_pk = details.Find(detail => detail.detail_name == dataGridView1.Rows[i].Cells[0].Value.ToString()).detail_pk;
                vedomost.vedomost_lines.Add(vedomostLine);
            }
            ApiConnector.createVedomost(vedomost);
            MessageBox.Show("Vedomost успешное создать!\n +1500 social_credits партия гордится тобой!", "Успешное создать!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
