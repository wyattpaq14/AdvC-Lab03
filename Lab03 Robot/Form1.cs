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

        public int[] cords = { 0, 0 };
        public int[] newCords = { 0, 0 };
        public int[] startingCords = { 95, 100 };
        public Form1()
        {
            InitializeComponent();
            lblCords.Text = Convert.ToString(lblArrow.Location);
            lblArrow.Text = Convert.ToChar(231).ToString();
            lblArrow.Text = Convert.ToChar(232).ToString();
            lblArrow.Text = Convert.ToChar(233).ToString();
            lblArrow.Text = Convert.ToChar(234).ToString();

            //get initial cords to start the robot
            RobotMovement robot = new RobotMovement(getCordnates(), newCords, "NORTH");

        }


        //Declare RobotMovement class
        

        

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
             
            cords = getCordnates();
            RobotMovement robot = new RobotMovement(cords, startingCords, "NORTH");

        }


        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnGo1_Click(object sender, EventArgs e)
        {

        }

        private void btnGo10_Click(object sender, EventArgs e)
        {

        }

        private void bntReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private int[] getCordnates()
        {
            //Split the shit out of everything, very important
            string[] yValue;
            string[] xValue;
            string locationString = Convert.ToString(lblArrow.Location);
            string[] stringArray = locationString.Split('=');
            yValue = stringArray[2].Split('}');
            xValue = stringArray[1].Split(',');

            //Didnt know a more efficent way of returning two values, so doing it this way 
            int[] cords = { Convert.ToInt32(xValue[0]), Convert.ToInt32(yValue[0]) };
            return cords;
        }
    }
}
