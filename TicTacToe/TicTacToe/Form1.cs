using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //False = "X", True = "O";
        public bool player = false;
        public bool isWinner;

        //This keeps track of how many turns there is
        public int turn = 1;
        public int xWins = 0;
        public int oWins = 0;

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (player && button.Text == "")
            {
                button.Text = "O";
                player = !player;
                lblPlayer.Text = "It is player X's turn.";
            }
            else if (button.Text == "")
            {
                button.Text = "X";
                player = !player;
                lblPlayer.Text = "It is player O's turn.";
            }

            button.Enabled = false;
            check();
            turn++;
        }

        public void check()
        {
            //Horizontal checking
            if (btnTL.Text == btnTM.Text && btnTM.Text == btnTR.Text && !btnTL.Enabled)  //Top
                isWinner = true;
            else if (btnCL.Text == btnCM.Text && btnCM.Text == btnCR.Text && !btnCL.Enabled) //Center
                isWinner = true;
            else if (btnBL.Text == btnBM.Text && btnBM.Text == btnBR.Text && !btnBL.Enabled) //Bottom
                isWinner = true;

            //Vertical checking
            if (btnTL.Text == btnCL.Text && btnCL.Text == btnBL.Text && !btnTL.Enabled) //Left
                isWinner = true;
            else if (btnTM.Text == btnCM.Text && btnCM.Text == btnBM.Text && !btnTM.Enabled) //Middle
                isWinner = true;
            else if (btnTR.Text == btnCR.Text && btnCR.Text == btnBR.Text && !btnTR.Enabled) //Right
                isWinner = true;

            //Diagonal checking
            if (btnTL.Text == btnCM.Text && btnCM.Text == btnBR.Text && !btnTL.Enabled) //Backward
                isWinner = true;
            else if (btnTR.Text == btnCM.Text && btnCM.Text == btnBL.Text && !btnTR.Enabled) //Forward
                isWinner = true;
                

            if (isWinner)
            {
                disableControls();

                if (player != true)
                {
                    oWins++;
                    lblPlayer.Text = "O has won!";
                    lblOWins.Text = oWins.ToString();
                    MessageBox.Show("O has won!");
                }
                else
                {
                    xWins++;
                    lblPlayer.Text = "X has won!";
                    lblXWins.Text = xWins.ToString();
                    MessageBox.Show("X has won!");
                }
            }
            else if (turn == 9) //This is only if the board is filled with no winner
            {
                lblPlayer.Text = "It was a tie!";
                MessageBox.Show("It was a tie!");
            }
        }

        private void btnnewGame_Click(object sender, EventArgs e)
        {
            newGame();
        }

        public void newGame()
        {
            btnTL.Text = "";
            btnTM.Text = "";
            btnTR.Text = "";

            btnCL.Text = "";
            btnCM.Text = "";
            btnCR.Text = "";

            btnBL.Text = "";
            btnBM.Text = "";
            btnBR.Text = "";

            foreach (Control button in this.Controls)
            {
                button.Enabled = true;
            }

            isWinner = false;
            turn = 1;
            player = false;
            lblPlayer.Text = "It is player X's turn.";
        }

        public void disableControls()
        {
            btnTL.Enabled = false;
            btnTM.Enabled = false;
            btnTR.Enabled = false;

            btnCL.Enabled = false;
            btnCM.Enabled = false;
            btnCR.Enabled = false;

            btnBL.Enabled = false;
            btnBM.Enabled = false;
            btnBR.Enabled = false;

            lblPlayer.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xWins = 0;
            oWins = 0;
            lblXWins.Text = "0";
            lblOWins.Text = "0";

            newGame();
        }
    }
}