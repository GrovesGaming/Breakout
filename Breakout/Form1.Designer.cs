namespace Breakout
{
    partial class breakout
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            easybutton = new Button();
            midButton = new Button();
            hardButton = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // easybutton
            // 
            easybutton.Location = new Point(251, 126);
            easybutton.Name = "easybutton";
            easybutton.Size = new Size(273, 52);
            easybutton.TabIndex = 0;
            easybutton.Text = "Easy";
            easybutton.UseVisualStyleBackColor = true;
            easybutton.Click += easybutton_Click;
            // 
            // midButton
            // 
            midButton.Location = new Point(251, 205);
            midButton.Name = "midButton";
            midButton.Size = new Size(271, 56);
            midButton.TabIndex = 1;
            midButton.Text = "Meduim";
            midButton.UseVisualStyleBackColor = true;
            midButton.Click += midButton_Click;
            // 
            // hardButton
            // 
            hardButton.Location = new Point(251, 304);
            hardButton.Name = "hardButton";
            hardButton.Size = new Size(273, 70);
            hardButton.TabIndex = 2;
            hardButton.Text = "Hard";
            hardButton.UseVisualStyleBackColor = true;
            hardButton.Click += hardButton_Click;
            // 
            // gameTimer
            // 
            gameTimer.Tick += gameTimer_Tick;
            // 
            // breakout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hardButton);
            Controls.Add(midButton);
            Controls.Add(easybutton);
            DoubleBuffered = true;
            Name = "breakout";
            Text = "Breakout";
            Paint += breakout_Paint;
            KeyDown += breakout_KeyDown;
            KeyUp += breakout_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button easybutton;
        private Button midButton;
        private Button hardButton;
        private System.Windows.Forms.Timer gameTimer;
    }
}
