namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Turn turn = Turn.Player1;
        byte count = 0;
        bool GameOver = false;
        byte countX = 0;
        byte countO = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClck(sender);
            Check();
            if (count == 9 && !GameOver)
            {
                MessageBox.Show("Draw!");
            }
        }

        private void Check()
        {
            count++;
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "" ||
                 button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "" ||
                 button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "" ||
                 button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "" ||
                 button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "" ||
                 button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "" ||
                 button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "" ||
                 button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
            {
                if (turn == Turn.Player1)
                {
                    MessageBox.Show(Turn.Player2.ToString() + " win!");
                    countO++;
                    label4.Text = "O: " + countO;
                }
                else
                {
                    MessageBox.Show(Turn.Player1.ToString() + " win!");
                    countX++;
                    label3.Text = "X: " + countX;
                }
                GameOver = true;
            }
        }

        private void ButtonClck(object sender)
        {
            Button button = (Button)sender;

            if (turn == Turn.Player1)
            {
                button.Text = "X";
                button.Enabled = false;
                label2.Text = "O";
                turn = Turn.Player2;
            }
            else
            {
                button.Text = "O";
                button.Enabled = false;
                label2.Text = "X";
                turn = Turn.Player1;
            }
        }

        enum Turn
        {
            Player1,
            Player2
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = button2.Text = button3.Text = button4.Text = "";
            button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";

            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;
            button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;

            label2.Text = "X";
            turn = Turn.Player1;
            count = 0;
            GameOver = false;
        }
    }
}