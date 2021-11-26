using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        void score()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.Orchid;
                btn2.BackColor = Color.Orchid;
                btn3.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.Orchid;
                btn4.BackColor = Color.Orchid;
                btn7.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Orchid;
                btn5.BackColor = Color.Orchid;
                btn9.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.Orchid;
                btn5.BackColor = Color.Orchid;
                btn7.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.Orchid;
                btn5.BackColor = Color.Orchid;
                btn8.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.Orchid;
                btn6.BackColor = Color.Orchid;
                btn9.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.Orchid;
                btn5.BackColor = Color.Orchid;
                btn6.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Orchid;
                btn8.BackColor = Color.Orchid;
                btn9.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            // ================================================================================================================

            if (btn1.Text == "0" && btn2.Text == "0" && btn3.Text == "0")
            {
                btn1.BackColor = Color.Orchid;
                btn2.BackColor = Color.Orchid;
                btn3.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn1.Text == "0" && btn4.Text == "0" && btn7.Text == "0")
            {
                btn1.BackColor = Color.Orchid;
                btn4.BackColor = Color.Orchid;
                btn7.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn1.Text == "0" && btn5.Text == "0" && btn9.Text == "0")
            {
                btn1.BackColor = Color.Orchid;
                btn5.BackColor = Color.Orchid;
                btn9.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn3.Text == "0" && btn5.Text == "0" && btn7.Text == "0")
            {
                btn3.BackColor = Color.Orchid;
                btn5.BackColor = Color.Orchid;
                btn7.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn2.Text == "0" && btn5.Text == "0" && btn8.Text == "0")
            {
                btn2.BackColor = Color.Orchid;
                btn5.BackColor = Color.Orchid;
                btn8.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn3.Text == "0" && btn6.Text == "0" && btn9.Text == "0")
            {
                btn3.BackColor = Color.Orchid;
                btn6.BackColor = Color.Orchid;
                btn9.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn4.Text == "0" && btn5.Text == "0" && btn6.Text == "0")
            {
                btn4.BackColor = Color.Orchid;
                btn5.BackColor = Color.Orchid;
                btn6.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn7.Text == "0" && btn8.Text == "0" && btn9.Text == "0")
            {
                btn7.BackColor = Color.Orchid;
                btn8.BackColor = Color.Orchid;
                btn9.BackColor = Color.Orchid;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn1.Text = "X";
                checker = true;
            }

            else
            {
                btn1.Text = "0";
                checker = false;
            }

            score();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn2.Text = "X";
                checker = true;
            }

            else
            {
                btn2.Text = "0";
                checker = false;
            }

            score();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn3.Text = "X";
                checker = true;
            }

            else
            {
                btn3.Text = "0";
                checker = false;
            }

            score();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn4.Text = "X";
                checker = true;
            }

            else
            {
                btn4.Text = "0";
                checker = false;
            }

            score();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn5.Text = "X";
                checker = true;
            }

            else
            {
                btn5.Text = "0";
                checker = false;
            }

            score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn6.Text = "X";
                checker = true;
            }

            else
            {
                btn6.Text = "0";
                checker = false;
            }

            score();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn7.Text = "X";
                checker = true;
            }

            else
            {
                btn7.Text = "0";
                checker = false;
            }

            score();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn8.Text = "X";
                checker = true;
            }

            else
            {
                btn8.Text = "0";
                checker = false;
            }

            score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn9.Text = "X";
                checker = true;
            }

            else
            {
                btn9.Text = "0";
                checker = false;
            }

            score();
            btn9.Enabled = false;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            try
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;

                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";

                label4.Text = "0";
                label5.Text = "0";

                btn1.BackColor = Color.WhiteSmoke;
                btn2.BackColor = Color.WhiteSmoke;
                btn3.BackColor = Color.WhiteSmoke;
                btn4.BackColor = Color.WhiteSmoke;
                btn5.BackColor = Color.WhiteSmoke;
                btn6.BackColor = Color.WhiteSmoke;
                btn7.BackColor = Color.WhiteSmoke;
                btn8.BackColor = Color.WhiteSmoke;
                btn9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            try
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;

                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";

                btn10.Enabled = true;

                btn1.BackColor = Color.WhiteSmoke;
                btn2.BackColor = Color.WhiteSmoke;
                btn3.BackColor = Color.WhiteSmoke;
                btn4.BackColor = Color.WhiteSmoke;
                btn5.BackColor = Color.WhiteSmoke;
                btn6.BackColor = Color.WhiteSmoke;
                btn7.BackColor = Color.WhiteSmoke;
                btn8.BackColor = Color.WhiteSmoke;
                btn9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "Tic Tac Toe",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }

                else if (iExit == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
