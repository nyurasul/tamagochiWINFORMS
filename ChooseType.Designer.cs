namespace Tamagotchi
{
    partial class ChooseType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseType));
            this.CAT = new System.Windows.Forms.Label();
            this.FROG = new System.Windows.Forms.Label();
            this.DOG = new System.Windows.Forms.Label();
            this.pictureCat = new System.Windows.Forms.PictureBox();
            this.pictureFrog = new System.Windows.Forms.PictureBox();
            this.pictureDog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog)).BeginInit();
            this.SuspendLayout();
            // 
            // CAT
            // 
            this.CAT.AutoSize = true;
            this.CAT.Location = new System.Drawing.Point(138, 122);
            this.CAT.Name = "CAT";
            this.CAT.Size = new System.Drawing.Size(85, 20);
            this.CAT.TabIndex = 0;
            this.CAT.Text = "КОТЕНОК";
            // 
            // FROG
            // 
            this.FROG.AutoSize = true;
            this.FROG.Location = new System.Drawing.Point(369, 122);
            this.FROG.Name = "FROG";
            this.FROG.Size = new System.Drawing.Size(86, 20);
            this.FROG.TabIndex = 1;
            this.FROG.Text = "ЛЯГУШКА";
            // 
            // DOG
            // 
            this.DOG.AutoSize = true;
            this.DOG.Location = new System.Drawing.Point(609, 122);
            this.DOG.Name = "DOG";
            this.DOG.Size = new System.Drawing.Size(67, 20);
            this.DOG.TabIndex = 2;
            this.DOG.Text = "ЩЕНОК";
            // 
            // pictureCat
            // 
            this.pictureCat.Image = ((System.Drawing.Image)(resources.GetObject("pictureCat.Image")));
            this.pictureCat.Location = new System.Drawing.Point(108, 180);
            this.pictureCat.Name = "pictureCat";
            this.pictureCat.Size = new System.Drawing.Size(151, 132);
            this.pictureCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCat.TabIndex = 3;
            this.pictureCat.TabStop = false;
            this.pictureCat.Click += new System.EventHandler(this.pictureCat_Click);
            // 
            // pictureFrog
            // 
            this.pictureFrog.Image = ((System.Drawing.Image)(resources.GetObject("pictureFrog.Image")));
            this.pictureFrog.Location = new System.Drawing.Point(328, 180);
            this.pictureFrog.Name = "pictureFrog";
            this.pictureFrog.Size = new System.Drawing.Size(162, 132);
            this.pictureFrog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFrog.TabIndex = 4;
            this.pictureFrog.TabStop = false;
            this.pictureFrog.Click += new System.EventHandler(this.pictureFrog_Click);
            // 
            // pictureDog
            // 
            this.pictureDog.BackColor = System.Drawing.Color.Transparent;
            this.pictureDog.Image = ((System.Drawing.Image)(resources.GetObject("pictureDog.Image")));
            this.pictureDog.Location = new System.Drawing.Point(566, 180);
            this.pictureDog.Name = "pictureDog";
            this.pictureDog.Size = new System.Drawing.Size(166, 132);
            this.pictureDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDog.TabIndex = 5;
            this.pictureDog.TabStop = false;
            this.pictureDog.Click += new System.EventHandler(this.pictureDog_Click);
            // 
            // ChooseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureDog);
            this.Controls.Add(this.pictureFrog);
            this.Controls.Add(this.pictureCat);
            this.Controls.Add(this.DOG);
            this.Controls.Add(this.FROG);
            this.Controls.Add(this.CAT);
            this.Name = "ChooseType";
            this.Text = "ChooseType";
            this.Load += new System.EventHandler(this.ChooseType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CAT;
        private System.Windows.Forms.Label FROG;
        private System.Windows.Forms.Label DOG;
        public System.Windows.Forms.PictureBox pictureCat;
        public System.Windows.Forms.PictureBox pictureFrog;
        public System.Windows.Forms.PictureBox pictureDog;
    }
}