using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//int PlayNum = 0;


namespace WindowsFormsApplication4
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Look of the program on start up
            InitializeComponent();
            
            pictureBoxPlayer1OP1.Visible = false;
            pictureBoxPlayer1OP2.Visible = false;
            pictureBoxPlayer1OP3.Visible = false;
            pictureBoxPlayer1OP4.Visible = false;
            pictureBoxPlayer1OP5.Visible = false;
            pictureBoxPlayer1OP6.Visible = false;
            pictureBoxPlayer1OP7.Visible = false;
            pictureBoxPlayer1OP8.Visible = false;
            pictureBoxPlayer1OP9.Visible = false;
            pictureBoxPlayer1OP10.Visible = false;
            pictureBoxPlayer1OP11.Visible = false;
            pictureBoxPlayer1OP12.Visible = false;
            pictureBoxPlayer1OP13.Visible = false;
            pictureBoxPlayer1OP14.Visible = false;
            pictureBoxPlayer1OP15.Visible = false;
            pictureBoxPlayer1OP16.Visible = false;
            pictureBoxPlayer1OP17.Visible = false;
            pictureBoxPlayer1OP18.Visible = false;

            pictureBoxPlayer2OP1.Visible = false;
            pictureBoxPlayer2OP2.Visible = false;
            pictureBoxPlayer2OP3.Visible = false;
            pictureBoxPlayer2OP4.Visible = false;
            pictureBoxPlayer2OP5.Visible = false;
            pictureBoxPlayer2OP6.Visible = false;
            pictureBoxPlayer2OP7.Visible = false;
            pictureBoxPlayer2OP8.Visible = false;
            pictureBoxPlayer2OP9.Visible = false;
            pictureBoxPlayer2OP10.Visible = false;
            pictureBoxPlayer2OP11.Visible = false;
            pictureBoxPlayer2OP12.Visible = false;
            pictureBoxPlayer2OP13.Visible = false;
            pictureBoxPlayer2OP14.Visible = false;
            pictureBoxPlayer2OP15.Visible = false;
            pictureBoxPlayer2OP16.Visible = false;
            pictureBoxPlayer2OP17.Visible = false;
            pictureBoxPlayer2OP18.Visible = false;

            pictureBoxPlayer3OP1.Visible = false;
            pictureBoxPlayer3OP2.Visible = false;
            pictureBoxPlayer3OP3.Visible = false;
            pictureBoxPlayer3OP4.Visible = false;
            pictureBoxPlayer3OP5.Visible = false;
            pictureBoxPlayer3OP6.Visible = false;
            pictureBoxPlayer3OP7.Visible = false;
            pictureBoxPlayer3OP8.Visible = false;
            pictureBoxPlayer3OP9.Visible = false;
            pictureBoxPlayer3OP10.Visible = false;
            pictureBoxPlayer3OP11.Visible = false;
            pictureBoxPlayer3OP12.Visible = false;
            pictureBoxPlayer3OP13.Visible = false;
            pictureBoxPlayer3OP14.Visible = false;
            pictureBoxPlayer3OP15.Visible = false;
            pictureBoxPlayer3OP16.Visible = false;
            pictureBoxPlayer3OP17.Visible = false;
            pictureBoxPlayer3OP18.Visible = false;

            pictureBoxPlayer4OP1.Visible = false;
            pictureBoxPlayer4OP2.Visible = false;
            pictureBoxPlayer4OP3.Visible = false;
            pictureBoxPlayer4OP4.Visible = false;
            pictureBoxPlayer4OP5.Visible = false;
            pictureBoxPlayer4OP6.Visible = false;
            pictureBoxPlayer4OP7.Visible = false;
            pictureBoxPlayer4OP8.Visible = false;
            pictureBoxPlayer4OP9.Visible = false;
            pictureBoxPlayer4OP10.Visible = false;
            pictureBoxPlayer4OP11.Visible = false;
            pictureBoxPlayer4OP12.Visible = false;
            pictureBoxPlayer4OP13.Visible = false;
            pictureBoxPlayer4OP14.Visible = false;
            pictureBoxPlayer4OP15.Visible = false;
            pictureBoxPlayer4OP16.Visible = false;
            pictureBoxPlayer4OP17.Visible = false;
            pictureBoxPlayer4OP18.Visible = false;

            pictureBoxPlayer5OP1.Visible = false;
            pictureBoxPlayer5OP2.Visible = false;
            pictureBoxPlayer5OP3.Visible = false;
            pictureBoxPlayer5OP4.Visible = false;
            pictureBoxPlayer5OP5.Visible = false;
            pictureBoxPlayer5OP6.Visible = false;
            pictureBoxPlayer5OP7.Visible = false;
            pictureBoxPlayer5OP8.Visible = false;
            pictureBoxPlayer5OP9.Visible = false;
            pictureBoxPlayer5OP10.Visible = false;
            pictureBoxPlayer5OP11.Visible = false;
            pictureBoxPlayer5OP12.Visible = false;
            pictureBoxPlayer5OP13.Visible = false;
            pictureBoxPlayer5OP14.Visible = false;
            pictureBoxPlayer5OP15.Visible = false;
            pictureBoxPlayer5OP16.Visible = false;
            pictureBoxPlayer5OP17.Visible = false;
            pictureBoxPlayer5OP18.Visible = false;

            pictureBoxPlayer2.Visible = false;
            pictureBoxPlayer3.Visible = false;
            pictureBoxPlayer4.Visible = false;
            pictureBoxPlayer5.Visible = false;
            labelPlayer2.Visible = false;
            labelPlayer3.Visible = false;
            labelPlayer4.Visible = false;
            labelPlayer5.Visible = false;
        }


        //Select Att or Def
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                //Att
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                //Def
                pictureBoxSmoke.Visible = true;
                pictureBoxMute.Visible = true;
                pictureBoxCastle.Visible = true;
                pictureBoxPulse.Visible = true;
                pictureBoxDoc.Visible = true;
                pictureBoxRook.Visible = true;
                pictureBoxKapkan.Visible = true;
                pictureBoxTachanka.Visible = true;
                pictureBoxJager.Visible = true;
                pictureBoxBandit.Visible = true;
                pictureBoxFrost.Visible = true;
                pictureBoxValkyrie.Visible = true;
                pictureBoxCaveira.Visible = true;
                pictureBoxEcho.Visible = true;
                pictureBoxMira.Visible = true;
                pictureBoxLesion.Visible = true;
                pictureBoxEla.Visible = true;
                pictureBoxVigil.Visible = true;

            }        
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;

                //Def
                pictureBoxSmoke.Visible = false;
                pictureBoxMute.Visible = false;
                pictureBoxCastle.Visible = false;
                pictureBoxPulse.Visible = false;
                pictureBoxDoc.Visible = false;
                pictureBoxRook.Visible = false;
                pictureBoxKapkan.Visible = false;
                pictureBoxTachanka.Visible = false;
                pictureBoxJager.Visible = false;
                pictureBoxBandit.Visible = false;
                pictureBoxFrost.Visible = false;
                pictureBoxValkyrie.Visible = false;
                pictureBoxCaveira.Visible = false;
                pictureBoxEcho.Visible = false;
                pictureBoxMira.Visible = false;
                pictureBoxLesion.Visible = false;
                pictureBoxEla.Visible = false;
                pictureBoxVigil.Visible = false;
            }
        }


       
       
        //Select Player count
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal PlayNum = 0;
            PlayNum = numericUpDown1.Value;

            pictureBoxPlayer2.Visible = false;
            pictureBoxPlayer3.Visible = false;
            pictureBoxPlayer4.Visible = false;
            pictureBoxPlayer5.Visible = false;
            labelPlayer2.Visible = false;
            labelPlayer3.Visible = false;
            labelPlayer4.Visible = false;
            labelPlayer5.Visible = false;

            if (PlayNum >= 2)
                    pictureBoxPlayer2.Visible = true;
                    labelPlayer2.Visible = true;
                if (PlayNum >= 3)
                    pictureBoxPlayer3.Visible = true;
                    labelPlayer3.Visible = true;
                if (PlayNum >= 4)
                    pictureBoxPlayer4.Visible = true;
                    labelPlayer4.Visible = true;
                if (PlayNum >= 5)
                    pictureBoxPlayer5.Visible = true;
                    labelPlayer5.Visible = true;

        }
    

    private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer1OPjoker.Visible = false;
            pictureBoxPlayer1OP1.Visible = false;
            pictureBoxPlayer1OP2.Visible = false;
            pictureBoxPlayer1OP3.Visible = false;
            pictureBoxPlayer1OP4.Visible = false;
            pictureBoxPlayer1OP5.Visible = false;
            pictureBoxPlayer1OP6.Visible = false;
            pictureBoxPlayer1OP7.Visible = false;
            pictureBoxPlayer1OP8.Visible = false;
            pictureBoxPlayer1OP9.Visible = false;
            pictureBoxPlayer1OP10.Visible = false;
            pictureBoxPlayer1OP11.Visible = false;
            pictureBoxPlayer1OP12.Visible = false;
            pictureBoxPlayer1OP13.Visible = false;
            pictureBoxPlayer1OP14.Visible = false;
            pictureBoxPlayer1OP15.Visible = false;
            pictureBoxPlayer1OP16.Visible = false;
            pictureBoxPlayer1OP17.Visible = false;
            pictureBoxPlayer1OP18.Visible = false;

            pictureBoxPlayer2OPjoker.Visible = false;
            pictureBoxPlayer2OP1.Visible = false;
            pictureBoxPlayer2OP2.Visible = false;
            pictureBoxPlayer2OP3.Visible = false;
            pictureBoxPlayer2OP4.Visible = false;
            pictureBoxPlayer2OP5.Visible = false;
            pictureBoxPlayer2OP6.Visible = false;
            pictureBoxPlayer2OP7.Visible = false;
            pictureBoxPlayer2OP8.Visible = false;
            pictureBoxPlayer2OP9.Visible = false;
            pictureBoxPlayer2OP10.Visible = false;
            pictureBoxPlayer2OP11.Visible = false;
            pictureBoxPlayer2OP12.Visible = false;
            pictureBoxPlayer2OP13.Visible = false;
            pictureBoxPlayer2OP14.Visible = false;
            pictureBoxPlayer2OP15.Visible = false;
            pictureBoxPlayer2OP16.Visible = false;
            pictureBoxPlayer2OP17.Visible = false;
            pictureBoxPlayer2OP18.Visible = false;

            pictureBoxPlayer3OPjoker.Visible = false;
            pictureBoxPlayer3OP1.Visible = false;
            pictureBoxPlayer3OP2.Visible = false;
            pictureBoxPlayer3OP3.Visible = false;
            pictureBoxPlayer3OP4.Visible = false;
            pictureBoxPlayer3OP5.Visible = false;
            pictureBoxPlayer3OP6.Visible = false;
            pictureBoxPlayer3OP7.Visible = false;
            pictureBoxPlayer3OP8.Visible = false;
            pictureBoxPlayer3OP9.Visible = false;
            pictureBoxPlayer3OP10.Visible = false;
            pictureBoxPlayer3OP11.Visible = false;
            pictureBoxPlayer3OP12.Visible = false;
            pictureBoxPlayer3OP13.Visible = false;
            pictureBoxPlayer3OP14.Visible = false;
            pictureBoxPlayer3OP15.Visible = false;
            pictureBoxPlayer3OP16.Visible = false;
            pictureBoxPlayer3OP17.Visible = false;
            pictureBoxPlayer3OP18.Visible = false;

            pictureBoxPlayer4OPjoker.Visible = false;
            pictureBoxPlayer4OP1.Visible = false;
            pictureBoxPlayer4OP2.Visible = false;
            pictureBoxPlayer4OP3.Visible = false;
            pictureBoxPlayer4OP4.Visible = false;
            pictureBoxPlayer4OP5.Visible = false;
            pictureBoxPlayer4OP6.Visible = false;
            pictureBoxPlayer4OP7.Visible = false;
            pictureBoxPlayer4OP8.Visible = false;
            pictureBoxPlayer4OP9.Visible = false;
            pictureBoxPlayer4OP10.Visible = false;
            pictureBoxPlayer4OP11.Visible = false;
            pictureBoxPlayer4OP12.Visible = false;
            pictureBoxPlayer4OP13.Visible = false;
            pictureBoxPlayer4OP14.Visible = false;
            pictureBoxPlayer4OP15.Visible = false;
            pictureBoxPlayer4OP16.Visible = false;
            pictureBoxPlayer4OP17.Visible = false;
            pictureBoxPlayer4OP18.Visible = false;

            pictureBoxPlayer5OPjoker.Visible = false;
            pictureBoxPlayer5OP1.Visible = false;
            pictureBoxPlayer5OP2.Visible = false;
            pictureBoxPlayer5OP3.Visible = false;
            pictureBoxPlayer5OP4.Visible = false;
            pictureBoxPlayer5OP5.Visible = false;
            pictureBoxPlayer5OP6.Visible = false;
            pictureBoxPlayer5OP7.Visible = false;
            pictureBoxPlayer5OP8.Visible = false;
            pictureBoxPlayer5OP9.Visible = false;
            pictureBoxPlayer5OP10.Visible = false;
            pictureBoxPlayer5OP11.Visible = false;
            pictureBoxPlayer5OP12.Visible = false;
            pictureBoxPlayer5OP13.Visible = false;
            pictureBoxPlayer5OP14.Visible = false;
            pictureBoxPlayer5OP15.Visible = false;
            pictureBoxPlayer5OP16.Visible = false;
            pictureBoxPlayer5OP17.Visible = false;
            pictureBoxPlayer5OP18.Visible = false;


            decimal PlayNum = 0;
            int RanNum = 0;
            int[] PlayRan =  new int[] {0,0,0,0,0,0};


            //PlayNum = numericUpDown1.Value;

            PlayNum = Convert.ToInt32(numericUpDown1.Value);
            int i = 0;
            int t;

            while (i <= PlayNum)
            {
                t = 0;
                Random Ran = new Random();
               RanNum  = Ran.Next(0, 19); //form 0 to 18 (19-1)

                if (RanNum == 0)
                {
                  //  PlayRan[i] = RanNum;

                    //i++;
                }
                else
                {
                    while (t <= 5)
                 {
                   if (RanNum == PlayRan[t])
                    {
                        Random Rand = new Random();
                        RanNum = Rand.Next(0, 19);
                        t = 0;
                    }
                    t++;
                 }
                }
                PlayRan[i] = RanNum;

                i++;
                }

            if (PlayNum >= 1)
            {
                switch(PlayRan[1])
  {
                    case 0:
                        pictureBoxPlayer1OPjoker.Visible = true;
                        break;
                    case 1:
                        pictureBoxPlayer1OP1.Visible = true;
                        break;
                    case 2:
                        pictureBoxPlayer1OP2.Visible = true;
                        break;
                    case 3:
                         pictureBoxPlayer1OP3.Visible = true;
                        break;
                    case 4:
pictureBoxPlayer1OP4.Visible = true;
                        break;
                    case 5:
pictureBoxPlayer1OP5.Visible = true;
                        break;
                    case 6:
pictureBoxPlayer1OP6.Visible = true;
                        break;
                    case 7:
pictureBoxPlayer1OP7.Visible = true;
                        break;
                    case 8:
pictureBoxPlayer1OP8.Visible = true;
                        break;
                    case 9:
pictureBoxPlayer1OP9.Visible = true;
                        break;
                    case 10:
pictureBoxPlayer1OP10.Visible = true;
                        break;
                    case 11:
pictureBoxPlayer1OP11.Visible = true;
                        break;
                    case 12:
pictureBoxPlayer1OP12.Visible = true;
                        break;
                    case 13:
pictureBoxPlayer1OP13.Visible = true;
                        break;
                    case 14:
pictureBoxPlayer1OP14.Visible = true;
                        break;
                    case 15:
pictureBoxPlayer1OP15.Visible = true;
                        break;
                    case 16:
pictureBoxPlayer1OP16.Visible = true;
                        break;
                    case 17:
pictureBoxPlayer1OP17.Visible = true;
                        break;
                    case 18:
pictureBoxPlayer1OP18.Visible = true;
                        break;
                }
            }
            if (PlayNum >= 2)
            {
                switch (PlayRan[2])
                {
                    case 0:
                        pictureBoxPlayer2OPjoker.Visible = true;
                        break;
                    case 1:
pictureBoxPlayer2OP1.Visible = true;
                break;
                case 2:
pictureBoxPlayer2OP2.Visible = true;
                break;
                case 3:
pictureBoxPlayer2OP3.Visible = true;
                break;
                case 4:
pictureBoxPlayer2OP4.Visible = true;
                break;
                case 5:
pictureBoxPlayer2OP5.Visible = true;
                break;
                case 6:
pictureBoxPlayer2OP6.Visible = true;
                break;
                case 7:
pictureBoxPlayer2OP7.Visible = true;
                break;
                case 8:
pictureBoxPlayer2OP8.Visible = true;
                break;
                case 9:
pictureBoxPlayer2OP9.Visible = true;
                break;
                case 10:
pictureBoxPlayer2OP10.Visible = true;
                break;
                case 11:
pictureBoxPlayer2OP11.Visible = true;
                break;
                case 12:
pictureBoxPlayer2OP12.Visible = true;
                break;
                case 13:
pictureBoxPlayer2OP13.Visible = true;
                break;
                case 14:
pictureBoxPlayer2OP14.Visible = true;
                break;
                case 15:
pictureBoxPlayer2OP15.Visible = true;
                break;
                case 16:
pictureBoxPlayer2OP16.Visible = true;
                break;
                case 17:
pictureBoxPlayer2OP17.Visible = true;
                break;
                case 18:
pictureBoxPlayer2OP18.Visible = true;
                break;
                }
            }
            if (PlayNum >= 3)
            {
                switch (PlayRan[3])
                {
                    case 0:
                        pictureBoxPlayer3OPjoker.Visible = true;
                        break;
                    case 1:
pictureBoxPlayer3OP1.Visible = true;
                break;
                case 2:
pictureBoxPlayer3OP2.Visible = true;
                break;
                case 3:
pictureBoxPlayer3OP3.Visible = true;
                break;
                case 4:
pictureBoxPlayer3OP4.Visible = true;
                break;
                case 5:
pictureBoxPlayer3OP5.Visible = true;
                break;
                case 6:
pictureBoxPlayer3OP6.Visible = true;
                break;
                case 7:
pictureBoxPlayer3OP7.Visible = true;
                break;
                case 8:
pictureBoxPlayer3OP8.Visible = true;
                break;
                case 9:
pictureBoxPlayer3OP9.Visible = true;
                break;
                case 10:
pictureBoxPlayer3OP10.Visible = true;
                break;
                case 11:
pictureBoxPlayer3OP11.Visible = true;
                break;
                case 12:
pictureBoxPlayer3OP12.Visible = true;
                break;
                case 13:
pictureBoxPlayer3OP13.Visible = true;
                break;
                case 14:
pictureBoxPlayer3OP14.Visible = true;
                break;
                case 15:
pictureBoxPlayer3OP15.Visible = true;
                break;
                case 16:
pictureBoxPlayer3OP16.Visible = true;
                break;
                case 17:
pictureBoxPlayer3OP17.Visible = true;
                break;
                case 18:
pictureBoxPlayer3OP18.Visible = true;
                break;
                }
            }
            if (PlayNum >= 4)
            {
                switch (PlayRan[4])
                {
                    case 0:
                        pictureBoxPlayer4OPjoker.Visible = true;
                        break;
                    case 1:
pictureBoxPlayer4OP1.Visible = true;
                break;
                case 2:
pictureBoxPlayer4OP2.Visible = true;
                break;
                case 3:
pictureBoxPlayer4OP3.Visible = true;
                break;
                case 4:
pictureBoxPlayer4OP4.Visible = true;
                break;
                case 5:
pictureBoxPlayer4OP5.Visible = true;
                break;
                case 6:
pictureBoxPlayer4OP6.Visible = true;
                break;
                case 7:
pictureBoxPlayer4OP7.Visible = true;
                break;
                case 8:
pictureBoxPlayer4OP8.Visible = true;
                break;
                case 9:
pictureBoxPlayer4OP9.Visible = true;
                break;
                case 10:
pictureBoxPlayer4OP10.Visible = true;
                break;
                case 11:
pictureBoxPlayer4OP11.Visible = true;
                break;
                case 12:
pictureBoxPlayer4OP12.Visible = true;
                break;
                case 13:
pictureBoxPlayer4OP13.Visible = true;
                break;
                case 14:
pictureBoxPlayer4OP14.Visible = true;
                break;
                case 15:
pictureBoxPlayer4OP15.Visible = true;
                break;
                case 16:
pictureBoxPlayer4OP16.Visible = true;
                break;
                case 17:
pictureBoxPlayer4OP17.Visible = true;
                break;
                case 18:
pictureBoxPlayer4OP18.Visible = true;
                break;
                }
            }
            if (PlayNum >= 5)
            {
                switch (PlayRan[5])
                {
                    case 0:
                        pictureBoxPlayer5OPjoker.Visible = true;
                        break;
                    case 1:
pictureBoxPlayer4OP1.Visible = true;
                break;
                case 2:
pictureBoxPlayer4OP2.Visible = true;
                break;
                case 3:
pictureBoxPlayer4OP3.Visible = true;
                break;
                case 4:
pictureBoxPlayer4OP4.Visible = true;
                break;
                case 5:
pictureBoxPlayer4OP5.Visible = true;
                break;
                case 6:
pictureBoxPlayer4OP6.Visible = true;
                break;
                case 7:
pictureBoxPlayer4OP7.Visible = true;
                break;
                case 8:
pictureBoxPlayer4OP8.Visible = true;
                break;
                case 9:
pictureBoxPlayer4OP9.Visible = true;
                break;
                case 10:
pictureBoxPlayer4OP10.Visible = true;
                break;
                case 11:
pictureBoxPlayer4OP11.Visible = true;
                break;
                case 12:
pictureBoxPlayer4OP12.Visible = true;
                break;
                case 13:
pictureBoxPlayer4OP13.Visible = true;
                break;
                case 14:
pictureBoxPlayer4OP14.Visible = true;
                break;
                case 15:
pictureBoxPlayer4OP15.Visible = true;
                break;
                case 16:
pictureBoxPlayer4OP16.Visible = true;
                break;
                case 17:
pictureBoxPlayer4OP17.Visible = true;
                break;
                case 18:
pictureBoxPlayer4OP18.Visible = true;
                break;
                }
            }



        }
    }
}
