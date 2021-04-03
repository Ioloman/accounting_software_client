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
    public partial class EditingInventarization : Form
    {
        public Vedomost vedomostLast;
        public EditingInventarization()
        {
            InitializeComponent();       
        }
        public EditingInventarization(Vedomost currVedomost)
        {
            InitializeComponent();
            vedomostLast = currVedomost;
        }
        public InventarizationDocument GetPanel
        {
            get
            {
                return inventarizationDocument1;
            }
        }
    }
}
