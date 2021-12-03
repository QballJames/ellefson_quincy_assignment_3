using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ellefson_quincy_assignment_3
{
    public partial class gameForm : Form
    {
        int countTurns = 0;
        bool whoseTurn = true;//True is p1 turn and false is p2 turn
        public gameForm()
        {
            InitializeComponent();
        }
        public gameForm(string p1choseName, //declaring all the strings and colors to get from setupform
            string p2choseName,
            Color p1TileColor,
            Color p1cColor,
            Color p2TileColor,
            Color p2SelectedIconColor,
            string p1SelectedIcon,
            string p2SelectedIcon
            )
        {
            InitializeComponent();
            lblp1Name.Text = p1choseName;
            lblp1Name.BackColor = p1TileColor;

            p1Icon.Text = p1SelectedIcon;
            p1Icon.BackColor = p1TileColor;
            p1Icon.ForeColor = p1cColor;

            p2Name.Text = p2choseName;
            p2Name.BackColor = p2TileColor;

            p2Icon.Text = p2SelectedIcon;
            p2Icon.BackColor = p2TileColor;
            p2Icon.ForeColor = p2SelectedIconColor;

        }
        public string p1choseName { get; set; }
        public string p2choseName { get; set; }
        public Color p1TileColor { get; set; }
        public Color p1cColor { get; set; }
        public Color p2TileColor { get; set; }
        public Color p2SelectedIconColor { get; set; } 
        public string p1SelectedIcon { get; set; }
        public string p2SelectedIcon { get; set; }

        private void gameForm_Load(object sender, EventArgs e)
        {
            lblPlayerTurn.Text = lblp1Name.Text +"'s Turn!";
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            if (whoseTurn == true)//player1 Turn
            {
                lblPlayerTurn.BackColor = p1TileColor;
                lblPlayerTurn.Text = p2Name.Text +"'s turn.";
                l.Text = p1Icon.Text;
                l.BackColor = p1Icon.BackColor;
                l.ForeColor = p1Icon.ForeColor;
                l.Enabled = false;
                whoseTurn = false;
                countTurns++;//adds to the int countTurns in case there is a draw
            }
            else if (whoseTurn == false)//player2 Turn
            {
                lblPlayerTurn.BackColor = p2TileColor;
                lblPlayerTurn.Text =  (lblp1Name.Text+ "'s turn.");
                l.Text = p2Icon.Text;
                l.BackColor = p2Icon.BackColor;
                l.ForeColor = p2Icon.ForeColor;
                l.Enabled = false;
                whoseTurn = true;
                countTurns++;//adds to the int countTurns in case there is a draw
            }
            checkWin();//calls checkWin function
        }

        private void checkWin()
        {
            bool gameOver = false;//Bool for if there is a winner or not

            //Check if someone has won, I couldnt find a better way to do this
            if ((label1.Text == label2.Text) && (label2.Text == label3.Text)&& (label1.Enabled ==false))
                gameOver = true;
            else if ((label4.Text == label5.Text) && (label5.Text == label6.Text) && (label4.Enabled == false))
                gameOver = true;
            else if ((label7.Text == label8.Text) && (label8.Text == label9.Text) && (label7.Enabled == false))
                gameOver = true;
            else if ((label1.Text == label4.Text) && (label4.Text == label7.Text) && (label1.Enabled == false))
                gameOver = true;
            else if ((label2.Text == label5.Text) && (label5.Text == label8.Text) && (label2.Enabled == false))
                gameOver = true;
            else if ((label3.Text == label6.Text) && (label6.Text == label9.Text) && (label3.Enabled == false))
                gameOver = true;
            else if ((label1.Text == label5.Text) && (label5.Text == label9.Text) && (label1.Enabled == false))
                gameOver = true;
            else if ((label7.Text == label5.Text) && (label5.Text == label3.Text) && (label7.Enabled == false))
                gameOver = true;


            if (gameOver == true)
            {
                if (whoseTurn == true)
                {
                    lblPlayerTurn.BackColor = p2Icon.BackColor;
                    lblPlayerTurn.Text = (p2Name.Text + " has won!! Congratulations!");


                    //Disable all labels so you can't play any more turns
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;

                    //Enable the exit button
                    exitButton.Enabled = true;
                }
                else if (whoseTurn == false)
                {
                    lblPlayerTurn.BackColor = p1Icon.BackColor;
                    lblPlayerTurn.Text = (lblp1Name.Text + " has won!! Congratulations!");

                    //Disable all labels so you can't play any more turns
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;

                    //Enable the exit button
                    exitButton.Enabled = true;
                }
                else
                {
                    if(countTurns == 9)
                    {
                        lblPlayerTurn.Text = ("This match was a draw!");

                        //enable the exit button
                        exitButton.Enabled = true;
                    }
                }

            }
        }

        private void lblp1Name_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
