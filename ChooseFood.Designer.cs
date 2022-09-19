namespace Tamagotchi
{
    partial class ChooseFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFood));
            this.BREAD = new System.Windows.Forms.Label();
            this.BANANA = new System.Windows.Forms.Label();
            this.SWEET = new System.Windows.Forms.Label();
            this.pictureBread = new System.Windows.Forms.PictureBox();
            this.pictureBanana = new System.Windows.Forms.PictureBox();
            this.pictureSweet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSweet)).BeginInit();
            this.SuspendLayout();
            // 
            // BREAD
            // 
            this.BREAD.AutoSize = true;
            this.BREAD.Location = new System.Drawing.Point(128, 127);
            this.BREAD.Name = "BREAD";
            this.BREAD.Size = new System.Drawing.Size(54, 20);
            this.BREAD.TabIndex = 0;
            this.BREAD.Text = "ХЛЕБ";
            // 
            // BANANA
            // 
            this.BANANA.AutoSize = true;
            this.BANANA.Location = new System.Drawing.Point(391, 127);
            this.BANANA.Name = "BANANA";
            this.BANANA.Size = new System.Drawing.Size(66, 20);
            this.BANANA.TabIndex = 1;
            this.BANANA.Text = "БАНАН";
            // 
            // SWEET
            // 
            this.SWEET.AutoSize = true;
            this.SWEET.Location = new System.Drawing.Point(650, 127);
            this.SWEET.Name = "SWEET";
            this.SWEET.Size = new System.Drawing.Size(89, 20);
            this.SWEET.TabIndex = 2;
            this.SWEET.Text = "КОНФЕТА";
            // 
            // pictureBread
            // 
            this.pictureBread.Image = ((System.Drawing.Image)(resources.GetObject("pictureBread.Image")));
            this.pictureBread.Location = new System.Drawing.Point(54, 165);
            this.pictureBread.Name = "pictureBread";
            this.pictureBread.Size = new System.Drawing.Size(216, 220);
            this.pictureBread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBread.TabIndex = 3;
            this.pictureBread.TabStop = false;
            this.pictureBread.Click += new System.EventHandler(this.pictureBread_Click);
            // 
            // pictureBanana
            // 
            this.pictureBanana.Image = ((System.Drawing.Image)(resources.GetObject("pictureBanana.Image")));
            this.pictureBanana.Location = new System.Drawing.Point(316, 165);
            this.pictureBanana.Name = "pictureBanana";
            this.pictureBanana.Size = new System.Drawing.Size(227, 220);
            this.pictureBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBanana.TabIndex = 4;
            this.pictureBanana.TabStop = false;
            this.pictureBanana.Click += new System.EventHandler(this.pictureBanana_Click);
            // 
            // pictureSweet
            // 
            this.pictureSweet.Image = ((System.Drawing.Image)(resources.GetObject("pictureSweet.Image")));
            this.pictureSweet.Location = new System.Drawing.Point(596, 165);
            this.pictureSweet.Name = "pictureSweet";
            this.pictureSweet.Size = new System.Drawing.Size(185, 220);
            this.pictureSweet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSweet.TabIndex = 5;
            this.pictureSweet.TabStop = false;
            this.pictureSweet.Click += new System.EventHandler(this.pictureSweet_Click);
            // 
            // ChooseFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(880, 533);
            this.Controls.Add(this.pictureSweet);
            this.Controls.Add(this.pictureBanana);
            this.Controls.Add(this.pictureBread);
            this.Controls.Add(this.SWEET);
            this.Controls.Add(this.BANANA);
            this.Controls.Add(this.BREAD);
            this.Name = "ChooseFood";
            this.ShowIcon = false;
            this.Text = "ChooseFood";
            this.Load += new System.EventHandler(this.ChooseFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSweet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BREAD;
        private System.Windows.Forms.Label BANANA;
        private System.Windows.Forms.Label SWEET;
        private System.Windows.Forms.PictureBox pictureBread;
        private System.Windows.Forms.PictureBox pictureBanana;
        private System.Windows.Forms.PictureBox pictureSweet;
    }
}