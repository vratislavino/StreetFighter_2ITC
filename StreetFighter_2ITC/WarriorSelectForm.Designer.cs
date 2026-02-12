namespace StreetFighter_2ITC
{
    partial class WarriorSelectForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            startGameButton = new Button();
            fighterSelectOverview1 = new FighterSelectOverview();
            fighterSelectOverview2 = new FighterSelectOverview();
            button1 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(11, 428);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(990, 260);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // startGameButton
            // 
            startGameButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            startGameButton.Location = new Point(378, 337);
            startGameButton.Margin = new Padding(2);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(242, 58);
            startGameButton.TabIndex = 1;
            startGameButton.Text = "Start game";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // fighterSelectOverview1
            // 
            fighterSelectOverview1.BackColor = Color.FromArgb(255, 224, 192);
            fighterSelectOverview1.BorderStyle = BorderStyle.FixedSingle;
            fighterSelectOverview1.Location = new Point(11, 11);
            fighterSelectOverview1.Margin = new Padding(2);
            fighterSelectOverview1.Name = "fighterSelectOverview1";
            fighterSelectOverview1.Size = new Size(264, 413);
            fighterSelectOverview1.TabIndex = 2;
            // 
            // fighterSelectOverview2
            // 
            fighterSelectOverview2.BackColor = Color.FromArgb(255, 224, 192);
            fighterSelectOverview2.BorderStyle = BorderStyle.FixedSingle;
            fighterSelectOverview2.Location = new Point(737, 11);
            fighterSelectOverview2.Margin = new Padding(2);
            fighterSelectOverview2.Name = "fighterSelectOverview2";
            fighterSelectOverview2.Size = new Size(264, 413);
            fighterSelectOverview2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(598, 400);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 4;
            button1.Text = "Choose opponent";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WarriorSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 699);
            Controls.Add(button1);
            Controls.Add(fighterSelectOverview2);
            Controls.Add(fighterSelectOverview1);
            Controls.Add(startGameButton);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(2);
            Name = "WarriorSelectForm";
            Text = "Form1";
            Load += WarriorSelectForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button startGameButton;
        private FighterSelectOverview fighterSelectOverview1;
        private FighterSelectOverview fighterSelectOverview2;
        private Button button1;
    }
}
