﻿
namespace TicTacTieWithUI
{
    partial class AcceptPlayerNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcceptPlayerNames));
            this.Note = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(30, 269);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(749, 24);
            this.Note.TabIndex = 11;
            this.Note.Text = "Note: If you leave any Player\'s Name blank, default names (X for Player 1, and O " +
    "for Player 2 will be used)";
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(569, 312);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(100, 32);
            this.PlayButton.TabIndex = 10;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Player2Name
            // 
            this.Player2Name.Location = new System.Drawing.Point(457, 187);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(300, 22);
            this.Player2Name.TabIndex = 9;
            this.Player2Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayerName_KeyPress);
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(457, 70);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(300, 22);
            this.Player1Name.TabIndex = 8;
            this.Player1Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayerName_KeyPress);
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(37, 179);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(244, 33);
            this.Player2.TabIndex = 7;
            this.Player2.Text = "Enter Player 2 Name";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(37, 62);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(244, 33);
            this.Player1.TabIndex = 6;
            this.Player1.Text = "Enter Player 1 Name";
            // 
            // AcceptPlayerNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(882, 373);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 420);
            this.Name = "AcceptPlayerNames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcceptPlayerNames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player1;
    }
}