namespace Breakout
{
    public partial class breakout : Form
    {
        int easy = 0;
        int mid = 0;
        int hard = 0;
        Rectangle player = new Rectangle(10, 170, 10, 60);
        Rectangle ball = new Rectangle(295, 195, 10, 10);
        Rectangle square1 = new Rectangle(295,250, 10, 10);
        Rectangle square2 = new Rectangle(305,250,10, 10);
        Rectangle square3 = new Rectangle(285,250,10,10);
        Rectangle square4 = new Rectangle(275, 250, 10, 10);
        int playerSpeed = 7;
        int ballXSpeed = 0;
        int ballYSpeed = 0;



        public breakout()
        {
            InitializeComponent();
        }

        private void easybutton_Click(object sender, EventArgs e)
        {
            easybutton.Visible = false;
            midButton.Visible = false;
            hardButton.Visible = false;
            easy = 1;
            gameStart();


        }

        private void midButton_Click(object sender, EventArgs e)
        {
            easybutton.Visible = false;
            hardButton.Visible = false;
            midButton.Visible = false;
            mid = 1;
            gameStart();

        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easybutton.Visible = false; hardButton.Visible = false; midButton.Visible = false;
            hard = 1;
            gameStart();
        }
        private void gameStart()
        {

        }

        private void breakout_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
        }

        private void breakout_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void breakout_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
