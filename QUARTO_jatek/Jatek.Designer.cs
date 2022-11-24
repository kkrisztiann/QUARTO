
namespace QUARTO_jatek
{
    partial class Jatek
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
            this.nevLBL1 = new System.Windows.Forms.Label();
            this.nevLBL2 = new System.Windows.Forms.Label();
            this.jatekosKomm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nevLBL1
            // 
            this.nevLBL1.AutoSize = true;
            this.nevLBL1.Location = new System.Drawing.Point(12, 9);
            this.nevLBL1.Name = "nevLBL1";
            this.nevLBL1.Size = new System.Drawing.Size(25, 13);
            this.nevLBL1.TabIndex = 0;
            this.nevLBL1.Text = "nev";
            // 
            // nevLBL2
            // 
            this.nevLBL2.AutoSize = true;
            this.nevLBL2.Location = new System.Drawing.Point(455, 9);
            this.nevLBL2.Name = "nevLBL2";
            this.nevLBL2.Size = new System.Drawing.Size(25, 13);
            this.nevLBL2.TabIndex = 1;
            this.nevLBL2.Text = "nev";
            // 
            // jatekosKomm
            // 
            this.jatekosKomm.AutoSize = true;
            this.jatekosKomm.Location = new System.Drawing.Point(186, 9);
            this.jatekosKomm.Name = "jatekosKomm";
            this.jatekosKomm.Size = new System.Drawing.Size(41, 13);
            this.jatekosKomm.TabIndex = 2;
            this.jatekosKomm.Text = "szoveg";
            // 
            // Jatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 669);
            this.Controls.Add(this.jatekosKomm);
            this.Controls.Add(this.nevLBL2);
            this.Controls.Add(this.nevLBL1);
            this.Name = "Jatek";
            this.Text = "Jatek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nevLBL1;
        private System.Windows.Forms.Label nevLBL2;
        private System.Windows.Forms.Label jatekosKomm;
    }
}