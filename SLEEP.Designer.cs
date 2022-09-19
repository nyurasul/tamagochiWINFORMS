namespace Tamagotchi
{
    partial class SLEEP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SLEEP));
            this.Tama_sleep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tama_sleep)).BeginInit();
            this.SuspendLayout();
            // 
            // Tama_sleep
            // 
            this.Tama_sleep.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tama_sleep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tama_sleep.Image = ((System.Drawing.Image)(resources.GetObject("Tama_sleep.Image")));
            this.Tama_sleep.Location = new System.Drawing.Point(0, 0);
            this.Tama_sleep.Name = "Tama_sleep";
            this.Tama_sleep.Size = new System.Drawing.Size(800, 450);
            this.Tama_sleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tama_sleep.TabIndex = 0;
            this.Tama_sleep.TabStop = false;
            // 
            // SLEEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Tama_sleep);
            this.Name = "SLEEP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SLEEP";
            this.Load += new System.EventHandler(this.SLEEP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tama_sleep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox Tama_sleep;
    }
}