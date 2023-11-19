namespace TimerApp2
{
    public partial class Form1 : Form
    {
        static int max1 = 0;
        static int n = 0;
        static int bgn = 0;
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer t2 = new System.Windows.Forms.Timer();
        public Form1()
        {
            t1.Interval = 20000;
            t1.Enabled = true;
            t1.Tick += new EventHandler(t_Tick);

            t2.Interval = 2000;
            t2.Enabled = true;
            t2.Tick += new EventHandler(changeBG);
            InitializeComponent();
        }
        private void t_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Score: " + n.ToString() + " Max:" + max1.ToString());
            max1 += n;
            n = 0;
        }
        private void changeBG(object sender, EventArgs e)
        {
            bgn += 1;
            if (bgn == 1)
            {
                this.BackColor = Color.Black;
            }
            else if (bgn == 2)
            {
                this.BackColor = Color.Red;
            }
            else if (bgn == 3)
            {
                this.BackColor = Color.Yellow;
            }
            else if (bgn == 4)
            {
                this.BackColor = Color.Green;
            }
            else if (bgn == 5)
            {
                this.BackColor = Color.Cyan;
            }
            else if (bgn == 6)
            {
                this.BackColor = Color.Blue;
            }
            else if (bgn == 7)
            {
                this.BackColor = Color.Pink;
            }
            else if (bgn == 8)
            {
                this.BackColor = Color.White;
            }
            else bgn = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            n += 1;
        }

        private void form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
