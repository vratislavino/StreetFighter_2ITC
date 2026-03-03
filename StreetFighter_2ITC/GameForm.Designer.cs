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
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(203, 442);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Enabled = false;
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(400, 90);
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
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(192, 415);
            label1.Name = "label1";
            label1.Size = new Size(423, 23);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 544);
            Controls.Add(label1);
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
        private Label label1;
    }
}