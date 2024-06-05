using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatalogRecepti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstPage1.Hide();
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            if (this.firstPage1.Visible == false)
            {
                this.firstPage1.Visible = true;
            }
            else if (this.firstPage1.Visible == true)
            {
                this.firstPage1.Visible = false;    
            }
        }
    }
}
