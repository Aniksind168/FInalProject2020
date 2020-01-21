using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSystemServices;
using System.Threading;
using System.Media;

namespace FInalProject2020
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //player2 button control keys - DO NOT CHANGE
        Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown;

        string[] tokens = new string[43];

        int player = 1;


        private void circle1_1_Click(object sender, EventArgs e)
        {
            if (circle1_1.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle1_1.BackColor = Color.Red;
                    player = 2;
                    tokens[1] = "Red";

                }

                else if (player == 2)
                {
                    playerLabel.Text = "Player 2";
                    circle1_1.BackColor = Color.Yellow;
                    player = 1;
                    tokens[1] = "Yellow";

                }

                int redToken = 0;
                int yellowToken = 0;


                for (int i = 1; i <= 7; i++)
                {

                    if (tokens[i] == "red")
                    {
                        redToken++;
                        yellowToken = 0;
                    }
                    else if (tokens[i] == "yellow")
                    {
                        yellowToken++;
                        redToken = 0;

                    }
                    else
                    {
                        redToken = 0;
                        yellowToken = 0;

                    }


                    if (redToken == 4)
                    {
                        connect4.Text = "Player 1 Wins";


                    }
                    else if (yellowToken == 4)
                    {

                        connect4.Text = "Player 2 Wins";
                    }




                }


            }

        }
        private void circle1_2_Click(object sender, EventArgs e)
        {

            if (circle1_2.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle1_2.BackColor = Color.Red;
                    player = 2;
                    tokens[2] = "Red";
                }

                else if (player == 2)
                {
                    playerLabel.Text = "Player 2";
                    circle1_2.BackColor = Color.Yellow;
                    player = 1;
                    tokens[2] = "Yellow";

                }
            }


        }
        private void circle1_3_Click(object sender, EventArgs e)
        {
            if (circle1_3.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle1_3.BackColor = Color.Red;
                    player = 2;
                    tokens[3] = "Red";
                }

                else if (player == 2)
                {
                    circle1_3.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[3] = "Yellow";
                }

            }

        }


        private void circle1_4_Click(object sender, EventArgs e)
        {
            if (circle1_4.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle1_4.BackColor = Color.Red;
                    player = 2;
                    tokens[4] = "Red";
                }

                else if (player == 2)
                {
                    circle1_4.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[4] = "Yellow";
                }
            }
        }


        private void circle1_5_Click(object sender, EventArgs e)
        {
            if (circle1_5.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle1_5.BackColor = Color.Red;
                    player = 2;
                    tokens[5] = "Red";
                }

                else if (player == 2)
                {
                    circle1_5.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[5] = "Red";
                }
            }
        }

        private void circle1_6_Click(object sender, EventArgs e)
        {
            if (circle1_6.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle1_6.BackColor = Color.Red;
                    player = 2;
                    tokens[6] = "Red";
                }

                else if (player == 2)
                {
                    circle1_6.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[6] = "Yellow";
                }
            }
        }

        private void circle1_7_Click(object sender, EventArgs e)
        {
            if (circle1_7.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle1_7.BackColor = Color.Red;
                    player = 2;
                    tokens[7] = "Red";
                }

                else if (player == 2)
                {
                    circle1_7.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[7] = "Yellow";

                }
            }
        }

        private void circle2_1_Click(object sender, EventArgs e)
        {
            if (circle2_1.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle2_1.BackColor = Color.Red;
                    player = 2;
                    tokens[8] = "Red";
                }

                else if (player == 2)
                {
                    circle2_1.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[8] = "Yellow";

                }
            }
        }

        private void circle2_2_Click(object sender, EventArgs e)
        {
            if (circle2_2.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle2_2.BackColor = Color.Red;
                    player = 2;
                    tokens[9] = "Red";
                }

                else if (player == 2)
                {
                    circle2_2.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[9] = "Yellow";
                }
            }
        }

        private void circle2_3_Click(object sender, EventArgs e)
        {
            if (circle2_3.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle2_3.BackColor = Color.Red;
                    player = 2;
                    tokens[10] = "Red";
                }

                else if (player == 2)
                {
                    circle2_3.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[10] = "Yellow";
                }
            }
        }

        private void circle2_4_Click(object sender, EventArgs e)
        {
            if (circle2_4.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle2_4.BackColor = Color.Red;
                    player = 2;
                    tokens[11] = "Red";
                }

                else if (player == 2)
                {
                    circle2_4.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[11] = "Yellow";
                }
            }
        }

        private void circle2_5_Click(object sender, EventArgs e)
        {
            if (circle2_5.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle2_5.BackColor = Color.Red;
                    player = 2;
                    tokens[12] = "Red";
                }

                else if (player == 2)
                {
                    circle2_5.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[12] = "Yellow";
                }
            }
        }

        private void circle2_6_Click(object sender, EventArgs e)
        {
            if (circle2_6.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle2_6.BackColor = Color.Red;
                    player = 2;
                    tokens[13] = "Red";
                }

                else if (player == 2)
                {
                    circle2_6.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[13] = "Yellow";
                }
            }
        }

        private void circle2_7_Click(object sender, EventArgs e)
        {
            if (circle2_7.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle2_7.BackColor = Color.Red;
                    player = 2;
                    tokens[14] = "Red";
                }

                else if (player == 2)
                {
                    circle2_7.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[14] = "Yellow";
                }
            }
        }

        private void circle3_1_Click(object sender, EventArgs e)
        {
            if (circle3_1.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle3_1.BackColor = Color.Red;
                    player = 2;
                    tokens[15] = "Red";
                }

                else if (player == 2)
                {
                    circle3_1.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[15] = "Yellow";
                }
            }
        }

        private void circle3_2_Click(object sender, EventArgs e)
        {
            if (circle3_2.BackColor == Color.Black)
            {
                if (player == 1)
                {
                    playerLabel.Text = "Player 1";
                    circle3_2.BackColor = Color.Red;
                    player = 2;
                    tokens[16] = "Red";
                }

                else if (player == 2)
                {
                    circle3_2.BackColor = Color.Yellow;
                    playerLabel.Text = "Player 2";
                    player = 1;
                    tokens[16] = "Yellow";

                }
            }
        }

        private void circle3_3_Click(object sender, EventArgs e)
        {
            {
                if (circle3_3.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle3_3.BackColor = Color.Red;
                        player = 2;
                        tokens[17] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle3_3.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[17] = "Yellow";
                    }
                }
            }
        }

        private void circle3_4_Click(object sender, EventArgs e)
        {
            {
                if (circle3_4.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle3_4.BackColor = Color.Red;
                        player = 2;
                        tokens[18] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle3_4.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[18] = "Yellow";
                    }
                }
            }
        }

        private void circle3_5_Click(object sender, EventArgs e)
        {
            {
                if (circle3_5.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle3_5.BackColor = Color.Red;
                        player = 2;
                        tokens[19] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle3_5.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[19] = "Yellow";
                    }
                }
            }
        }

        private void circle3_6_Click(object sender, EventArgs e)
        {
            {
                if (circle3_6.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle3_6.BackColor = Color.Red;
                        player = 2;
                        tokens[20] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle3_6.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[20] = "Yellow";
                    }
                }
            }
        }

        private void circle3_7_Click(object sender, EventArgs e)
        {
            {
                if (circle3_7.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle3_7.BackColor = Color.Red;
                        player = 2;
                        tokens[21] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle3_7.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[21] = "Yellow";
                    }
                }
            }
        }

        private void circle4_1_Click(object sender, EventArgs e)
        {
            {
                if (circle4_1.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle4_1.BackColor = Color.Red;
                        player = 2;
                        tokens[22] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle4_1.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[22] = "Yellow";
                    }
                }
            }
        }

        private void circle4_2_Click(object sender, EventArgs e)
        {
            {
                if (circle4_2.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle4_2.BackColor = Color.Red;
                        player = 2;
                        tokens[23] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle4_2.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[23] = "Yellow";
                    }
                }
            }
        }

        private void circle4_3_Click(object sender, EventArgs e)
        {
            {
                if (circle4_3.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle4_3.BackColor = Color.Red;
                        player = 2;
                        tokens[24] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle4_3.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[24] = "Yellow";
                    }
                }
            }
        }

        private void circle4_4_Click(object sender, EventArgs e)
        {
            {
                if (circle4_4.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle4_4.BackColor = Color.Red;
                        player = 2;
                        tokens[25] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle4_4.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[25] = "Yellow";
                    }
                }
            }
        }

        private void circle4_5_Click(object sender, EventArgs e)
        {
            {
                if (circle4_5.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle4_5.BackColor = Color.Red;
                        player = 2;
                        tokens[26] = "Red";

                    }

                    else if (player == 2)
                    {
                        circle4_5.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[26] = "Yellow";

                    }
                }
            }
        }

        private void circle4_6_Click(object sender, EventArgs e)
        {
            {
                if (circle4_6.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle4_6.BackColor = Color.Red;
                        player = 2;
                        tokens[27] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle4_6.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[27] = "Yellow";
                    }
                }
            }
        }

        private void circle4_7_Click(object sender, EventArgs e)
        {
            {
                if (circle4_7.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle4_7.BackColor = Color.Red;
                        player = 2;
                        tokens[28] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle4_7.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[28] = "Yellow";
                    }
                }
            }
        }

        private void circle5_1_Click(object sender, EventArgs e)
        {
            {
                if (circle5_1.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle5_1.BackColor = Color.Red;
                        player = 2;
                        tokens[29] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle5_1.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[29] = "Yellow";
                    }
                }
            }
        }

        private void circle5_2_Click(object sender, EventArgs e)
        {
            {
                if (circle5_2.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle5_2.BackColor = Color.Red;
                        player = 2;
                        tokens[30] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle5_2.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[30] = "Yellow";
                    }
                }
            }
        }

        private void circle5_3_Click(object sender, EventArgs e)
        {
            {
                if (circle5_3.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle5_3.BackColor = Color.Red;
                        player = 2;
                        tokens[31] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle5_3.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[31] = "Yellow";

                    }
                }
            }
        }

        private void circle5_4_Click(object sender, EventArgs e)
        {
            {
                if (circle5_4.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle5_4.BackColor = Color.Red;
                        player = 2;
                        tokens[32] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle5_4.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[32] = "Yellow";
                    }
                }
            }
        }

        private void circle5_5_Click(object sender, EventArgs e)
        {

            {
                if (circle5_5.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle5_5.BackColor = Color.Red;
                        player = 2;
                        tokens[33] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle5_5.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[33] = "Yellow";
                    }
                }
            }
        }

        private void circle5_6_Click(object sender, EventArgs e)
        {
            {
                if (circle5_6.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle5_6.BackColor = Color.Red;
                        player = 2;
                        tokens[34] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle5_6.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[34] = "Yellow";
                    }
                }
            }
        }

        private void circle5_7_Click(object sender, EventArgs e)
        {
            {
                if (circle5_7.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle5_7.BackColor = Color.Red;
                        player = 2;
                        tokens[35] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle5_7.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[35] = "Yellow";
                    }
                }
            }
        }

        private void circle6_1_Click(object sender, EventArgs e)
        {
            {
                if (circle6_1.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle6_1.BackColor = Color.Red;
                        player = 2;
                        tokens[36] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle6_1.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[36] = "Yellow";
                    }
                }
            }
        }

        private void circle6_2_Click(object sender, EventArgs e)
        {
            {
                if (circle6_2.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle6_2.BackColor = Color.Red;
                        player = 2;
                        tokens[37] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle6_2.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[37] = "Yellow";
                    }
                }
            }
        }

        private void circle6_3_Click(object sender, EventArgs e)
        {
            {
                if (circle6_3.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle6_3.BackColor = Color.Red;
                        player = 2;
                        tokens[38] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle6_3.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[38] = "Yellow";
                    }
                }
            }
        }

        private void circle6_4_Click(object sender, EventArgs e)
        {
            {
                if (circle6_4.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle6_4.BackColor = Color.Red;
                        player = 2;
                        tokens[39] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle6_4.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[39] = "Yellow";
                    }
                }
            }
        }

        private void circle6_5_Click(object sender, EventArgs e)
        {
            {
                if (circle6_5.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle6_5.BackColor = Color.Red;
                        player = 2;
                        tokens[40] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle6_5.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[40] = "Yellow";
                    }
                }
            }
        }

        private void circle6_6_Click(object sender, EventArgs e)
        {
            {
                if (circle6_6.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle6_6.BackColor = Color.Red;
                        player = 2;
                        tokens[41] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle6_6.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[41] = "Yellow";
                    }
                }
            }
        }

        private void circle6_7_Click(object sender, EventArgs e)
        {
            {
                if (circle6_7.BackColor == Color.Black)
                {
                    if (player == 1)
                    {
                        playerLabel.Text = "Player 1";
                        circle6_7.BackColor = Color.Red;
                        player = 2;
                        tokens[42] = "Red";
                    }

                    else if (player == 2)
                    {
                        circle6_7.BackColor = Color.Yellow;
                        playerLabel.Text = "Player 2";
                        player = 1;
                        tokens[42] = "Yellow";
                    }
                }
            }
        }



        private void restartButton_Click(object sender, EventArgs e)
        {
            circle1_1.BackColor = Color.Black;
            circle1_2.BackColor = Color.Black;
            circle1_3.BackColor = Color.Black;


        }

        private void startButton_Click(object sender, EventArgs e)
        {
            playerLabel.BackColor = Color.White;
            playerLabel.ForeColor = Color.Black;
            connect4.ForeColor = Color.MediumBlue;
            startButton.Visible = false;
        }


        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        //TODO create your global game variables here
        int heroX, heroY, heroSize, heroSpeed;
        SolidBrush heroBrush = new SolidBrush(Color.Black);

        public GameScreen()
        {
            InitializeComponent();
            InitializeGameValues();
        }

        public void InitializeGameValues()
        {
            //TODO - setup all your initial game values here. Use this method
            // each time you restart your game to reset all values.
            heroX = 100;
            heroY = 100;
            heroSize = 20;
            heroSpeed = 5;
            tokens[0] = "extra";
            tokens[1] = "black";
            tokens[2] = "black";
            tokens[3] = "black";
            tokens[4] = "black";
            tokens[5] = "black";
            tokens[6] = "black";
            tokens[7] = "black";
            tokens[8] = "black";
            tokens[9] = "black";
            tokens[10] = "black";
            tokens[11] = "black";
            tokens[12] = "black";
            tokens[13] = "black";
            tokens[14] = "black";
            tokens[15] = "black";
            tokens[16] = "black";
            tokens[17] = "black";
            tokens[18] = "black";
            tokens[19] = "black";
            tokens[20] = "black";
            tokens[21] = "black";
            tokens[22] = "black";
            tokens[23] = "black";
            tokens[24] = "black";
            tokens[25] = "black";
            tokens[26] = "black";
            tokens[27] = "black";
            tokens[28] = "black";
            tokens[29] = "black";
            tokens[30] = "black";
            tokens[31] = "black";
            tokens[32] = "black";
            tokens[33] = "black";
            tokens[34] = "black";
            tokens[35] = "black";
            tokens[36] = "black";
            tokens[37] = "black";
            tokens[38] = "black";
            tokens[39] = "black";
            tokens[40] = "black";
            tokens[41] = "black";
            tokens[42] = "black";
            tokens[43] = "black";
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // opens a pause screen is escape is pressed. Depending on what is pressed
            // on pause screen the program will either continue or exit to main menu
            if (e.KeyCode == Keys.Escape && gameTimer.Enabled)
            {
                gameTimer.Enabled = false;
                rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

                DialogResult result = PauseForm.Show();

                if (result == DialogResult.Cancel)
                {
                    gameTimer.Enabled = true;
                }
                else if (result == DialogResult.Abort)
                {
                    MainForm.ChangeScreen(this, "MenuScreen");
                }
            }

            //TODO - basic player 1 key down bools set below. Add remainging key down
            // required for player 1 or player 2 here.

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //TODO - basic player 1 key up bools set below. Add remainging key up
            // required for player 1 or player 2 here.

            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        /// <summary>
        /// This is the Game Engine and repeats on each interval of the timer. For example
        /// if the interval is set to 16 then it will run each 16ms or approx. 50 times
        /// per second
        /// </summary>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //TODO move main character 
            if (leftArrowDown == true)
            {
                heroX = heroX - heroSpeed;
            }
            if (downArrowDown == true)
            {
                heroY = heroY + heroSpeed;
            }
            if (rightArrowDown == true)
            {
                heroX = heroX + heroSpeed;
            }
            if (upArrowDown == true)
            {
                heroY = heroY - heroSpeed;
            }

            //TODO move npc characters


            //TODO collisions checks 


            //calls the GameScreen_Paint method to draw the screen.
            Refresh();
        }


        //Everything that is to be drawn on the screen should be done here
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw rectangle to screen
            //e.Graphics.FillRectangle(heroBrush, heroX, heroY, heroSize, heroSize);
        }

        public void Win()
        {
            int redToken = 0;
            int yellowToken = 0;


            for (int i = 1; i <= 7; i++)
            {

                if (tokens[i] == "red")
                {
                    redToken++;
                    yellowToken = 0;
                }
                else if (tokens[i] == "yellow")
                {
                    yellowToken++;
                    redToken = 0;

                }
                else
                {
                    redToken = 0;
                    yellowToken = 0;

                }

                if (redToken == 4)
                {
                    connect4.Text = "Player 1 Wins";


                }
                else if (yellowToken == 4)
                {

                    connect4.Text = "Player 2 Wins";
                }

            }

            for (int i = 8; i <= 14; i++)
            {

                if (tokens[i] == "red")
                {
                    redToken++;
                    yellowToken = 0;
                }
                else if (tokens[i] == "yellow")
                {
                    yellowToken++;
                    redToken = 0;

                }
                else
                {
                    redToken = 0;
                    yellowToken = 0;

                }

                if (redToken == 4)
                {
                    connect4.Text = "Player 1 Wins";


                }
                else if (yellowToken == 4)
                {

                    connect4.Text = "Player 2 Wins";
                }

            }

            for (int i = 15; i <= 21; i++)
            {

                if (tokens[i] == "red")
                {
                    redToken++;
                    yellowToken = 0;
                }
                else if (tokens[i] == "yellow")
                {
                    yellowToken++;
                    redToken = 0;

                }
                else
                {
                    redToken = 0;
                    yellowToken = 0;

                }

                if (redToken == 4)
                {
                    connect4.Text = "Player 1 Wins";


                }
                else if (yellowToken == 4)
                {

                    connect4.Text = "Player 2 Wins";
                }

            }

            for (int i = 22; i <= 29; i++)
            {

                if (tokens[i] == "red")
                {
                    redToken++;
                    yellowToken = 0;
                }
                else if (tokens[i] == "yellow")
                {
                    yellowToken++;
                    redToken = 0;

                }
                else
                {
                    redToken = 0;
                    yellowToken = 0;

                }

                if (redToken == 4)
                {
                    connect4.Text = "Player 1 Wins";


                }
                else if (yellowToken == 4)
                {

                    connect4.Text = "Player 2 Wins";
                }

            }

        }
    }

}
