using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Build_Cost_Guide
{
    public partial class Build_Cost_Guide : Form
    {
        public Build_Cost_Guide()
        {
            InitializeComponent();
            int bTotal = Int32.Parse(textTotal.Text);
        }
        #region //Calculate Click Command
        public void Calculate1_Click(object sender, EventArgs e)
        {
            textMotherboarda = bTotal;
        }
        #endregion
    }
}
