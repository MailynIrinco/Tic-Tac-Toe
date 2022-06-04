namespace _10
{
    public partial class Form1 : Form
    {
        //TURNS
        bool turn = true;
        byte turnCount = 0;
      
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
            //Diagonal
            if (butt1.Text == butt5.Text)
            {
                if (butt5.Text == butt9.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");

            }
            //Vertical
            if (butt1.Text == butt4.Text)
            {
                if (butt4.Text == butt7.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
            }
            //Hori
            if (butt1.Text == butt2.Text)
            {
                if (butt2.Text == butt3.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
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
            //Vertical
            if (butt2.Text == butt5.Text)
            {
                if (butt5.Text == butt8.Text)
                   MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
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
            //Vertical
            if (butt3.Text == butt6.Text)
            {
                if (butt6.Text == butt9.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
            }
            //Diagonal
            if (butt3.Text == butt5.Text)
            {
                if (butt5.Text == butt7.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
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
            //Hori
            if (butt4.Text == butt5.Text)
            {
                if (butt5.Text == butt6.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
            }
            //Vert
            if (butt1.Text == butt4.Text)
            {
                if (butt4.Text == butt7.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
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
            //Vertical
            if (butt4.Text == butt5.Text)
            {
                if (butt5.Text == butt6.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
            }
            //Diagonal
            if (butt1.Text == butt5.Text)
            {
                if (butt5.Text == butt9.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");

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
            if (butt4.Text == butt5.Text)
            {
                if (butt5.Text == butt6.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
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
            //Vertical
            if (butt7.Text == butt8.Text)
            {
                if (butt8.Text == butt9.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
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
            if (butt2.Text == butt5.Text)
            {
                if (butt5.Text == butt8.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
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
            if (butt1.Text == butt5.Text)
            {
                if (butt5.Text == butt9.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!","WINNER YARN!");
            }
            if (butt3.Text == butt6.Text)
            {
                if (butt6.Text == butt9.Text)
                    MessageBox.Show("BIGYAN NG WASHING MACHINE YAN!", "WINNER YARN!");
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
    }
}