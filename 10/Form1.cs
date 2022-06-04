namespace _10
{
    public partial class Form1 : Form
    {
        //TURNS
        bool turn = true;
        byte turnCount = 0;
        bool checker;
        public Form1()
        {
            InitializeComponent();
        }

        //BUTTONS1-9
        private void butt1_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                butt1.Text = "X";
            }
            else butt1.Text = "O";
            {
                turn = !turn;
                turnCount++;
                butt1.Enabled = false;
            }
            if (checker == false)
            {
                checker = true;
            }
            else
            {
                checker = false;
                MessageBox.Show("OOO");
            }
        }
        private void butt2_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                butt2.Text = "X";
            }
            else butt2.Text = "O";
            {
                turn = !turn;
                turnCount++;
                butt2.Enabled = false;
            }
            if (checker == false)
            {
                checker = true;
            }
            else
            {
                checker = false;
                MessageBox.Show("OOO");
            }
        }

        private void butt3_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                butt3.Text = "X";
            }
            else butt3.Text = "O";
            {
                turn = !turn;
                turnCount++;
                butt3.Enabled = false;
            }
            if (checker == false)
            {
                checker = true;
            }
            else
            {
                checker = false;
                MessageBox.Show("OOO");
            }
        }

        private void butt4_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                butt4.Text = "X";
            }
            else butt4.Text = "O";
            {
                turn = !turn;
                turnCount++;
                butt4.Enabled = false;
            }
            if (checker == false)
            {
                checker = true;
            }
            else
            {
                checker = false;
                MessageBox.Show("OOO");
            }
        }

        private void butt5_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                butt5.Text = "X";
            }
            else butt5.Text = "O";
            {
                turn = !turn;
                turnCount++;
                butt5.Enabled = false;
            }
            if (checker == false)
            {
                checker = true;
            }
            else
            {
                checker = false;
                MessageBox.Show("OOO");
            }
        }

        private void butt6_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                butt6.Text = "X";
            }
            else butt6.Text = "O";
            {
                turn = !turn;
                turnCount++;
                butt6.Enabled = false;
            }

        }

        private void butt7_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                butt7.Text = "X";
            }
            else butt7.Text = "O";
            {
                turn = !turn;
                turnCount++;
                butt7.Enabled = false;
            }

        }

        private void butt8_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                butt8.Text = "X";
            }
            else butt8.Text = "O";
            {
                turn = !turn;
                turnCount++;
                butt8.Enabled = false;
            }

        }

        private void butt9_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                butt9.Text = "X";
            }
            else butt9.Text = "O";
            {
                turn = !turn;
                turnCount++;
                butt9.Enabled = false;
            }
        }

        //THEWHOLE
        private void Form1_Load(object sender, EventArgs e)
        {
            Button a = new Button();
            a.Text = "";
            a.Enabled = true;
            turnCount = 0;
            turn = true;
        }

        //RESTART
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
            {
                Button b = new Button();
                Restart = b;

                a.Enabled = true;
                a.Text = "";
            }
            turn = true;
            turnCount = 0;
        }

        //CHECKFORWINNER
        void check_Winner()
        {
            bool foraWinner = false;
            //DIAGONAL
            if ((butt1.Text == butt5.Text) && (butt5.Text == butt9.Text) && (butt1.Text != ""))
                foraWinner = true;
            else if ((butt3.Text == butt5.Text) && (butt5.Text == butt7.Text) && (butt5.Text != ""))
                foraWinner = true;

            //VERTICAL
            else if ((butt1.Text == butt4.Text) && (butt4.Text == butt7.Text) && (butt4.Text != ""))
                foraWinner = true;
            else if ((butt2.Text == butt5.Text) && (butt5.Text == butt8.Text) && (butt5.Text != ""))
                foraWinner = true;
            else if ((butt3.Text == butt6.Text) && (butt6.Text == butt9.Text) && (butt6.Text != ""))
                foraWinner = true;

            //HORIZONTAL
            else if ((butt1.Text == butt2.Text) && (butt2.Text == butt3.Text) && (butt1.Text != ""))
                foraWinner = true;
            else if ((butt4.Text == butt5.Text) && (butt5.Text == butt6.Text) && (butt4.Text != ""))
                foraWinner = true;
            else if ((butt7.Text == butt8.Text) && (butt8.Text == butt9.Text) && (butt7.Text != ""))
                foraWinner = true;

            if (foraWinner)
            {
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show("NANALO KA NG WASHING MACHINE!");
            }
            else if (turnCount == 9) ;
            {
                MessageBox.Show("It's a Draw" + "Click restart for a new game");


            }
        }
    }
}