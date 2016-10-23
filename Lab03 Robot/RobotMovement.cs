using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Robot
{
    public class RobotMovement
    {
        public static int[] newPosition = { 0, 0 };
        //public static int[] currentPosition = { 0, 0 };
        public static string direction = "";


        //Constructor
        public RobotMovement(int[] newPosition, string direction)
        {
            this.CurrentPosition = currentPosition;
            this.Direction = direction;
        }

        public RobotMovement(string direction)
        {
            this.Direction = direction;
        }


        //Properties



        public int[] NewPosition
        {
            get
            {
                return newPosition;
            }
            set
            {
                newPosition = value;
            }
        }

        public string Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }




        //Get direction from main class
        public void setDirection()
        {
            if (direction == "NORTH")
            {

                moveRobot();
            }
            else if (direction == "EAST")
            {

            }
            else if (direction == "WEST")
            {

            }
            else if (direction == "SOUTH")
            {

            }
        }

        public void moveRobot()
        {
            //Access form1
            Form1 form = new Form1();
            form.lblArrow.Location = new System.Drawing.Point(0, 0);




        }


    }
}
