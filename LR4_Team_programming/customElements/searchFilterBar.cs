using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LR4_Team_programming.screens
{
    [System.ComponentModel.DefaultBindingProperty("SearchFilterBar")]
    public partial class searchFilterBar : UserControl
    {
        bool periodButton = false;
        bool dateButton = false;

        public searchFilterBar()
        {
            InitializeComponent();
        }

        private void documentNumberSelector_CheckedChanged(object sender, EventArgs e)
        {
            if (documentNumberSelector.Checked)
            {
                reportDateSelector.Checked = false;
                reportDatePeriodSelector.Checked = false;
                senderDepSelector.Checked = false;

                reportDateSelector.Enabled = false;
                reportDatePeriodSelector.Enabled = false;
                senderDepSelector.Enabled = false;

                reportDate.Enabled = false;
                reportLowestDate.Enabled = false;
                reportHighestDate.Enabled = false;
                senderDep.Enabled = false;

                dateButton = false;
                periodButton = false;
            }
            else
            {
                reportDateSelector.Enabled = true;
                reportDatePeriodSelector.Enabled = true;
                senderDepSelector.Enabled = true;

                reportDate.Enabled = true;
                reportLowestDate.Enabled = true;
                reportHighestDate.Enabled = true;
                senderDep.Enabled = true;
            }
        }


        private void reportDateSelector_MouseUp(object sender, MouseEventArgs e)
        {
            if (reportDateSelector.Checked == true && dateButton == true)
            {
                reportDateSelector.Checked = false;
                dateButton = false;
            }
            else
            { 
                dateButton = true;
                periodButton = false;

            }
        }

        private void reportDatePeriodSelector_MouseUp(object sender, MouseEventArgs e)
        {
            if (reportDatePeriodSelector.Checked == true && periodButton == true)
            {
                reportDatePeriodSelector.Checked = false;
                periodButton = false;
            }
            else
            { 
                periodButton = true;
                dateButton = false;
            }
        }

        public bool isDocumentNumberChecked()
        {
            return documentNumberSelector.Checked;
        }

        public bool isWorkshopChecked()
        {
            return senderDepSelector.Checked;
        }

        public bool isPeriodSelected()
        {
            return reportDatePeriodSelector.Checked;
        }

        public bool isDateSelected()
        {
            return reportDateSelector.Checked;
        }

        public int documentNumber()
        {
            return Convert.ToInt32(reportNumber.Text);
        }

        public DateTime getLowestDate()
        {
            return reportLowestDate.Value;
        }

        public DateTime getHighestDate()
        {
            return reportHighestDate.Value;
        }

        public DateTime getDate()
        {
            return reportDate.Value;
        }

        public string getWorkshop()
        {
            return senderDep.Text;
        }

    }
}
