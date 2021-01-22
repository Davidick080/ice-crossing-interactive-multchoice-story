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
    //end date of devlopment:Jan,22,2021
    //This is a mulitchoice/interactive story game. The main goal is to get across a frozen.
    public partial class backGround : Form
    {//scene count
        int scene = 0;
        //colors 
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
       //player character
        int personX = 0;
        int personY = 50;
        int personWidth = 30;
        int personHeight = 30;
        int personSpeed = 13;
        //when player has to move
        bool dDown = false;
        bool aDown = false;
        bool wDown = false;
        bool sDown = false;
        //sounds
        SoundPlayer wind = new SoundPlayer(Properties.Resources.Wind_Mark_DiAngelo_1940285615);
        SoundPlayer taDa = new SoundPlayer(Properties.Resources.Ta_Da_SoundBible_com_1884170640);
        SoundPlayer grenade = new SoundPlayer(Properties.Resources.Grenade_Explosion_SoundBible_com_2100581469);

        public backGround()
        {
            InitializeComponent();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs m)
        {
            switch (m.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
            }

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
                //for transitioning to player face
                else if (scene == 8)
                {

                    scene = 21;
                }
                //neccary keybind to be pressed to go to winning screen
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
            //this is for the space button
            if(m.KeyCode==Keys.Space)
            {
             
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

                    scene = 18;
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
                else if (scene == 4)
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
                    wind.Stop();
                    itemPopUp.Text = "";
                    storyText.Text = "You come to a lake you have...";
                    options1.Image = Properties.Resources.rpg;
                    options1.Text = "A rpg";
                    vLabel.Text = "press v for this option";
                    option2.Image = Properties.Resources.hookshot;
                    bLabel.Text = "press b for this option";
                    option2.Text = "a grappleshot";
                    option3.Image = Properties.Resources.mushroom;
                    option3.Text = "mushroom";
                    nLabel.Text = "Press n for option";
                    option4.Image = Properties.Resources.metal_gear_box;
                    mLabel.Text = "Press m for this option";
                    option4.Text = "A box";
                    option2.Visible = true;
                    option3.Visible = true;
                    option4.Visible = true;
                    vLabel.Visible = true;
                    mLabel.Visible = true;
                    bLabel.Visible = true;
                    nLabel.Visible = true;
                    personX = 0;
                    personY = 50;
                    break;
                case 1:
                    wind.Stop();
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
                    nLabel.Visible = true;
                    option3.Image = Properties.Resources.win_remote;
                    option3.Text = "Cheats mode";
                    option4.Visible = false;
                    mLabel.Visible = false;
               
                    break;
                case 5:
                    storyText.Text = "as you cross the ice with a pair of steel towed boats. The ice begins to shatter and you fall though.";
                    vLabel.Text = "press m to continue";
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
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
                    options1.Text = "";
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    break;
                case 19:
                    options1.Text = "";
                    itemPopUp.Image = null;
                    wind.Play();
                    storyText.Text = "game over";
                    vLabel.Text = "press m to restart";
                    nLabel.Visible = true;
                    nLabel.Text = "press n to exit game";

                    break;
                case 20:
                    options1.Text = "";
                    taDa.Play();
                    this.BackgroundImage = Properties.Resources.Frozen_lake;
                    storyText.Visible = true;
                    storyText.Text = "You win";
                    vLabel.Visible = true;
                    vLabel.Text = "press m to restart";
                    nLabel.Visible = true;
                    nLabel.Text = "press n to exit game";
                    break;
                case 21:
                  
                    options1.Image = null;
                    option2.Visible = false;
                    option3.Visible = false;
                    option4.Visible = false;
                    mLabel.Visible = false;
                    bLabel.Visible = false;
                    nLabel.Visible = false;
                    vLabel.Visible = false;
                    storyText.Visible = false;
                    this.BackgroundImage = null;
                    this.BackColor = Color.Blue;
                    gameCounter.Enabled = true;
                    break;
            }
        }

        private void gameCounter_Tick(object sender, EventArgs e)
        {

            //move player 1
            if (wDown == true && personY > 0)
            {
                personY -= personSpeed;
            }
            if (sDown == true && personY < 663)
            {
                personY += personSpeed;
            }
            if (dDown == true && personX < 1000)
            {
                personX += personSpeed;
            }
            if (aDown == true && personX > 0)
            {
                personX -= personSpeed;
            }
            if (personX > 1000)
            {
                scene = 20;
                this.BackgroundImage = Properties.Resources.Frozen_lake;
                vLabel.Visible = true;
                vLabel.Text = "press any button to continue";
                gameCounter.Enabled = false;
                
            }
            Refresh();
        }

        private void backGround_Paint(object sender, PaintEventArgs e)
            //for when scene 21 trigers 
        {
            if (scene == 21)
            {
                e.Graphics.FillRectangle(whiteBrush, 0, 0, 400, 1500);
                e.Graphics.FillRectangle(whiteBrush, 1000, 000, 2000, 1500);
                e.Graphics.FillEllipse(redBrush, personX, personY, personWidth, personHeight);

            }
        }

        private void backGround_KeyUp(object sender, KeyEventArgs e)
        {
            //controlls for w,s,a,d during scene 21
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }
    }
}








