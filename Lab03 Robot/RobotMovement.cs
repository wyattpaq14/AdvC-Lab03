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
    public class RobotMovement
    {
        public static int[] currentPos = { 0, 0 };
        public static string direction = "";
        public static int moveAmount = 0;


        //Constructor
        public RobotMovement(int[] currentPos, string direction)
        {
            this.CurrentPos = currentPos;
            this.Direction = direction;
        }

        public RobotMovement(string direction)
        {
            this.Direction = direction;
        }

        public RobotMovement(int[] currentPos)
        {
            this.CurrentPos = currentPos;
        }

        public RobotMovement(int[] currentPos, int moveAmount)
        {
            this.CurrentPos = currentPos;
            this.MoveAmount = moveAmount;
        }


        //Properties



        public int[] CurrentPos
        {
            get
            {
                return currentPos;
            }
            set
            {
                currentPos = value;
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

        public int MoveAmount
        {
            get
            {
                return moveAmount;
            }
            set
            {
                moveAmount = value;
            }
        }





        //Point function that returns location
        public Point moveRobot()
        {

            Point lblLocation = new Point(0, 0);

            if (direction == "NORTH" && isValidLocation())
            {

                currentPos[1] -= moveAmount;
            }
            else if (direction == "EAST" && isValidLocation())
            {

                currentPos[0] += moveAmount;
            }
            else if (direction == "WEST" && isValidLocation())
            {

                currentPos[0] -= moveAmount;
            }
            else if (direction == "SOUTH" && isValidLocation())
            {

                currentPos[1] += moveAmount;
            }

            lblLocation = new Point(currentPos[0], currentPos[1]);
            return lblLocation;

        }


        //method to determin if location isn't out of bounds
        private bool isValidLocation()
        {
            if (currentPos[0] >= 5 && currentPos[0] < 185 && currentPos[1] >= .10 && currentPos[1] < 185)
            {
                return true;
            }
            else
            {
                MessageBox.Show("You are out of bounds!", "Error!");
                return false;
            }
            
        }


    }
}
