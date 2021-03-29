using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LR4_Team_programming.customElements
{
    public partial class DeviationAnalysis : UserControl
    {
        bool downMove = true;
        public DeviationAnalysis()
        {
            InitializeComponent();
        }

        private void searchInAllDebCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            depComboBox.Enabled = !searchInAllDebCheckBox.Checked;

        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            // 17; 207 - старт
            // 17; 359 - финиш
            extraSettingPanel.Visible = true;
            timerForShiftingTable.Enabled = true;
            timerForShiftingTable.Interval = 10;
        }

        private void timerForShiftingTable_Tick(object sender, EventArgs e)
        {
            if (downMove)
            {
                table.Location = new Point(table.Location.X, table.Location.Y + 1);
                if (table.Location.Y >= 359)
                {
                    timerForShiftingTable.Enabled = false;
                    downMove = false;
                }
            }
            else
            {
                table.Location = new Point(table.Location.X, table.Location.Y - 1);
                if (table.Location.Y <= 207)
                {
                    timerForShiftingTable.Enabled = false;
                    downMove = true;
                }
            }
        }
    }
}
