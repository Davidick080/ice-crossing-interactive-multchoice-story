using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace ice_crossing_interactive_multchoice_story
{//Code creator:David Dickson 
    // Start date of development:Jan 19,2021
    //to do list (must fallow in order )
    //-Get the rough code out 
    //-Get the key binds to react & head to the right scene 
    //- gather the remaning sounds & pictures(more pixel art if neccerary)
    //-polish
    //bugs list
    //-
    //-
    //-
    //-
    public partial class backGround : Form
    {//scene count
        int scene = 0;
        public backGround()
        {
            InitializeComponent();
            storyText.Text = "you come to a frozen lake you have...";
            options1.Image = Properties.Resources.rpg;
            options1.Text = "A rpg";
            option2.Image = Properties.Resources.hookshot;
            option2.Text = "a grappleshot";
            option3.Image = Properties.Resources.mushroom;
            option3.Text = "mushroom";
            option4.Image = Properties.Resources.metal_gear_box;
            option4.Text = "A box";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs m)
        {
            //M keybind 
            if (m.KeyCode == Keys.M)
            {
                //intro scene
                if (scene == 0)
                {
                    scene = 4;
                }

                else if (scene == 1)
                {
                    scene = 8;
                }
                else if (scene == 2)
                {
                    scene = 12;
                }
                else if (scene == 3)
                {
                    scene = 15;
                }

                else if (scene == 4)
                {
                    scene = 18;
                }
                //neccerary keybind to be pressed to go to winning screen
                else if (scene == 8)
                {
                    scene = 20;
                }
                else if (scene == 10)
                {
                    scene = 20;
                }
                else if (scene == 15)
                {
                    scene = 20;
                }
                else if (scene == 18)
                {
                    scene = 20;
                }
                //retry applications
                else if (scene == 19)
                {
                    scene = 0;
                }
                else if (scene == 20)
                {
                    scene = 0;
                }

            }
            //this is for the B keybind
            if (m.KeyCode == Keys.B)

            {
                //intro scene
                if (scene == 0)
                {
                    scene = 2;
                }

                else if (scene == 1)
                {
                    scene = 6;
                }
                else if (scene == 2)
                {
                    scene = 10;
                }
                else if (scene == 3)
                {
                    scene = 13;
                }

                else if (scene == 4)
                {
                    scene = 16;
                }
            }
            //n Keybind 
            if (m.KeyCode == Keys.N)
            {

                //intro scene
                if (scene == 0)
                {
                    scene = 3;
                }
                else if (scene == 1)
                {
                    scene = 7;
                }
                else if (scene == 2)
                {
                    scene = 11;
                }
                else if (scene == 3)
                {
                    scene = 14;
                }
                else if (scene == 4)
                {
                    scene = 17;
                }
                //scenes that take to exit application 
                else if (scene == 19)
                {
                    scene = 99;
                }
                else if (scene == 20)
                {
                    scene = 99;
                }
                //exit application
                else if (scene == 99)
                {
                    Application.Exit();
                }
            }
            //This is for the v keybind 
            if (m.KeyCode == Keys.V)
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 5;
                }
            }
            switch (scene)
            {

                case 0:  //start scene  
                    storyText.Text = "You come to a lake you have...";
                    options1.Image = Properties.Resources.rpg;
                    options1.Text = "A rpg";
                    option2.Image = Properties.Resources.hookshot;
                    option2.Text = "a grappleshot";
                    option3.Image = Properties.Resources.mushroom;
                    option3.Text = "mushroom";
                    option4.Image = Properties.Resources.metal_gear_box;
                    option4.Text = "A box";
                    break;
                case 1:
                    storyText.Text = "you also have...";
                    options1.Image = Properties.Resources.gunboats;
                    options1.Text = "";
                    option2.Image = Properties.Resources.solder_hat_pixel;
                    option2.Text = "helmet";
                    option3.Image = Properties.Resources.ammution;
                    option3.Text = "rockets";
                    option4.Image = Properties.Resources.nothing;
                    option4.Text = "";
                    break;
                case 2:
                    storyText.Text = "dingas";
                    break;
                case 3:
                    storyText.Text = "ret";

                    break;
                case 4:
                    storyText.Text = "s[ofk";
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
            }
        }
    }
}








