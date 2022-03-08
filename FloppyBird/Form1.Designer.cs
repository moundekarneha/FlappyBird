
namespace FloppyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.picRightTop2 = new System.Windows.Forms.PictureBox();
            this.picRightButtom2 = new System.Windows.Forms.PictureBox();
            this.picFlappyBird = new System.Windows.Forms.PictureBox();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picRightBottom = new System.Windows.Forms.PictureBox();
            this.picRightTop = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRightTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightButtom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightTop)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Turquoise;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(530, 435);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(69, 16);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score : 0";
            // 
            // picRightTop2
            // 
            this.picRightTop2.BackColor = System.Drawing.Color.Transparent;
            this.picRightTop2.Image = ((System.Drawing.Image)(resources.GetObject("picRightTop2.Image")));
            this.picRightTop2.Location = new System.Drawing.Point(1066, -6);
            this.picRightTop2.Name = "picRightTop2";
            this.picRightTop2.Size = new System.Drawing.Size(34, 72);
            this.picRightTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightTop2.TabIndex = 7;
            this.picRightTop2.TabStop = false;
            // 
            // picRightButtom2
            // 
            this.picRightButtom2.BackColor = System.Drawing.Color.Transparent;
            this.picRightButtom2.Image = ((System.Drawing.Image)(resources.GetObject("picRightButtom2.Image")));
            this.picRightButtom2.Location = new System.Drawing.Point(915, 235);
            this.picRightButtom2.Name = "picRightButtom2";
            this.picRightButtom2.Size = new System.Drawing.Size(39, 209);
            this.picRightButtom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightButtom2.TabIndex = 6;
            this.picRightButtom2.TabStop = false;
            // 
            // picFlappyBird
            // 
            this.picFlappyBird.BackColor = System.Drawing.Color.Transparent;
            this.picFlappyBird.BackgroundImage = global::FloppyBird.Properties.Resources.Game_Background;
            this.picFlappyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picFlappyBird.Image = ((System.Drawing.Image)(resources.GetObject("picFlappyBird.Image")));
            this.picFlappyBird.Location = new System.Drawing.Point(72, 150);
            this.picFlappyBird.Name = "picFlappyBird";
            this.picFlappyBird.Size = new System.Drawing.Size(67, 34);
            this.picFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlappyBird.TabIndex = 4;
            this.picFlappyBird.TabStop = false;
            // 
            // picGround
            // 
            this.picGround.Image = global::FloppyBird.Properties.Resources.ground1;
            this.picGround.Location = new System.Drawing.Point(-9, 427);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(1172, 24);
            this.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGround.TabIndex = 3;
            this.picGround.TabStop = false;
            // 
            // picRightBottom
            // 
            this.picRightBottom.BackColor = System.Drawing.Color.Transparent;
            this.picRightBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picRightBottom.Image = ((System.Drawing.Image)(resources.GetObject("picRightBottom.Image")));
            this.picRightBottom.Location = new System.Drawing.Point(432, 318);
            this.picRightBottom.Name = "picRightBottom";
            this.picRightBottom.Size = new System.Drawing.Size(39, 126);
            this.picRightBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightBottom.TabIndex = 1;
            this.picRightBottom.TabStop = false;
            // 
            // picRightTop
            // 
            this.picRightTop.BackColor = System.Drawing.Color.DimGray;
            this.picRightTop.BackgroundImage = global::FloppyBird.Properties.Resources.Game_Background;
            this.picRightTop.Image = ((System.Drawing.Image)(resources.GetObject("picRightTop.Image")));
            this.picRightTop.Location = new System.Drawing.Point(650, -6);
            this.picRightTop.Name = "picRightTop";
            this.picRightTop.Size = new System.Drawing.Size(34, 85);
            this.picRightTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightTop.TabIndex = 0;
            this.picRightTop.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::FloppyBird.Properties.Resources.Game_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picRightTop2);
            this.Controls.Add(this.picRightButtom2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picFlappyBird);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picRightBottom);
            this.Controls.Add(this.picRightTop);
            this.Name = "Form1";
            this.Text = "Flappy Bird ";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picRightTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightButtom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picRightButtom2;
        private System.Windows.Forms.PictureBox picRightTop;
        private System.Windows.Forms.PictureBox picRightBottom;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.PictureBox picFlappyBird;
        private System.Windows.Forms.PictureBox picRightTop2;
        private System.Windows.Forms.Button button1;
    }
}

