using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LR4_Team_programming.customElements;
using Models;
using System.Threading.Tasks;
using System.Threading;
using Word = Microsoft.Office.Interop.Word;
namespace LR4_Team_programming
{
    
    public partial class mainForm : Form
    {

        private static Word.Application wordApp;
        public static void printMethod(string path)
        {
            wordApp = new Word.Application();
            wordApp.Visible = false;
            PrintDialog pDialog = new PrintDialog();
            if (pDialog.ShowDialog() == DialogResult.OK)
            {
                Word.Document doc = wordApp.Documents.Add(@"C:\Users\aleks\Desktop\хуй2.docx");
                wordApp.ActivePrinter = pDialog.PrinterSettings.PrinterName;
                wordApp.ActiveDocument.PrintOut();
                doc.Close(SaveChanges: false);
                doc = null;
            }
        }


        public static mainForm activ;

        public enum docTypes
        {
            vedomost = 0,
            report = 1,
            balances = 2,
            analysis = 3
        }

        Dictionary<TreeNode, UserControl> menuToPanel;
        List<UserControl> panels;

        InventarizationDocument inventarization;
        InventarizationDocumentEdit inventarizationEdit;
        ReportDocument report;
        ReportDocumentEdit reportEdit;
        DeviationAnalysis deviationAnalysis;
        CalculatingBalances calculatingBalances;

        // 835; 690 - size
        // 362; 0 - location

        Point locationPanels = new Point(362, 0);
        Size sizePanels = new Size(835, 690);

        public mainForm()
        {
            InitializeComponent();

            fillComboboxesHelper();
            activ = this;

            //Thread thread = new Thread(fillComboboxes);
            //thread.Start();




            menuTree.Nodes[0].Expand();
            menuTree.Nodes[1].Expand();
            //reportEditPanel
            inventarization = new InventarizationDocument();
            inventarizationEdit = new InventarizationDocumentEdit();
            report = new ReportDocument();
            reportEdit = new ReportDocumentEdit();
            deviationAnalysis = new DeviationAnalysis();
            calculatingBalances = new CalculatingBalances();

            inventarization.Location = 
                inventarizationEdit.Location = 
                report.Location = 
                reportEdit.Location = 
                deviationAnalysis.Location = 
                calculatingBalances.Location = locationPanels;

            inventarization.Visible = 
                inventarizationEdit.Visible = 
                report.Visible = 
                reportEdit.Visible = 
                deviationAnalysis.Visible = 
                calculatingBalances.Visible = false;

            this.Controls.Add(inventarization);
            this.Controls.Add(inventarizationEdit);
            this.Controls.Add(report);
            this.Controls.Add(reportEdit);
            this.Controls.Add(deviationAnalysis);
            this.Controls.Add(calculatingBalances);

            menuToPanel = new Dictionary<TreeNode, UserControl>()
            {
                {menuTree.Nodes[0].Nodes[0],  inventarization },
                {menuTree.Nodes[0].Nodes[1],  inventarizationEdit },

                {menuTree.Nodes[1].Nodes[0],  report},
                {menuTree.Nodes[1].Nodes[1],  reportEdit},
                
                {menuTree.Nodes[2],  deviationAnalysis},
                {menuTree.Nodes[3],  calculatingBalances}

            };

            panels = new List<UserControl>()
            {
                inventarization,
                inventarizationEdit,
                report,
                reportEdit,
                deviationAnalysis,
                calculatingBalances
            };
        }

        private  void fillComboboxesHelper()
        {
            this.progressBar.Visible = true;
            (new Thread((s) =>
            {
                fillComboboxes();
                this.progressBar.BeginInvoke((MethodInvoker)(() => this.progressBar.Visible = false));
            })).Start();

        }


        private void senderDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {            
                menuToPanel[menuTree.SelectedNode].Visible = true;
                foreach (UserControl panel in panels)
                    panel.Visible = false;

                menuToPanel[menuTree.SelectedNode].Visible = true;
                
            }
            catch
            {
                // :(
            }
        }

        private void fillComboboxes()
        {
            // получаем цеха и вносим их названия во все комбо-боксы
            List<Workshop> workshops = (List<Workshop>)ApiConnector.getWorkshops();
            List<string> workshopNames = new List<string>();
            foreach (Workshop workshop in workshops)
                workshopNames.Add(workshop.workshop_name);

            calculatingBalances.depNameComboBoxItems.AddRange(workshopNames.ToArray());
            deviationAnalysis.depNameComboBoxItems.AddRange(workshopNames.ToArray());
            inventarization.depNameComboBoxItems.AddRange(workshopNames.ToArray());
            inventarizationEdit.depNameComboBoxItems.AddRange(workshopNames.ToArray());
            report.depNameComboBoxItems.AddRange(workshopNames.ToArray());
            reportEdit.depNameComboBoxItems.AddRange(workshopNames.ToArray());
            reportEdit.workshops = workshops;

            // теперь тоже самое, только с деталями
            List<Detail> details = (List<Detail>)ApiConnector.getDetails();
            inventarizationEdit.details = details;
            inventarization.SetDetails = details;
            report.SetDetails = details;
            reportEdit.details = details;
            report.depComboBoxItemsInTable.AddRange(workshopNames.ToArray());




            // тут заполняю автодополнение для поисков по номеру документа
            // скорее всего, из-за этого прога иногда после запуска закрывается.
            /*
                List<Report> reports = (List<Report>)ApiConnector.getReports();
                List<Vedomost> vedomosts = (List<Vedomost>)ApiConnector.getVedomosts();

                inventarizationEdit.vedomosts = vedomosts;
                reportEdit.reports = reports;

                List<string> reportsNames = new List<string>();
                foreach (Report report in reports)
                    reportsNames.Add(report.doc_num.ToString());

                List<string> vedomostsNames = new List<string>();
                foreach (Vedomost vedomost in vedomosts)
                    vedomostsNames.Add(vedomost.doc_num.ToString());

                reportEdit.AutoCompleteSourceForDocNum.AddRange(reportsNames.ToArray());
                inventarizationEdit.AutoCompleteSourceForDocNum.AddRange(vedomostsNames.ToArray());
            UseWaitCursor = false;
            */
        }


        private void mainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}