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
    //-extra things 
    //-animations
    //-keyboard counter 
    //-
    public partial class backGround : Form
    {//scene count
        int scene = 0;
        int keyboardPresses = 0;
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
           

                else if (scene == 4)
                {

                    scene = 18;
                }
                // neccecary keybind to be pressed to continue to gameover screen
                else if (scene == 5)
                {
                    scene = 19;
                }
                else if (scene == 6)
                {
                    scene = 19;
                }
                else if (scene == 7)
                {
                    scene = 19;
                }
                else if (scene == 11)
                {
                    scene = 19;
                }
                else if (scene == 12)
                {
                    scene = 19;
                }
                else if (scene == 13)
                {
                    scene = 19;
                }
                else if (scene == 14)
                {
                    scene = 19;
                }
                else if (scene == 16)
                {
                    scene = 19;
                }
                else if (scene == 17)
                {
                    scene = 19;
                }
                //neccary keybind to be pressed to go to winning screen
                else if (scene == 8)
                {

                    scene = 20;
                }
                else if (scene == 9)
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

                    scene = 12;
                }
                else if (scene == 3)
                {

                    scene = 15;
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
                else if (scene == 2)
                {

                    scene = 10;
                }
                else if (scene == 3)
                {

                    scene = 13;
                }
                else if(scene==4)
                {
                    scene = 16;
                }
            }
            //hidden ending
            if (m.KeyCode == Keys.Q)
            {
                if (scene == 0)
                {
                    scene = 9;
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
                  
                    option2.Visible = true;
                    option3.Visible = true;
                    option4.Visible = true;
                    mLabel.Visible = true;
                    bLabel.Visible = true;
                    nLabel.Visible = true;
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
                    storyText.Text = "you also have...";
                    options1.Image = Properties.Resources.legend_of_zelda_hat_pixel;
                    options1.Text = "Green hat";
                    option2.Image = Properties.Resources.red_balloons;
                    option2.Text = "redballoons";
                    option3.Image = Properties.Resources.cheese_pixel;
                    option3.Text = "cheese";
                    option4.Visible = false;
                    mLabel.Visible = false;
                    break;
                case 3:
                    storyText.Text = "you also have...";
                    options1.Image = Properties.Resources.mario_leaf;
                    options1.Text = "Leaf";
                    option2.Image = Properties.Resources.mario_Kart;
                    option2.Text = "A kart";
                    option3.Image = Properties.Resources.teleportation_device;
                    option3.Text = "teleportation device";
                    option4.Visible = false;
                    mLabel.Visible = false;
                    break;
                case 4:
                    storyText.Text = "you also have...";
                    options1.Image = Properties.Resources.snakebanadana;
                    options1.Text = "a bandana";
                    option2.Image = Properties.Resources.drone;
                    option2.Text = "a drone";
                    option3.Image = Properties.Resources.win_remote;
                    option3.Text = "Cheats mode";
                    option4.Visible = false;
                    mLabel.Visible = false;
                    break;
                case 5:
                    storyText.Text = "as you cross the ice with a pair of steel towed boats. The ice begins to shatter and you fall though.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 6:
                    itemPopUp.Image = Properties.Resources.solder_rocket;
                    storyText.Text = "As you look at the how to rocket jump page. You accidentally drop the rpg & it explodes.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 7:
                    storyText.Text = "As you begin to load the rpg. You accidentally drop a rocket & it explodes.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 8:
                    storyText.Text = "You decide to just not use the rpg and put it down in the snow. You cross the lake without needing to use anything.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 9:
                    storyText.Text = "congralations you found hidden ending";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 10:
                    storyText.Text = "You aim the grappleshot at a tree across the frozen lake & you make it across. You also drop the green hat halfway between the frozen lake.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 11:
                    storyText.Text = " As you finished blowing up the red balloons & begin to cross the frozen lake. The balloons begin to pop you fall onto the ice & broke though the ice. ";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 12:
                    storyText.Text = "You eat the cheese & attempt to cross while eating the cheese. You began to chocke on the cheese.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 13:

                    storyText.Text = "You have a special leaf that makes you into a tenuki suit for some reason & a mushroom that does nothing.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 14:
                    storyText.Text = "You attempt to use the mushroom with the kart thinking it must work like in mario kart or something. The car expolodes eventually.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 15:
                    storyText.Text = "you get 10 points for having a odd looking mushroom & you use a teleporter device to get across a frozen lake";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 16:
                    storyText.Text = "You put on a bandana & box over your self & begin to cross the lake. You dont know where you are going so you just go in circles hopeing for the best.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 17:
                    storyText.Text = "You also have a drone in the box that dosent have any battery";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 18:
                    storyText.Text = "inside the box was a cheat mode remote. You teleport yourself across the frozen lake.";
                    vLabel.Text = "press m to continue";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 19:
                    storyText.Text = "game over";
                    vLabel.Text = "press m to restart";
                    nLabel.Visible = true;
                    nLabel.Text = "press n to exit game";

                    break;
                case 20:
                    storyText.Text="You win";
                    vLabel.Text = "press m to restart";
                    nLabel.Visible = true;
                    nLabel.Text = "press n to exit game";
                    break;


            }
        }
    }
}








