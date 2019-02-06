using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        string playerTurn = "";
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetBtnTexts();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(btnStart.Text == "Start")
            {
                ChangeBtnsEnabled(true);

                optXstarts.Enabled = false;
                optOstarts.Enabled = false;

                CheckPlayerStart();

                pnlGame.Visible = true;
                btnStart.Text = "Stop";
            }
            else if(btnStart.Text == "Stop")
            {
                optXstarts.Enabled = true;
                optOstarts.Enabled = true;

                btnReset.PerformClick();
                lblStatus.Text = "Ready!";
                playerTurn = "";

                pnlGame.Visible = false;
                btnStart.Text = "Start";
            }
        }

        private void CheckPlayerStart()
        {
            if (optXstarts.Checked)
            {
                lblStatus.Text = "X's turn";
                playerTurn = "X";
            }
            else if (optOstarts.Checked)
            {
                lblStatus.Text = "O's turn";
                playerTurn = "O";
            }
        }

        private void TakeSelection(Control btn)
        {
            if (btn.Text == "")
            {
                if(playerTurn == "X")
                {
                    btn.ForeColor = Color.Red;
                    btn.Text = playerTurn;
                    playerTurn = "O";
                    lblStatus.Text = "O's turn";
                }
                else if(playerTurn == "O")
                {
                    btn.ForeColor = Color.Blue;
                    btn.Text = playerTurn;
                    playerTurn = "X";
                    lblStatus.Text = "X's turn";
                }

                if(PossibleWin())
                {
                    //Console.WriteLine("Possible win!");
                    if(CheckWin("X")) /* X won! */
                    {
                        ChangeBtnsEnabled(false);
                        lblStatus.Text = "X won!";
                        MessageBox.Show("X won!");
                    }
                    else if(CheckWin("O")) /* O won! */
                    {
                        ChangeBtnsEnabled(false);
                        lblStatus.Text = "O won!";
                        MessageBox.Show("O won!");
                    }
                    else
                    {
                        if(btnTopLeft.Text != "" && btnTopMiddle.Text != "" && btnTopRight.Text != "" &&
                            btnMiddleLeft.Text != "" && btnMiddle.Text != "" && btnMiddleRight.Text != "" &&
                            btnBottomLeft.Text != "" && btnBottomMiddle.Text != "" && btnBottomRight.Text != "") /* A tie! */
                        {
                            ChangeBtnsEnabled(false);
                            lblStatus.Text = "It's a tie!";
                            MessageBox.Show("It's a tie!");
                        }
                    }
                }
            }
        }

        private void ChangeBtnsEnabled(bool enabled)
        {
            btnTopLeft.Enabled = enabled;
            btnTopMiddle.Enabled = enabled;
            btnTopRight.Enabled = enabled;

            btnMiddleLeft.Enabled = enabled;
            btnMiddle.Enabled = enabled;
            btnMiddleRight.Enabled = enabled;

            btnBottomLeft.Enabled = enabled;
            btnBottomMiddle.Enabled = enabled;
            btnBottomRight.Enabled = enabled;
        }

        private bool PossibleWin()
        {
            if (btnTopLeft.Text != "" && btnTopMiddle.Text != "" && btnTopRight.Text != "") /* Top line full */
                return true;
            if (btnMiddleLeft.Text != "" && btnMiddle.Text != "" && btnMiddleRight.Text != "") /* Middle line full */
                return true;
            if (btnBottomLeft.Text != "" && btnBottomMiddle.Text != "" && btnBottomRight.Text != "") /* Bottom line full */
                return true;
            if (btnTopLeft.Text != "" && btnMiddle.Text != "" && btnBottomRight.Text != "") /* Top left to bottom right cross */
                return true;
            if (btnBottomLeft.Text != "" && btnMiddle.Text != "" && btnTopRight.Text != "") /* Bottom left to top right cross  */
                return true;
            if (btnTopLeft.Text != "" && btnMiddleLeft.Text != "" && btnBottomLeft.Text != "") /* Top left to bottom full */
                return true;
            if (btnTopMiddle.Text != "" && btnMiddle.Text != "" && btnBottomMiddle.Text != "") /* Top middle to bottom full */
                return true;
            if (btnTopRight.Text != "" && btnMiddleRight.Text != "" && btnBottomRight.Text != "") /* Top right to bottom full */
                return true;

            return false;
        }

        private bool CheckWin(string player)
        {
            if (btnTopLeft.Text == player && btnTopMiddle.Text == player && btnTopRight.Text == player) /* Top line full */
                return true;
            if (btnMiddleLeft.Text == player && btnMiddle.Text == player && btnMiddleRight.Text == player) /* Middle line full */
                return true;
            if (btnBottomLeft.Text == player && btnBottomMiddle.Text == player && btnBottomRight.Text == player) /* Bottom line full */
                return true;
            if (btnTopLeft.Text == player && btnMiddle.Text == player && btnBottomRight.Text == player) /* Top left to bottom right cross */
                return true;
            if (btnBottomLeft.Text == player && btnMiddle.Text == player && btnTopRight.Text == player) /* Bottom left to top right cross  */
                return true;
            if (btnTopLeft.Text == player && btnMiddleLeft.Text == player && btnBottomLeft.Text == player) /* Top left to bottom full */
                return true;
            if (btnTopMiddle.Text == player && btnMiddle.Text == player && btnBottomMiddle.Text == player) /* Top middle to bottom full */
                return true;
            if (btnTopRight.Text == player && btnMiddleRight.Text == player && btnBottomRight.Text == player) /* Top right to bottom full */
                return true;

            return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBtnTexts();
            ChangeBtnsEnabled(true);

            if (optXstarts.Checked)
            {
                optXstarts.Checked = false;
                optOstarts.Checked = true;

                lblStatus.Text = "O's turn";
            }
            else if(optOstarts.Checked)
            {
                optXstarts.Checked = true;
                optOstarts.Checked = false;

                lblStatus.Text = "X's turn";
            }

            CheckPlayerStart();
        }

        private void ResetBtnTexts()
        {
            btnTopLeft.Text = "";
            btnTopMiddle.Text = "";
            btnTopRight.Text = "";

            btnMiddleLeft.Text = "";
            btnMiddle.Text = "";
            btnMiddleRight.Text = "";

            btnBottomLeft.Text = "";
            btnBottomMiddle.Text = "";
            btnBottomRight.Text = "";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if(c.Text == "")
                TakeSelection((Control)sender);
        }
    }
}
