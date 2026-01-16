namespace Breakout
{
    public partial class breakout : Form
    {
        bool buttonPressed = false;
        bool DDown = false;
        bool ADown = false;

        int easy = 0;
        int mid = 0;
        int hard = 0;
        Rectangle player = new Rectangle(350, 400, 60, 10);
        Rectangle ball = new Rectangle(295, 195, 10, 10);
        Rectangle square1 = new Rectangle(295, 100, 50, 20);
        Rectangle square2 = new Rectangle(345, 100, 50, 20);
        Rectangle square3 = new Rectangle(395, 100, 50, 10);
        Rectangle square4 = new Rectangle(445, 100, 50, 10);
        Rectangle square5 = new Rectangle(495, 100, 50, 20);
        int playerSpeed = 7;
        int ballXSpeed = 0;
        int ballYSpeed = 0;
        Brush whiteBrush = new SolidBrush(Color.White);
        Brush redBrush = new SolidBrush(Color.Red);
        Brush blueBrush = new SolidBrush(Color.Blue);
        Brush yellowBrush = new SolidBrush(Color.Yellow);



        public breakout()
        {
            InitializeComponent();
            KeyPreview = true;


        }

        private void easybutton_Click(object sender, EventArgs e)
        {
            easybutton.Visible = false;
            midButton.Visible = false;
            hardButton.Visible = false;
            easy = 1;
            buttonPressed = true;
            gameTimer.Enabled = true;
            
            gameStart();
            Invalidate();


        }

        private void midButton_Click(object sender, EventArgs e)
        {
            easybutton.Visible = false;
            hardButton.Visible = false;
            midButton.Visible = false;
            mid = 1;
            buttonPressed = true;
            gameTimer.Enabled = true;
            gameStart();
            Invalidate();

            

        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easybutton.Visible = false; hardButton.Visible = false; midButton.Visible = false;
            hard = 1;
            
            buttonPressed = true;
            gameTimer.Enabled = true;
            gameStart();
            Invalidate();
        }
        private void gameStart()
        {
            if (easy == 1) { ballXSpeed = 3; ballYSpeed = 3; }
            if (hard == 1) { ballXSpeed = 9; ballYSpeed = 9; }
            if (mid == 1) { ballXSpeed = 6; ballYSpeed = 6; }

        }

        private void breakout_Paint(object sender, PaintEventArgs e)
        {
            if (buttonPressed == true)
            {

                Graphics g = e.Graphics;
                g.Clear(Color.Black);
                g.FillRectangle(whiteBrush, 200, 100, 400, 400);
                g.FillRectangle(blueBrush, ball);
                g.FillRectangle(blueBrush, player);
                g.FillRectangle(redBrush, square1);
                g.FillRectangle(yellowBrush, square2);
                g.FillRectangle(redBrush, square3);
                g.FillRectangle(yellowBrush, square4);
                g.FillRectangle(redBrush, square5);
                
               
            }

        }

        private void breakout_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    DDown = true;
                    break;
                case Keys.A:
                    ADown = true;
                    
                    break;


            }
        }

        private void breakout_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    ADown = false;
                    break;
                case Keys.D:
                    DDown = false;
                    break;


            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move player  
            label1.Text = ADown.ToString(); ;
            if (ADown == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }

            if (DDown == true && player.X < this.Width - player.Width)
            {
                player.X += playerSpeed;
            }
            ball.X += ballXSpeed;
            ball.Y += ballYSpeed;
            //check if ball hit top or bottom wall and change direction if it does 
            if (ball.Y < 100 || ball.Y > this.Height - ball.Height)
            {
                ballYSpeed *= -1;
            }
            if (ball.X < 200 || ball.X > 600 - ball.Width) { ballXSpeed *= -1; }

            if (ball.IntersectsWith(player))
            {
                ballYSpeed *= -1;
                ball.Y = player.Y - ball.Height;

            }
            if (ball.IntersectsWith(square1))
                {
                ballYSpeed *= -1;
                
            }
            if (ball.IntersectsWith(square2)) { }
            







            Invalidate();
            

        }
    }
}
