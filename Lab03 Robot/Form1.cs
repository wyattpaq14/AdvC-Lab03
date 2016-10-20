using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Robot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblArrow.Text = Convert.ToChar(231).ToString();
            lblArrow.Text = Convert.ToChar(232).ToString();
            lblArrow.Text = Convert.ToChar(233).ToString();
            lblArrow.Text = Convert.ToChar(234).ToString();
        }







        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Funfact: Your stupid", "Funfact");
        }
    }
}
