using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnTurn_Click(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnTurn_Click(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnTurn_Click(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnTurn_Click(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnTurn_Click(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnTurn_Click(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnTurn_Click(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnTurn_Click(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnTurn_Click(btn9);
        }
        private void btnTurn_Click(Button x)
        {
            if(x.Text == "")
            {
                if (lblTurn.Text == "O")
                {
                    x.Text = "O";
                    x.Enabled = false;
                    lblTurn.Text = "X";
                    Win("O");
                }
                else
                {
                    x.Text = "X";
                    x.Enabled = false;
                    lblTurn.Text = "O";
                    Win("X");
                }
            }
           
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblTurn.Text = "O";
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btnEnabled(true);
            resetColor();
            lblStatus.Text = "Turn";
            btnNewGame.TabStop = false;
        }
        private void btnEnabled(Boolean x)
        {
            btn1.Enabled = x;
            btn2.Enabled = x;
            btn3.Enabled = x;
            btn4.Enabled = x;
            btn5.Enabled = x;
            btn6.Enabled = x;
            btn7.Enabled = x;
            btn8.Enabled = x;
            btn9.Enabled = x;
        }
        private void resetColor()
        {
            btn1.BackColor = Color.DarkGray;
            btn2.BackColor = Color.DarkGray;
            btn3.BackColor = Color.DarkGray;
            btn4.BackColor = Color.DarkGray;
            btn5.BackColor = Color.DarkGray;
            btn6.BackColor = Color.DarkGray;
            btn7.BackColor = Color.DarkGray;
            btn8.BackColor = Color.DarkGray;
            btn9.BackColor = Color.DarkGray;
            pnlUpper.BackColor = Color.White;
            pnlMain.BackColor = Color.White;
            this.BackColor = Color.White;
        }
        private void Win(string x)
        {
            if(btn1.Text == x && btn2.Text == x && btn3.Text == x)
            {
                btn1.BackColor = Color.Blue;
                btn2.BackColor = Color.Blue;
                btn3.BackColor = Color.Blue;
                btnEnabled(false);
                winner(x);
            }
            if (btn4.Text == x && btn5.Text == x && btn6.Text == x)
            {
                btn4.BackColor = Color.Blue;
                btn5.BackColor = Color.Blue;
                btn6.BackColor = Color.Blue;
                btnEnabled(false);
                winner(x);
            }
            if (btn7.Text == x && btn8.Text == x && btn9.Text == x)
            {
                btn7.BackColor = Color.Blue;
                btn8.BackColor = Color.Blue;
                btn9.BackColor = Color.Blue;
                btnEnabled(false);
                winner(x);
            }

            //
            if (btn1.Text == x && btn4.Text == x && btn7.Text == x)
            {
                btn1.BackColor = Color.Blue;
                btn4.BackColor = Color.Blue;
                btn7.BackColor = Color.Blue;
                btnEnabled(false);
                winner(x);
            }
            if (btn2.Text == x && btn5.Text == x && btn8.Text == x)
            {
                btn2.BackColor = Color.Blue;
                btn5.BackColor = Color.Blue;
                btn8.BackColor = Color.Blue;
                btnEnabled(false);
                winner(x);
            }
            if (btn3.Text == x && btn6.Text == x && btn9.Text == x)
            {
                btn3.BackColor = Color.Blue;
                btn6.BackColor = Color.Blue;
                btn9.BackColor = Color.Blue;
                btnEnabled(false);
                winner(x);
            }
            //

            if (btn1.Text == x && btn5.Text == x && btn9.Text == x)
            {
                btn1.BackColor = Color.Blue;
                btn5.BackColor = Color.Blue;
                btn9.BackColor = Color.Blue;
                btnEnabled(false);
                winner(x);
            }
            if (btn3.Text == x && btn5.Text == x && btn7.Text == x)
            {
                btn3.BackColor = Color.Blue;
                btn5.BackColor = Color.Blue;
                btn7.BackColor = Color.Blue;
                btnEnabled(false);
                winner(x);
            }
            
        }
        private void winner(string x)
        {
            lblTurn.Text = x;
            lblStatus.Text = "Winner";
            pnlUpper.BackColor = Color.FromArgb(128, 128, 255);
            pnlMain.BackColor = Color.FromArgb(128, 128, 255);
            this.BackColor = Color.FromArgb(128, 128, 255);
            btnNewGame.TabStop = true;
            if (x == "O")
            {
                int OScore = Convert.ToInt32(lblOScore.Text);
                lblOScore.Text = Convert.ToString(OScore + 1);
            }
            else
            {
                int XScore = Convert.ToInt32(lblXScore.Text);
                lblXScore.Text = Convert.ToString(XScore + 1);
            }
            
            System.Media.SystemSounds.Exclamation.Play();
        }
    }
}
