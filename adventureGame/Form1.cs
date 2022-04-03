using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        int randomNumber;
        Random randGen = new Random();
       
        public Form1()

        {
            InitializeComponent();
            DisplayPage();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox_Click(object sender, EventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            // left button outcome 
            if (page == 1)
            {
                page = 2;
                
            }
            else if (page == 2)
            {
                page = 4; 
            }
            
            else if (page == 5)
            {
               page = 8; 
             }
            else if (page == 100)
            {
                page = 2; 
            }
            else if (page == 99)
            {
                page = 2; 
            }
           
            else if (page == 3)
            {
                page = 7; 
            }
            else if (page == 8)
            {
                page = 9; 
            }
            else if (page ==7)
            {
                page = 10;
            }
       else if (page == 4)
            {
                page = 12; 
            }
            DisplayPage();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            // right button outcome 
            if (page == 1)
            {
                this.Close();
            }
            else if (page == 2)
            {
                randomNumber = randGen.Next(1, 6);
                if (randomNumber == 5)
                {
                    page = 100;

                }
                else
                {
                    page = 99;
                }


            }
            else if (page == 5)
            {
                randomNumber = randGen.Next(1, 6);
                if (randomNumber == 5)
                {
                    page = 100;

                }
                else
                {
                    page = 99;
                }

            }
            else if (page == 4)
            {
                page = 6; 
            }
           else if (page == 100)
            {
                this.Close(); 
            }
            else if (page ==99)
            {
                this.Close(); 
            }
            else if (page == 3)
            {
                page = 5; 
            }
            else if (page == 7)
            {
                page = 5;
            }
            else if (page == 8)
            {
                page = 11; 
            }
            
            DisplayPage();
        }
        private void middleButton_Click(object sender, EventArgs e)
        {
            // middle button outcome 
            if (page == 2)
            {
                page = 3; 
            }
            else if (page== 6)
            {
                page = 99; 
            }
            else if (page == 9)
            {
                page = 100; 
            }
            else if (page == 10)
            {
                randomNumber = randGen.Next(1, 6);
                if (randomNumber == 5)
                {
                    page = 100;

                }
                else
                {
                    page = 99;
                }

            }
            else if (page == 11)
            {
                page = 99; 
            }
            else if (page == 12)
            {
                page = 8;
            }
            DisplayPage();
        }
        public void DisplayPage()
        {
            switch (page)
            {
               // start game 
                case 1:
                    imageOutput.Image = Properties.Resources.PG1;
                    outputLabel.Text = "Last Night's Adventure Game";
                    leftButton.Text = "Start";
                    rightButton.Text = "END GAME";
                    textBoxInput.Visible = false;
                    break;
                    // when the start to the adveture 
                    case 2:
                    SoundPlayer A2 = new SoundPlayer(Properties.Resources.A2);
                    A2.Play();
                    imageOutput.Image = Properties.Resources.PG2;
                    outputLabel.Visible = false;
                    textBoxInput.Visible = true;
                    middleButton.Visible = true;
                    leftButton.Text = $"Call phone number you have in your pocket";
                    rightButton.Text = $"You go home to your wife and don't tell her a thing";
                    middleButton.Text = $"Walk around and see where you are and how you might end up there";
                    textBoxInput.Text = $"You just woke up on the streets of downtown Toronto and don't remember a thing you did last night";
                    textBoxInput.Text += $"\n\n What do you do? "; 
                    break;
                    // when you are walking around page too see what happened last night 
                    case 3:
                    imageOutput.Image = Properties.Resources.PG3;
                    textBoxInput.Text = $"You walk around for a bit then you  find an alleyway that you remember from last night";
                    textBoxInput.Text += $"\n\n What do you do? ";
                    leftButton.Text = $"Keep looking around";
                    middleButton.Text = $"OR";
                    rightButton.Text = $"Go down it"; 
                    break;
                    //when you call the phone number page 
                    case 4:
                    imageOutput.Image = Properties.Resources.Good_PG4;
                    textBoxInput.Text = $"A girl picks up the phone and says \"hey SEXY when are you coming home to your new wife\" you say? ";
                  
                    leftButton.Text = "Can we meet and talk about what happened last night?";
                    middleButton.Text = $"OR";
                    rightButton.Text = $"Hey I am married. Who do you think you are talking to!"; 
                    break;
                    // when you go down the alliway page 
                case 5:
                    SoundPlayer ranGuy = new SoundPlayer(Properties.Resources.A99);
                    ranGuy.Play();
                    imageOutput.Image = Properties.Resources.PG5;
                    textBoxInput.Text = $"You are going down then out of the blue someone calls you by name and says \"you and Jessica had a great wedding\" and you are confused because that is not your wife's name. Then you realized what really happened that night!";
                    middleButton.Text = $"OR";
                    rightButton.Text = $"Deny what he says and go home";
                    leftButton.Text = $"Find out who Jessica is and go talk to her"; 
                    break;
                    //the outcome when you call the phone # and say " i am married"
                case 6:
                    imageOutput.Image = Properties.Resources.Good_PG6;
                    leftButton.Visible = false;
                    rightButton.Visible = false;
                    middleButton.Visible = false;
                    textBoxInput.Text = $"She yells \" YOU'RE MARRIED!! Your wife is going to love to here what we did last night\" then she hangs up the phone \n \n So when you got home...";
                    this.Refresh();
                    Thread.Sleep(2000);
                    middleButton.Visible = true;
                    middleButton.Text = $"PUSH BOTTON TO SEE WHAT HAPPENS";
                    page = 99;
                    break;
                    //this is the outcome of you keep looking around
                case 7:
                    imageOutput.Image = Properties.Resources.PG7;
                    middleButton.Text = $"OR";
                    textBoxInput.Text = $"You keep looking for a long time and don't recognized anything else. Do you?";
                    rightButton.Text = $"Go back to the alleyway";
                    leftButton.Text = $"Give up and go home"; 
                    break;
                    //this is what happens when you see Jessica
                case 8:
                   
                    leftButton.Visible = true;
                    rightButton.Visible = true;
                    middleButton.Visible = true;
                    imageOutput.Image = Properties.Resources.PG8;
                    leftButton.Text = $"Explain how sorry you are and say you were married to another person";
                    middleButton.Text = $"OR";
                    rightButton.Text = $"You say we are no longer married very angrily and leave and go home!";
                    textBoxInput.Text = "You find Jessica and you?"; 
                    break;
                    // when you cover up what happened 
                case 9:
                    leftButton.Visible = false;
                    rightButton.Visible = false;
                    middleButton.Visible = false;
                    textBoxInput.Text = $"She agrees to get divorce and not tell anyone what really happened that night then"; 
                   this.Refresh();
                    Thread.Sleep(1500);
                    middleButton.Visible = true;
                    middleButton.Text = $"Click here to see what happens nexts";
                    break;
                    // going home to see what happens 
                case 10:
                    leftButton.Visible = false;
                    rightButton.Visible = false;
                    middleButton.Visible = false;
                    textBoxInput.Text = $"you go home and...";
                    this.Refresh();
                    Thread.Sleep(1500);
                    middleButton.Visible = true;
                    middleButton.Text = $"Click here to see what happens next";
                    break;
                    case 11:
                    leftButton.Visible = false;
                    rightButton.Visible = false;
                    middleButton.Visible = false; 
                    textBoxInput.Text = $"You go home this happens...";
                    this.Refresh();
                    Thread.Sleep(1500);
                    middleButton.Visible = true;
                    middleButton.Text = $"Click here to see what happens next";
                    break;
                  //When you called here and asked her to meet 
                case 12:
                    leftButton.Visible = false;
                    rightButton.Visible = false;
                    middleButton.Visible = false;
                    textBoxInput.Text = $"She say yes";
                    this.Refresh();
                    Thread.Sleep(1500);
                    middleButton.Visible = true;
                    middleButton.Text = $"Click here to see what happens"; 
                    break; 
                //This is the good ending 
                case 100:
                    SoundPlayer youWin = new SoundPlayer(Properties.Resources.A100);
                    youWin.Play();
                    leftButton.Visible = true;
                    rightButton.Visible = true;
                    middleButton.Visible = true;
                    imageOutput.Image = Properties.Resources.PG100;
                    textBoxInput.Text = $"You go home to your wife and live happily ever after and she never knew what happened that day";
                    leftButton.Text = "";
                    middleButton.Text = "";
                    rightButton.Text = "";
                    rightButton.BackColor = Color.Green;
                    leftButton.BackColor = Color.Green;
                    middleButton.BackColor = Color.Green;
                    this.Refresh();
                    Thread.Sleep(5000);
                    rightButton.BackColor = Color.LightGray;
                    leftButton.BackColor = Color.LightGray;
                    middleButton.BackColor = Color.LightGray;
                    textBoxInput.Text = $"DO YOU WANT TO PLAY AGAIN";
                    leftButton.Text = "Yes";
                    middleButton.Text = "OR";
                    rightButton.Text = "No";
                    break;
                    // this is the bad ending 
                case 99:
                    SoundPlayer youlose = new SoundPlayer(Properties.Resources.A999);
                    youlose.Play(); 
                    leftButton.Visible = true;
                    rightButton.Visible = true;
                    middleButton.Visible = true; 
                    imageOutput.Image = Properties.Resources.PG99;
                    leftButton.Visible = true;
                    rightButton.Visible = true;
                    middleButton.Visible = true;
                    textBoxInput.Text = $"Your wife finds out what happened that night and you get a divorce then die of loneliness";
                    leftButton.Text = "";
                    middleButton.Text = "";
                    rightButton.Text = "";
                    rightButton.BackColor = Color.Red;
                    leftButton.BackColor = Color.Red;
                    middleButton.BackColor = Color.Red; 
                    this.Refresh();
                    Thread.Sleep(5000);
                    textBoxInput.Text = $"DO YOU WANT TO PLAY AGAIN";
                    leftButton.Text = "Yes";
                    middleButton.Text = "OR";
                    rightButton.Text = "No";
                    rightButton.BackColor = Color.LightGray;
                    leftButton.BackColor = Color.LightGray;
                    middleButton.BackColor = Color.LightGray;
                    break;
            }
        }

        
    }
}
