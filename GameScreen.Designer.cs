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
            label2 = new Label();
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
            lblWord.AutoSize = true;
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
            lblCount.Location = new Point(30, 227);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(177, 32);
            lblCount.TabIndex = 2;
            lblCount.Text = "Word Count:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 270);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 3;
            label2.Text = "Word Count:";
            label2.Click += label2_Click;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lblCount);
            Controls.Add(lblWord);
            Controls.Add(label1);
            Name = "GameScreen";
            Text = "GameScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWord;
        private Label lblCount;
        private Label label2;
    }
}