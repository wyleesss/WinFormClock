namespace _2004_ПВ222_КозарН
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}