namespace TicTacTieWithUI
{
    partial class TicTacToeMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.whoseTurn = new System.Windows.Forms.Label();
            this.Player1Wins = new System.Windows.Forms.Label();
            this.Player2Wins = new System.Windows.Forms.Label();
            this.TotalDraws = new System.Windows.Forms.Label();
            this.TotalDrawsCount = new System.Windows.Forms.Label();
            this.Player2WinsCount = new System.Windows.Forms.Label();
            this.Player1WinsCount = new System.Windows.Forms.Label();
            this.switchGameMode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetScoresToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetScoresToolStripMenuItem
            // 
            this.resetScoresToolStripMenuItem.Name = "resetScoresToolStripMenuItem";
            this.resetScoresToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.resetScoresToolStripMenuItem.Text = "Reset scores";
            this.resetScoresToolStripMenuItem.Click += new System.EventHandler(this.resetScoresToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Yellow;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(44, 246);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(115, 115);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_Click);
            this.A1.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.A1.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Yellow;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(206, 246);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(115, 115);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_Click);
            this.A2.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.A2.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Yellow;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(368, 246);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(115, 115);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_Click);
            this.A3.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.A3.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Yellow;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(368, 370);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(115, 115);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_Click);
            this.B3.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.B3.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Yellow;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(206, 370);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(115, 115);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_Click);
            this.B2.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.B2.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Yellow;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(44, 370);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(115, 115);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_Click);
            this.B1.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.B1.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Yellow;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(368, 494);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(115, 115);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_Click);
            this.C3.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.C3.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Yellow;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(206, 494);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(115, 115);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_Click);
            this.C2.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.C2.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Yellow;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(44, 494);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(115, 115);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_Click);
            this.C1.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.C1.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // whoseTurn
            // 
            this.whoseTurn.AutoSize = true;
            this.whoseTurn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoseTurn.ForeColor = System.Drawing.Color.SteelBlue;
            this.whoseTurn.Location = new System.Drawing.Point(38, 39);
            this.whoseTurn.Name = "whoseTurn";
            this.whoseTurn.Size = new System.Drawing.Size(156, 46);
            this.whoseTurn.TabIndex = 10;
            this.whoseTurn.Text = "X\'s Turn";
            // 
            // Player1Wins
            // 
            this.Player1Wins.AutoSize = true;
            this.Player1Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Wins.ForeColor = System.Drawing.Color.Red;
            this.Player1Wins.Location = new System.Drawing.Point(40, 140);
            this.Player1Wins.Name = "Player1Wins";
            this.Player1Wins.Size = new System.Drawing.Size(123, 32);
            this.Player1Wins.TabIndex = 11;
            this.Player1Wins.Text = "X\'s Wins";
            this.Player1Wins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Player2Wins
            // 
            this.Player2Wins.AutoSize = true;
            this.Player2Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Wins.ForeColor = System.Drawing.Color.DarkGreen;
            this.Player2Wins.Location = new System.Drawing.Point(199, 140);
            this.Player2Wins.Name = "Player2Wins";
            this.Player2Wins.Size = new System.Drawing.Size(126, 32);
            this.Player2Wins.TabIndex = 12;
            this.Player2Wins.Text = "O\'s Wins";
            this.Player2Wins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalDraws
            // 
            this.TotalDraws.AutoSize = true;
            this.TotalDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDraws.Location = new System.Drawing.Point(361, 140);
            this.TotalDraws.Name = "TotalDraws";
            this.TotalDraws.Size = new System.Drawing.Size(94, 32);
            this.TotalDraws.TabIndex = 13;
            this.TotalDraws.Text = "Draws";
            this.TotalDraws.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalDrawsCount
            // 
            this.TotalDrawsCount.AutoSize = true;
            this.TotalDrawsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDrawsCount.Location = new System.Drawing.Point(361, 184);
            this.TotalDrawsCount.Name = "TotalDrawsCount";
            this.TotalDrawsCount.Size = new System.Drawing.Size(31, 32);
            this.TotalDrawsCount.TabIndex = 16;
            this.TotalDrawsCount.Text = "0";
            this.TotalDrawsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2WinsCount
            // 
            this.Player2WinsCount.AutoSize = true;
            this.Player2WinsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2WinsCount.ForeColor = System.Drawing.Color.DarkGreen;
            this.Player2WinsCount.Location = new System.Drawing.Point(204, 184);
            this.Player2WinsCount.Name = "Player2WinsCount";
            this.Player2WinsCount.Size = new System.Drawing.Size(31, 32);
            this.Player2WinsCount.TabIndex = 15;
            this.Player2WinsCount.Text = "0";
            this.Player2WinsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1WinsCount
            // 
            this.Player1WinsCount.AutoSize = true;
            this.Player1WinsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1WinsCount.ForeColor = System.Drawing.Color.Red;
            this.Player1WinsCount.Location = new System.Drawing.Point(47, 184);
            this.Player1WinsCount.Name = "Player1WinsCount";
            this.Player1WinsCount.Size = new System.Drawing.Size(31, 32);
            this.Player1WinsCount.TabIndex = 14;
            this.Player1WinsCount.Text = "0";
            this.Player1WinsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchGameMode
            // 
            this.switchGameMode.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchGameMode.Location = new System.Drawing.Point(368, 43);
            this.switchGameMode.Name = "switchGameMode";
            this.switchGameMode.Size = new System.Drawing.Size(167, 54);
            this.switchGameMode.TabIndex = 17;
            this.switchGameMode.Text = "Switch to Player VS Computer";
            this.switchGameMode.UseVisualStyleBackColor = true;
            this.switchGameMode.Click += new System.EventHandler(this.switchGameMode_Click);
            // 
            // TicTacToeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(555, 668);
            this.Controls.Add(this.switchGameMode);
            this.Controls.Add(this.TotalDrawsCount);
            this.Controls.Add(this.Player2WinsCount);
            this.Controls.Add(this.Player1WinsCount);
            this.Controls.Add(this.TotalDraws);
            this.Controls.Add(this.Player2Wins);
            this.Controls.Add(this.Player1Wins);
            this.Controls.Add(this.whoseTurn);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(573, 715);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(573, 715);
            this.Name = "TicTacToeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TicTacToeForm1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Label whoseTurn;
        private System.Windows.Forms.Label Player1Wins;
        private System.Windows.Forms.Label Player2Wins;
        private System.Windows.Forms.Label TotalDraws;
        private System.Windows.Forms.Label TotalDrawsCount;
        private System.Windows.Forms.Label Player2WinsCount;
        private System.Windows.Forms.Label Player1WinsCount;
        private System.Windows.Forms.ToolStripMenuItem resetScoresToolStripMenuItem;
        private System.Windows.Forms.Button switchGameMode;
    }
}

