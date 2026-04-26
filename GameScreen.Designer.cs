namespace game
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            label1 = new Label();
            lblWord = new Label();
            lblCount = new Label();
            lblInfo = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(226, -12);
            label1.Name = "label1";
            label1.Size = new Size(326, 66);
            label1.TabIndex = 0;
            label1.Text = "UNJUMBLE!";
            // 
            // lblWord
            // 
            lblWord.BackColor = Color.Transparent;
            lblWord.Font = new Font("Arial Rounded MT Bold", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWord.Location = new Point(30, 77);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(162, 54);
            lblWord.TabIndex = 1;
            lblWord.Text = "label2";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.BackColor = Color.Transparent;
            lblCount.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(15, 213);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(177, 32);
            lblCount.TabIndex = 2;
            lblCount.Text = "Word Count:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(15, 167);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(143, 32);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Attempts:";
            lblInfo.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(499, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 275);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(510, 68);
            button1.Name = "button1";
            button1.Size = new Size(267, 76);
            button1.TabIndex = 5;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(510, 150);
            button2.Name = "button2";
            button2.Size = new Size(267, 76);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(510, 232);
            button3.Name = "button3";
            button3.Size = new Size(267, 76);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(lblInfo);
            Controls.Add(lblCount);
            Controls.Add(lblWord);
            Controls.Add(label1);
            Name = "GameScreen";
            Text = "GameScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWord;
        private Label lblCount;
        private Label lblInfo;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}