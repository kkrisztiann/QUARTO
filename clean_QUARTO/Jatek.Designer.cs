
namespace clean_QUARTO
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
            this.components = new System.ComponentModel.Container();
            this.Odavisz = new System.Windows.Forms.Timer(this.components);
            this.ListaTimer = new System.Windows.Forms.Timer(this.components);
            this.Megjelenit = new System.Windows.Forms.Timer(this.components);
            this.hatter = new System.Windows.Forms.PictureBox();
            this.playerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hatter)).BeginInit();
            this.SuspendLayout();
            // 
            // Odavisz
            // 
            this.Odavisz.Interval = 1;
            this.Odavisz.Tick += new System.EventHandler(this.Odavisz_Tick);
            // 
            // ListaTimer
            // 
            this.ListaTimer.Interval = 1;
            this.ListaTimer.Tick += new System.EventHandler(this.ListaTimer_Tick);
            // 
            // Megjelenit
            // 
            this.Megjelenit.Interval = 1;
            this.Megjelenit.Tick += new System.EventHandler(this.Megjelenit_Tick);
            // 
            // hatter
            // 
            this.hatter.BackColor = System.Drawing.Color.Transparent;
            this.hatter.Image = global::clean_QUARTO.Properties.Resources.kör;
            this.hatter.Location = new System.Drawing.Point(36, 52);
            this.hatter.Name = "hatter";
            this.hatter.Size = new System.Drawing.Size(0, 0);
            this.hatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hatter.TabIndex = 0;
            this.hatter.TabStop = false;
            // 
            // playerName
            // 
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerName.Location = new System.Drawing.Point(2, 9);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(680, 63);
            this.playerName.TabIndex = 1;
            this.playerName.Text = "Player";
            this.playerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Jatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 881);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.hatter);
            this.MaximumSize = new System.Drawing.Size(700, 920);
            this.MinimumSize = new System.Drawing.Size(700, 920);
            this.Name = "Jatek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUARTO!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jatek_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.hatter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Odavisz;
        private System.Windows.Forms.Timer ListaTimer;
        private System.Windows.Forms.Timer Megjelenit;
        private System.Windows.Forms.PictureBox hatter;
        private System.Windows.Forms.Label playerName;
    }
}