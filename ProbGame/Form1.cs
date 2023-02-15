using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMaxFood.Text = "20";
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            int temp = 2;
            if (lblFood.Text == "0")
            {
                lblFood.Text = "" + 2;
            } else
            {
                lblFood.Text = (Convert.ToInt32(lblFood.Text) + 2).ToString();
            }
            
        }
    }
}
