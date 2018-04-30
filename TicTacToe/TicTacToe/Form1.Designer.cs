namespace TicTacToe
{
    partial class Form1
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
            this.btnTL = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.btnCR = new System.Windows.Forms.Button();
            this.btnBL = new System.Windows.Forms.Button();
            this.btnBM = new System.Windows.Forms.Button();
            this.btnBR = new System.Windows.Forms.Button();
            this.btnnewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblXWins = new System.Windows.Forms.Label();
            this.lblOWins = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTL
            // 
            this.btnTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTL.Location = new System.Drawing.Point(9, 35);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(75, 75);
            this.btnTL.TabIndex = 0;
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.button_click);
            // 
            // btnTM
            // 
            this.btnTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTM.Location = new System.Drawing.Point(90, 35);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(75, 75);
            this.btnTM.TabIndex = 1;
            this.btnTM.UseVisualStyleBackColor = true;
            this.btnTM.Click += new System.EventHandler(this.button_click);
            // 
            // btnTR
            // 
            this.btnTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTR.Location = new System.Drawing.Point(171, 35);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(75, 75);
            this.btnTR.TabIndex = 2;
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.button_click);
            // 
            // btnCL
            // 
            this.btnCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCL.Location = new System.Drawing.Point(9, 116);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(75, 75);
            this.btnCL.TabIndex = 3;
            this.btnCL.UseVisualStyleBackColor = true;
            this.btnCL.Click += new System.EventHandler(this.button_click);
            // 
            // btnCM
            // 
            this.btnCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCM.Location = new System.Drawing.Point(90, 116);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(75, 75);
            this.btnCM.TabIndex = 4;
            this.btnCM.UseVisualStyleBackColor = true;
            this.btnCM.Click += new System.EventHandler(this.button_click);
            // 
            // btnCR
            // 
            this.btnCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCR.Location = new System.Drawing.Point(171, 116);
            this.btnCR.Name = "btnCR";
            this.btnCR.Size = new System.Drawing.Size(75, 75);
            this.btnCR.TabIndex = 5;
            this.btnCR.UseVisualStyleBackColor = true;
            this.btnCR.Click += new System.EventHandler(this.button_click);
            // 
            // btnBL
            // 
            this.btnBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBL.Location = new System.Drawing.Point(9, 196);
            this.btnBL.Name = "btnBL";
            this.btnBL.Size = new System.Drawing.Size(75, 75);
            this.btnBL.TabIndex = 6;
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.button_click);
            // 
            // btnBM
            // 
            this.btnBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBM.Location = new System.Drawing.Point(90, 196);
            this.btnBM.Name = "btnBM";
            this.btnBM.Size = new System.Drawing.Size(75, 75);
            this.btnBM.TabIndex = 7;
            this.btnBM.UseVisualStyleBackColor = true;
            this.btnBM.Click += new System.EventHandler(this.button_click);
            // 
            // btnBR
            // 
            this.btnBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBR.Location = new System.Drawing.Point(171, 197);
            this.btnBR.Name = "btnBR";
            this.btnBR.Size = new System.Drawing.Size(75, 75);
            this.btnBR.TabIndex = 8;
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.button_click);
            // 
            // btnnewGame
            // 
            this.btnnewGame.Location = new System.Drawing.Point(9, 277);
            this.btnnewGame.Name = "btnnewGame";
            this.btnnewGame.Size = new System.Drawing.Size(75, 37);
            this.btnnewGame.TabIndex = 9;
            this.btnnewGame.Text = "New game";
            this.btnnewGame.UseVisualStyleBackColor = true;
            this.btnnewGame.Click += new System.EventHandler(this.btnnewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "O Wins:";
            // 
            // lblXWins
            // 
            this.lblXWins.AutoSize = true;
            this.lblXWins.Location = new System.Drawing.Point(130, 277);
            this.lblXWins.Name = "lblXWins";
            this.lblXWins.Size = new System.Drawing.Size(13, 13);
            this.lblXWins.TabIndex = 12;
            this.lblXWins.Text = "0";
            // 
            // lblOWins
            // 
            this.lblOWins.AutoSize = true;
            this.lblOWins.Location = new System.Drawing.Point(131, 301);
            this.lblOWins.Name = "lblOWins";
            this.lblOWins.Size = new System.Drawing.Size(13, 13);
            this.lblOWins.TabIndex = 13;
            this.lblOWins.Text = "0";
            // 
            // lblPlayer
            // 
            this.lblPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer.Location = new System.Drawing.Point(9, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(237, 23);
            this.lblPlayer.TabIndex = 14;
            this.lblPlayer.Text = "It is player X\'s turn.";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reset Score";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblOWins);
            this.Controls.Add(this.lblXWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnewGame);
            this.Controls.Add(this.btnBR);
            this.Controls.Add(this.btnBM);
            this.Controls.Add(this.btnBL);
            this.Controls.Add(this.btnCR);
            this.Controls.Add(this.btnCM);
            this.Controls.Add(this.btnCL);
            this.Controls.Add(this.btnTR);
            this.Controls.Add(this.btnTM);
            this.Controls.Add(this.btnTL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Button btnTR;
        private System.Windows.Forms.Button btnCL;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.Button btnCR;
        private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Button btnBM;
        private System.Windows.Forms.Button btnBR;
        private System.Windows.Forms.Button btnnewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblXWins;
        private System.Windows.Forms.Label lblOWins;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button button1;
    }
}

