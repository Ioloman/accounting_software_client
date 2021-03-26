using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LR4_Team_programming
{
    public partial class MenuForm : Form
    {
        Dictionary<TreeNode, Panel> menuToPanel;
        List<Panel> panels;
        // 835; 690 - size
        // 362; 0 - location


        Point locationPanels = new Point(362, 0);
        Size sizePanels = new Size(835, 690);

        public MenuForm()
        {
            InitializeComponent();


            AccountingBalancesPanel.Location = RaportPanel.Location = VedomostPanel.Location = locationPanels;
            AccountingBalancesPanel.Size = RaportPanel.Size = VedomostPanel.Size = sizePanels;

            AccountingBalancesPanel.Visible = false;
            RaportPanel.Visible = false;
            VedomostPanel.Visible = false;

            menuToPanel = new Dictionary<TreeNode, Panel>()
            {
                {menuTree.Nodes[0].Nodes[0],  AccountingBalancesPanel},
                {menuTree.Nodes[0].Nodes[1],  RaportPanel},
                {menuTree.Nodes[1].Nodes[0],  VedomostPanel}
            };
            panels = new List<Panel>()
            {
                AccountingBalancesPanel, RaportPanel, VedomostPanel
            };
        }

    

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void senderDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //foreach(var menuTree )
            //foreach(var menuNode in menuToPanel)
            //    menuNode.Visible = false;

            //menuTree.SelectedNode.SelectedNode.Visible = true;    

            try
            {
                menuToPanel[menuTree.SelectedNode].Visible = true;
                foreach (Panel panel in panels)
                    panel.Visible = false;

                menuToPanel[menuTree.SelectedNode].Visible = true;

            }
            catch
            {
                // :(
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}