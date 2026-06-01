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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            setupMinigamesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(11, 466);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(990, 260);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // startGameButton
            // 
            startGameButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            startGameButton.Location = new Point(378, 367);
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
            fighterSelectOverview1.Location = new Point(11, 41);
            fighterSelectOverview1.Margin = new Padding(2);
            fighterSelectOverview1.Name = "fighterSelectOverview1";
            fighterSelectOverview1.Size = new Size(264, 413);
            fighterSelectOverview1.TabIndex = 2;
            // 
            // fighterSelectOverview2
            // 
            fighterSelectOverview2.BackColor = Color.FromArgb(255, 224, 192);
            fighterSelectOverview2.BorderStyle = BorderStyle.FixedSingle;
            fighterSelectOverview2.Location = new Point(737, 41);
            fighterSelectOverview2.Margin = new Padding(2);
            fighterSelectOverview2.Name = "fighterSelectOverview2";
            fighterSelectOverview2.Size = new Size(264, 413);
            fighterSelectOverview2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(598, 430);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 4;
            button1.Text = "Choose opponent";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1007, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setupMinigamesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // setupMinigamesToolStripMenuItem
            // 
            setupMinigamesToolStripMenuItem.Name = "setupMinigamesToolStripMenuItem";
            setupMinigamesToolStripMenuItem.Size = new Size(180, 22);
            setupMinigamesToolStripMenuItem.Text = "Setup minigames ";
            setupMinigamesToolStripMenuItem.Click += setupMinigamesToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 434);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 6;
            label1.Text = "Aktivováno miniher: 0";
            // 
            // WarriorSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 723);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(fighterSelectOverview2);
            Controls.Add(fighterSelectOverview1);
            Controls.Add(startGameButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "WarriorSelectForm";
            Text = "Form1";
            Load += WarriorSelectForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button startGameButton;
        private FighterSelectOverview fighterSelectOverview1;
        private FighterSelectOverview fighterSelectOverview2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem setupMinigamesToolStripMenuItem;
        private Label label1;
    }
}
