using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_11_Tic_Tac_Toe_GUI
{
    public partial class Form1 : Form
    {
        bool turn = true;
        Button[,] board = new Button[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 3; i++)
            {
               
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = new Button();         
                    board[i, j].Location = new Point(i*75,j*75);
                    board[i, j].Width = 80;
                    board[i, j].Height = 80;
                    board[i, j].Click += buttonArray_Click;
                    groupBox1.Controls.Add(board[i, j]);
                   

                }
            }
        }

        private void buttonArray_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            if (turn)
            {
                temp.Text = "X";
                
            }
            else
            {
                temp.Text = "O";
                
            }
            turn = !turn;
            temp.Enabled = false;

            winner();
        }
        private void winner()
        {
            //Horizontal
            bool checkWin = false;
            if ((board[0,0].Text == board[0,1].Text) && (board[0,1].Text == board[0, 2].Text) && !board[0,0].Enabled)
                checkWin = true;
            if ((board[1, 0].Text == board[1, 1].Text) && (board[1, 1].Text == board[1, 2].Text) && !board[1,0].Enabled)
                checkWin = true;
            if ((board[2, 0].Text == board[2, 1].Text) && (board[2, 1].Text == board[2, 2].Text) && !board[2, 0].Enabled)
                checkWin = true;
            // Vertical
            if ((board[0, 0].Text == board[1, 0].Text) && (board[1, 0].Text == board[2, 0].Text) && !board[0, 0].Enabled)
                checkWin = true;
            if ((board[0, 1].Text == board[1, 1].Text) && (board[1, 1].Text == board[2, 1].Text) && !board[0, 1].Enabled)
                checkWin = true;
            if ((board[0, 2].Text == board[1, 2].Text) && (board[1, 2].Text == board[2, 2].Text) && !board[0, 2].Enabled)
                checkWin = true;
            //Diagnoal
            if ((board[0, 0].Text == board[1, 1].Text) && (board[1, 1].Text == board[2, 2].Text) && !board[0, 0].Enabled)
                checkWin = true;
            if ((board[2, 0].Text == board[1, 1].Text) && (board[1, 1].Text == board[0, 2].Text) && !board[2, 0].Enabled)
                checkWin = true;
          

            if (checkWin)
            {
                string champion = "";
                if (turn)
                    champion = "O";
                else
                    champion = "X";
                MessageBox.Show("Winner is " + champion);
               
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j].Text = "";
                    board[i, j].Enabled = true;
                }
            }
        }
    }
}
