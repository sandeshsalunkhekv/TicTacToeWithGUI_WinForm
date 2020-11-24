
namespace TicTacTieWithUI
{
    partial class RulesForTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForTicTacToe));
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.rule1Label = new System.Windows.Forms.Label();
            this.rule2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clickOnNextLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.gameNameLabel.Location = new System.Drawing.Point(324, 23);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(138, 45);
            this.gameNameLabel.TabIndex = 1;
            this.gameNameLabel.Text = "Rules";
            // 
            // rule1Label
            // 
            this.rule1Label.AutoSize = true;
            this.rule1Label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rule1Label.ForeColor = System.Drawing.Color.MediumOrchid;
            this.rule1Label.Location = new System.Drawing.Point(27, 104);
            this.rule1Label.Name = "rule1Label";
            this.rule1Label.Size = new System.Drawing.Size(417, 19);
            this.rule1Label.TabIndex = 2;
            this.rule1Label.Text = "1. The game is played on a grid that\'s 3 squares by 3 squares.";
            // 
            // rule2Label
            // 
            this.rule2Label.AutoSize = true;
            this.rule2Label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rule2Label.ForeColor = System.Drawing.Color.MediumOrchid;
            this.rule2Label.Location = new System.Drawing.Point(27, 161);
            this.rule2Label.Name = "rule2Label";
            this.rule2Label.Size = new System.Drawing.Size(716, 19);
            this.rule2Label.TabIndex = 3;
            this.rule2Label.Text = "2. You are X, your friend (or the computer) is O. Players take turns putting thei" +
    "r marks in empty squares.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(27, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "3. The first player to get 3 of their marks in a consecutive fashion (in a row, c" +
    "olumn, or diagonally) is the winner.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(27, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "4. When all 9 squares are full, the game is over.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label3.Location = new System.Drawing.Point(27, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(664, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note: If no player has 3 marks in a row, column or diagonal, the game ends in a t" +
    "ie.";
            // 
            // clickOnNextLabel
            // 
            this.clickOnNextLabel.AutoSize = true;
            this.clickOnNextLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickOnNextLabel.Location = new System.Drawing.Point(83, 393);
            this.clickOnNextLabel.Name = "clickOnNextLabel";
            this.clickOnNextLabel.Size = new System.Drawing.Size(580, 22);
            this.clickOnNextLabel.TabIndex = 8;
            this.clickOnNextLabel.Text = "Enter names of player(s) in next window... Click on \"Next\" to proceed!";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.nextButton.Location = new System.Drawing.Point(758, 378);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 50);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // RulesForTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.clickOnNextLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rule2Label);
            this.Controls.Add(this.rule1Label);
            this.Controls.Add(this.gameNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "RulesForTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules For Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Label rule1Label;
        private System.Windows.Forms.Label rule2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label clickOnNextLabel;
        private System.Windows.Forms.Button nextButton;
    }
}