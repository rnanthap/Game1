using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        //Assigning variables for when the player moves using the WASD keys 
        bool moveUp = false;
        bool moveDown = false;
        bool moveRight = false;
        bool moveLeft = false;

        //Assign the variables for the players location (X and Y coordinates)
        int playerX, playerY;

        //The code in this KeyDown event only runs when the Key is pressed down
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //If the W key is pressed
            if (e.KeyCode == Keys.W)
            {
                //Set the moveUp variable to true
                moveUp = true;
            }

            //If the S key is pressed
            if (e.KeyCode == Keys.S)
            {
                //Set the moveDown variable to true
                moveDown = true;
            }

            //If the D key is pressed
            if (e.KeyCode == Keys.D)
            {
                //Set the moveRight variable to true
                moveRight = true;
            }

            //If the A key is pressed
            if (e.KeyCode == Keys.A)
            {
                //Set the moveLeft variable to true
                moveLeft = true;
            }
        }

        //This is the code for the timer
        //The timer loops at an interval (ex. every 100ms)
        //So the code will run every time it loops
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            //If moveUp is true
            if (moveUp == true)
            {
                //Move the player up
                playerY = playerY - 5;
            }

            //If moveDown is true
            if (moveDown == true)
            {
                playerY = playerY + 5;
            }

            //If moveRight is true
            if (moveRight == true)
            {
                playerX = playerX + 5;
            }

            //If moveLeft is true
            if (moveLeft == true)
            {
                playerX = playerX - 5;
            }

            //Update the player's location (picPlayer is the name of the player's picturebox)
            picPlayer.Location = new Point(playerX, playerY);
        }

        //The code in this KeyUp event only runs when the Key NOT pressed down
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //If the W key is not pressed
            if(e.KeyCode == Keys.W)
            {
                //Don't move the player up
                moveUp = false;
            }

            //If the S key is not pressed
            if (e.KeyCode == Keys.S)
            {
                //Don't move the player down
                moveDown = false;
            }

            //If the D key is not pressed
            if (e.KeyCode == Keys.D)
            {
                //Don't move the player right
                moveRight = false;
            }

            //If the A key is not pressed
            if (e.KeyCode == Keys.A)
            {
                //Don't move the player left
                moveLeft = false;
            }
        }

        public Form1()
        {
            //The code under "InitializeComponent()" runs at the very start of the program
            //Any initalition will go here
            InitializeComponent();

            //The player starts at point (738,329)
            playerX = 492;
            playerY = 245;

            //Update the player's location 
            picPlayer.Location = new Point(playerX, playerY);
        }

    }
}
