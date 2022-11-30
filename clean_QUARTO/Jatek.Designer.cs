
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
            // Jatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 861);
            this.Name = "Jatek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jatek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jatek_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Odavisz;
        private System.Windows.Forms.Timer ListaTimer;
        private System.Windows.Forms.Timer Megjelenit;
    }
}