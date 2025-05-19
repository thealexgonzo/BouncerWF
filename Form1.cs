namespace BouncerWF
{
    public partial class Form1 : Form
    {
        Ball ball = new Ball();
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ball.Update();
            ball.Display(e.Graphics);
        }
    }
}
