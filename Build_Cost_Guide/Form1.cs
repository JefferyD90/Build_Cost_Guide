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
        }
        #region //Calculate Click Command
        public void Calculate1_Click(object sender, EventArgs e)
        {
            int total;
            total = Convert.ToInt32(textTotal.Text);
            total = int.Parse(textTotal.Text);
            
        }
        #endregion

        #region //AMD Formula
        public void aCalc()
        {
            if (checkMotherboarda.Checked) { textMotherboarda = textTotal; }
        }
        #endregion

        #region //Intel Formula

        #endregion
    }
}
