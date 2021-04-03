using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LR4_Team_programming.customElements;
using Models;
namespace LR4_Team_programming
{
    public partial class EditingReportForm : Form
    {
        public Report reportLast;

        public ReportDocument  GetPanel
        {
            get
            {
                return reportDocument1;
            }
        }
            
        public EditingReportForm()
        {
            InitializeComponent();
        }
        public EditingReportForm(Report report)
        {
            InitializeComponent();
            reportLast = report;
        }
    }
}
