using System.Data.SqlTypes;

using System.Diagnostics;

namespace Breakout
{
    public partial class breakout : Form
    {
        string fileshare = "@\"C:\\Users\\grove\\source\\repos\\Breakout\\breakoutHighScoreList.txt\"";
        bool buttonPressed = false;
        bool DDown = false;
        bool ADown = false;
        bool square1Vis = true;
        bool square2Vis = true;
        bool square3Vis = true;
        bool square4Vis = true;
        bool square5Vis = true;
        bool square6Vis = true;
        bool square7Vis = true;
        bool square8Vis = true;
        bool square9Vis = true;
        bool square10Vis = true;
        bool square11Vis = true;
        bool square12Vis = true;
        Stopwatch gameWatch = new Stopwatch();

        int lives = 3;
        int squares = 11;
        int easy = 0;
        int mid = 0;
        int hard = 0;
        Rectangle player = new Rectangle(350, 400, 60, 10);
        Rectangle ball = new Rectangle(295, 195, 10, 10);
        Rectangle square1 = new Rectangle(200, 100, 100, 20);
        Rectangle square2 = new Rectangle(300, 100, 100, 20);
        Rectangle square3 = new Rectangle(400, 100, 100, 10);
        Rectangle square4 = new Rectangle(200, 120, 100, 20);
        Rectangle square5 = new Rectangle(300, 120, 100, 20);
        Rectangle square6 = new Rectangle(400, 120, 100, 20);
        Rectangle square7 = new Rectangle(500, 100, 100, 20);
        Rectangle square8 = new Rectangle(500, 120, 100, 20);
        Rectangle square9 = new Rectangle(200, 140, 100, 20);
        Rectangle square10 = new Rectangle (300, 140, 100,20);
        Rectangle square11 = new Rectangle(400, 140, 100, 20);
        Rectangle square12 = new Rectangle(500, 140, 100, 20);
        int playerSpeed = 9;
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
            gameWatch.Start();


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
            gameWatch.Start();



        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easybutton.Visible = false; hardButton.Visible = false; midButton.Visible = false;
            hard = 1;

            buttonPressed = true;
            gameTimer.Enabled = true;
            gameStart();
            Invalidate();
            gameWatch.Start();
        }
        private void gameStart()
        {timerlabel.Text= gameWatch.ElapsedMilliseconds + "";
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
                if (square1Vis == true)
                { g.FillRectangle(redBrush, square1); }
                if (square2Vis == true)
                { g.FillRectangle(yellowBrush, square2); }
                if (square3Vis == true)
                { g.FillRectangle(blueBrush, square3); }
                if (square4Vis == true)
                { g.FillRectangle(yellowBrush, square4); }
                if (square5Vis == true)
                { g.FillRectangle(redBrush, square5); }
                if (square6Vis == true) { g.FillRectangle(blueBrush, square6); }
                if (square7Vis == true) { g.FillRectangle(redBrush, square7); }
                if (square8Vis == true) { g.FillRectangle(yellowBrush, square8); }
                if (square9Vis == true) { g.FillRectangle(blueBrush, square9); }
                if (square10Vis == true) { g.FillRectangle(redBrush, square10); }
                if (square11Vis == true) { g.FillRectangle(yellowBrush, square11); }
                if (square12Vis == true) { g.FillRectangle(blueBrush, square12); }
                


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
            label1.Text = lives.ToString();
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
            if (ball.Y > this.Height - ball.Height)
                if (player.X < 200 || player.X >600 -player.Width) 
            {
                lives--;
                ball.Y = 440;
            }

            if (ball.IntersectsWith(player))
            {
                ballYSpeed *= -1;
                ball.Y = player.Y - ball.Height;

            }
            if (ball.IntersectsWith(square1))
            {
                ballYSpeed *= -1;
                square1Vis = false;
                squares--;
                square1.Y = 600;

            }
            if (ball.IntersectsWith(square2)) {
                ballYSpeed *= -1;
                square2Vis = false;
                squares--;
                square2.Y = 600;
            }
            if (ball.IntersectsWith(square3))
            {
                ballYSpeed *= -1;
                square3Vis = false;
                squares--;
                square3.Y = 600;
            }
            if (ball.IntersectsWith(square4))
            {
                ballYSpeed *= -1;
                square4Vis = false;
                squares--;
                square4.Y = 600;
            }
            if (ball.IntersectsWith(square5))
            {
                ballYSpeed *= -1;
                square5Vis = false;
                squares--;
                square5.Y = 600;
            }
            if (ball.IntersectsWith(square6))
            {
                ballYSpeed *= -1;
                square6Vis = false;
                squares--;
                square6.Y = 600;
            }
            if (ball.IntersectsWith(square7))
            {
                ballYSpeed *= -1;
                square7Vis = false;
                squares--;
                square7.Y = 600;
            }
            if (ball.IntersectsWith(square8))
            { ballYSpeed *= -1;
            square8Vis = false;
                squares--;
                square8.Y = 600;
            }
            if (ball.IntersectsWith(square9))
            {  ballYSpeed *= -1;
                square9Vis = false;
                squares--;
                square9.Y = 600;
            }
            if (ball.IntersectsWith(square10))
            {  ballYSpeed *= -1
                    ; square10Vis = false;
                square10.Y = 600;
                squares--;
            }
            if (ball.IntersectsWith(square11))
                { ballYSpeed *= -1; square11Vis = false;
                square11.Y = 700;
            }
            if (ball.IntersectsWith(square12))
                { ballYSpeed *= -1; ; square12Vis = false;
                squares--;
                square12.Y=600;
            }
    

            if(lives == 0)
            {
                gameTimer.Enabled = false;
                label1.Text = "You lose";
                gameWatch.Stop();
            }

            if (squares == 0)
            {
               gameWatch.Stop();
                gameTimer.Enabled = false; label1.Text = "You Win";
                inputBox.Visible = true;
                outputlabel.Visible = true;
                outputlabel.Text = "Please Put in you name";
            }







            Invalidate();
            

        }
    }
}
