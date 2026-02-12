namespace StreetFighter_2ITC
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            playerFighter = new InGameFighter();
            opponentFighter = new InGameFighter();
            gameflowTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(201, 418);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(400, 96);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // playerFighter
            // 
            playerFighter.BorderStyle = BorderStyle.FixedSingle;
            playerFighter.Location = new Point(16, 12);
            playerFighter.Name = "playerFighter";
            playerFighter.Size = new Size(170, 261);
            playerFighter.TabIndex = 2;
            // 
            // opponentFighter
            // 
            opponentFighter.BorderStyle = BorderStyle.FixedSingle;
            opponentFighter.Location = new Point(621, 12);
            opponentFighter.Name = "opponentFighter";
            opponentFighter.Size = new Size(170, 261);
            opponentFighter.TabIndex = 3;
            // 
            // gameflowTimer
            // 
            gameflowTimer.Interval = 1000;
            gameflowTimer.Tick += gameflowTimer_Tick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(192, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 400);
            panel1.TabIndex = 4;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 526);
            Controls.Add(panel1);
            Controls.Add(opponentFighter);
            Controls.Add(playerFighter);
            Controls.Add(richTextBox1);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private InGameFighter playerFighter;
        private InGameFighter opponentFighter;
        private System.Windows.Forms.Timer gameflowTimer;
        private Panel panel1;
    }
}