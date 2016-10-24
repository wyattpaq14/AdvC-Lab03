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
        public Form1()
        {
            InitializeComponent();


            //Set iniital position
            updateCords(new Point(0, 0));
            RobotMovement robot = new RobotMovement(getCordnates(), "NORTH");
            lblArrow.Text = Convert.ToChar(233).ToString();

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            RobotMovement robot = new RobotMovement("NORTH");
            lblArrow.Text = Convert.ToChar(233).ToString();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            RobotMovement robot = new RobotMovement("EAST");
            lblArrow.Text = Convert.ToChar(232).ToString();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            RobotMovement robot = new RobotMovement("SOUTH");

            lblArrow.Text = Convert.ToChar(234).ToString();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            RobotMovement robot = new RobotMovement("WEST");
            lblArrow.Text = Convert.ToChar(231).ToString();
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            RobotMovement robot = new RobotMovement(getCordnates(), 1);
            Point location = robot.moveRobot();
            lblArrow.Location = robot.moveRobot();
            updateCords(location);
        }

        private void btnGo10_Click(object sender, EventArgs e)
        {
            RobotMovement robot = new RobotMovement(getCordnates(), 10);
            Point location = robot.moveRobot();
            lblArrow.Location = location;
            updateCords(location);
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            //reset location and direction
            lblArrow.Location = new Point(95, 100);
            RobotMovement robot = new RobotMovement("NORTH");
            lblArrow.Text = Convert.ToChar(233).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void updateCords(Point location)
        {
            //Again, split up some shit
            //Could have made a function for this but why complicate it more
            string[] yValue;
            string[] xValue;
            string locationString = Convert.ToString(lblArrow.Location);
            string[] stringArray = locationString.Split('=');
            yValue = stringArray[2].Split('}');
            xValue = stringArray[1].Split(',');

            int[] cords = { Convert.ToInt32(xValue[0]), Convert.ToInt32(yValue[0]) };

            int[] updatedCords = getCordnates();
            //Set the cords to be relative to 0,0 instead of what ever it was
            lblCords.Text = "X: " + (cords[0] - 95) + "  Y: " + (cords[1] - 100);

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

            //Didnt know a more efficent way of returning the two values, so doing it this way 
            int[] cords = { Convert.ToInt32(xValue[0]), Convert.ToInt32(yValue[0]) };
            return cords;
        }
    }
}
