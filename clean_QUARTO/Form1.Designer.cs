
namespace clean_QUARTO
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
            this.label3 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(465, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Készítette: Kertész Krisztián, Kerék Ádám és Beretka Gellért";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.startBtn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBtn.Location = new System.Drawing.Point(654, 153);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(149, 57);
            this.startBtn.TabIndex = 15;
            this.startBtn.Text = "Játék";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "Második játékos neve: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Első játékos neve: ";
            // 
            // player2Name
            // 
            this.player2Name.BackColor = System.Drawing.Color.White;
            this.player2Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2Name.ForeColor = System.Drawing.Color.Black;
            this.player2Name.Location = new System.Drawing.Point(367, 194);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(281, 29);
            this.player2Name.TabIndex = 12;
            this.player2Name.Text = "Player2";
            this.player2Name.TextChanged += new System.EventHandler(this.player2Name_TextChanged);
            // 
            // player1Name
            // 
            this.player1Name.BackColor = System.Drawing.Color.White;
            this.player1Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1Name.ForeColor = System.Drawing.Color.Black;
            this.player1Name.Location = new System.Drawing.Point(367, 144);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(281, 29);
            this.player1Name.TabIndex = 11;
            this.player1Name.Text = "Player1";
            this.player1Name.TextChanged += new System.EventHandler(this.player1Name_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.TextBox player1Name;
    }
}

