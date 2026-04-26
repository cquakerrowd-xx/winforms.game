namespace game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            StartButton = new Button();
            HelpButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Showcard Gothic", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(202, 75);
            label1.Name = "label1";
            label1.Size = new Size(367, 74);
            label1.TabIndex = 0;
            label1.Text = "UNJUMBLE!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(160, 184);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(170, 57);
            StartButton.TabIndex = 1;
            StartButton.Text = "START";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += LoadGame;
            // 
            // HelpButton
            // 
            HelpButton.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            HelpButton.Location = new Point(439, 184);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(170, 57);
            HelpButton.TabIndex = 2;
            HelpButton.Text = "HELP";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += LoadHelp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(HelpButton);
            Controls.Add(StartButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mini Games (Are You Ready to Learn?)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button StartButton;
        private Button HelpButton;
    }
}
