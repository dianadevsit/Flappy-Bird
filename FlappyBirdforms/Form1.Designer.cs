namespace FlappyBirdforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.groundBase = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.weather = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(22, 403);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(110, 29);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBirdforms.Properties.Resources.pipe_green_down;
            this.pipeTop.Location = new System.Drawing.Point(459, -193);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(52, 320);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pipeTop.TabIndex = 5;
            this.pipeTop.TabStop = false;
            // 
            // groundBase
            // 
            this.groundBase.Image = global::FlappyBirdforms.Properties.Resources._base;
            this.groundBase.Location = new System.Drawing.Point(-10, 380);
            this.groundBase.Name = "groundBase";
            this.groundBase.Size = new System.Drawing.Size(808, 82);
            this.groundBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundBase.TabIndex = 0;
            this.groundBase.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBirdforms.Properties.Resources.blue_bird___wings_down;
            this.flappyBird.Location = new System.Drawing.Point(136, 137);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(40, 35);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.flappyBird_Click);
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::FlappyBirdforms.Properties.Resources.pipe_green_up;
            this.pipeDown.Location = new System.Drawing.Point(370, 248);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(52, 320);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // weather
            // 
            this.weather.Image = global::FlappyBirdforms.Properties.Resources.sun;
            this.weather.Location = new System.Drawing.Point(51, 12);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(125, 96);
            this.weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weather.TabIndex = 4;
            this.weather.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.groundBase);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.weather);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox groundBase;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox weather;
        private System.Windows.Forms.PictureBox pipeTop;
    }
}

