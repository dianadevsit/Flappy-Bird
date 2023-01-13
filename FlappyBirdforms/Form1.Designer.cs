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
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.groundBase = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBase)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBirdforms.Properties.Resources.blue_bird___wings_down;
            this.flappyBird.Location = new System.Drawing.Point(138, 138);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(34, 24);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // groundBase
            // 
            this.groundBase.Image = global::FlappyBirdforms.Properties.Resources._base;
            this.groundBase.Location = new System.Drawing.Point(3, 365);
            this.groundBase.Name = "groundBase";
            this.groundBase.Size = new System.Drawing.Size(785, 73);
            this.groundBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundBase.TabIndex = 0;
            this.groundBase.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.groundBase);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox groundBase;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Timer timer1;
    }
}

