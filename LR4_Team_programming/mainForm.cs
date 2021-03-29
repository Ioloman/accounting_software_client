using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LR4_Team_programming.customElements;

namespace LR4_Team_programming
{
    public partial class mainForm : Form
    {
        Dictionary<TreeNode, UserControl> menuToPanel;
        List<UserControl> panels;

        // 835; 690 - size
        // 362; 0 - location


        Point locationPanels = new Point(362, 0);
        Size sizePanels = new Size(835, 690);

        public mainForm()
        {
            InitializeComponent();
            //reportEditPanel
            InventarizationDocument inventarization = new InventarizationDocument();
            InventarizationDocumentEdit inventarizationEdit = new InventarizationDocumentEdit();
            ReportDocument report = new ReportDocument();
            ReportDocumentEdit reportEdit = new ReportDocumentEdit();
            DeviationAnalysis deviationAnalysis = new DeviationAnalysis();

            inventarization.Location = inventarizationEdit.Location = report.Location = reportEdit.Location = deviationAnalysis.Location = locationPanels;
            inventarization.Visible = inventarizationEdit.Visible = report.Visible = reportEdit.Visible = deviationAnalysis.Visible = false;

            this.Controls.Add(inventarization);
            this.Controls.Add(inventarizationEdit);
            this.Controls.Add(report);
            this.Controls.Add(reportEdit);
            this.Controls.Add(deviationAnalysis);


            menuToPanel = new Dictionary<TreeNode, UserControl>()
            {
                {menuTree.Nodes[0].Nodes[0],  inventarization },
                {menuTree.Nodes[0].Nodes[1],  inventarizationEdit },

                {menuTree.Nodes[1].Nodes[0],  report},
                {menuTree.Nodes[1].Nodes[1],  reportEdit},
                
                {menuTree.Nodes[3],  deviationAnalysis}

            };

            panels = new List<UserControl>()
            {
                inventarization,
                inventarizationEdit,
                report,
                reportEdit,
                deviationAnalysis
            };

        
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

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}