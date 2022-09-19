namespace Tamagotchi
{
    partial class Tama
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tama));
            this.YES = new System.Windows.Forms.Button();
            this.FEED = new System.Windows.Forms.Button();
            this.pictureTama = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Your_name = new System.Windows.Forms.Label();
            this.Enter_name = new System.Windows.Forms.Label();
            this.SLEEP = new System.Windows.Forms.Button();
            this.PLAY = new System.Windows.Forms.Button();
            this.CURE = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.progressSleep = new System.Windows.Forms.ProgressBar();
            this.progressCure = new System.Windows.Forms.ProgressBar();
            this.progressFeed = new System.Windows.Forms.ProgressBar();
            this.progressPlay = new System.Windows.Forms.ProgressBar();
            this.enterTname = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.Tama_waste = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tama_waste)).BeginInit();
            this.SuspendLayout();
            // 
            // YES
            // 
            this.YES.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YES.BackColor = System.Drawing.Color.Transparent;
            this.YES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YES.BackgroundImage")));
            this.YES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YES.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.YES.Location = new System.Drawing.Point(142, 12);
            this.YES.Name = "YES";
            this.YES.Size = new System.Drawing.Size(93, 75);
            this.YES.TabIndex = 0;
            this.YES.Text = "?";
            this.YES.UseVisualStyleBackColor = false;
            this.YES.Click += new System.EventHandler(this.YES_Click);
            // 
            // FEED
            // 
            this.FEED.Location = new System.Drawing.Point(70, 151);
            this.FEED.Name = "FEED";
            this.FEED.Size = new System.Drawing.Size(107, 36);
            this.FEED.TabIndex = 1;
            this.FEED.Text = "Кормить";
            this.FEED.UseVisualStyleBackColor = true;
            this.FEED.Click += new System.EventHandler(this.FEED_Click);
            // 
            // pictureTama
            // 
            this.pictureTama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureTama.Image = ((System.Drawing.Image)(resources.GetObject("pictureTama.Image")));
            this.pictureTama.Location = new System.Drawing.Point(251, 97);
            this.pictureTama.Margin = new System.Windows.Forms.Padding(1);
            this.pictureTama.Name = "pictureTama";
            this.pictureTama.Size = new System.Drawing.Size(332, 279);
            this.pictureTama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTama.TabIndex = 2;
            this.pictureTama.TabStop = false;
            this.pictureTama.WaitOnLoad = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Your_name
            // 
            this.Your_name.AutoSize = true;
            this.Your_name.Location = new System.Drawing.Point(374, 24);
            this.Your_name.Name = "Your_name";
            this.Your_name.Size = new System.Drawing.Size(89, 20);
            this.Your_name.TabIndex = 3;
            this.Your_name.Text = "Привет, Х!";
            // 
            // Enter_name
            // 
            this.Enter_name.AutoSize = true;
            this.Enter_name.Location = new System.Drawing.Point(224, 503);
            this.Enter_name.Name = "Enter_name";
            this.Enter_name.Size = new System.Drawing.Size(148, 20);
            this.Enter_name.TabIndex = 4;
            this.Enter_name.Text = "Введите свое имя";
            // 
            // SLEEP
            // 
            this.SLEEP.Location = new System.Drawing.Point(650, 151);
            this.SLEEP.Name = "SLEEP";
            this.SLEEP.Size = new System.Drawing.Size(107, 36);
            this.SLEEP.TabIndex = 5;
            this.SLEEP.Text = "Спать";
            this.SLEEP.UseVisualStyleBackColor = true;
            this.SLEEP.Click += new System.EventHandler(this.SLEEP_Click);
            // 
            // PLAY
            // 
            this.PLAY.Location = new System.Drawing.Point(70, 254);
            this.PLAY.Name = "PLAY";
            this.PLAY.Size = new System.Drawing.Size(107, 36);
            this.PLAY.TabIndex = 6;
            this.PLAY.Text = "Играть";
            this.PLAY.UseVisualStyleBackColor = true;
            this.PLAY.Click += new System.EventHandler(this.PLAY_Click);
            // 
            // CURE
            // 
            this.CURE.Location = new System.Drawing.Point(650, 252);
            this.CURE.Name = "CURE";
            this.CURE.Size = new System.Drawing.Size(107, 38);
            this.CURE.TabIndex = 7;
            this.CURE.Text = "Лечить";
            this.CURE.UseVisualStyleBackColor = true;
            this.CURE.Click += new System.EventHandler(this.CURE_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CLEAR.Location = new System.Drawing.Point(617, 338);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(183, 38);
            this.CLEAR.TabIndex = 8;
            this.CLEAR.Text = "Убрать за зверьком ";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // progressSleep
            // 
            this.progressSleep.Location = new System.Drawing.Point(628, 107);
            this.progressSleep.Name = "progressSleep";
            this.progressSleep.Size = new System.Drawing.Size(162, 38);
            this.progressSleep.TabIndex = 9;
            this.progressSleep.Value = 50;
            // 
            // progressCure
            // 
            this.progressCure.Location = new System.Drawing.Point(628, 207);
            this.progressCure.Name = "progressCure";
            this.progressCure.Size = new System.Drawing.Size(162, 39);
            this.progressCure.TabIndex = 10;
            this.progressCure.Value = 50;
            // 
            // progressFeed
            // 
            this.progressFeed.BackColor = System.Drawing.Color.White;
            this.progressFeed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressFeed.Location = new System.Drawing.Point(46, 107);
            this.progressFeed.MarqueeAnimationSpeed = 1000;
            this.progressFeed.Name = "progressFeed";
            this.progressFeed.Size = new System.Drawing.Size(164, 38);
            this.progressFeed.TabIndex = 1;
            this.progressFeed.Value = 50;
            // 
            // progressPlay
            // 
            this.progressPlay.BackColor = System.Drawing.Color.Ivory;
            this.progressPlay.ForeColor = System.Drawing.Color.Chartreuse;
            this.progressPlay.Location = new System.Drawing.Point(46, 208);
            this.progressPlay.Name = "progressPlay";
            this.progressPlay.Size = new System.Drawing.Size(162, 38);
            this.progressPlay.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressPlay.TabIndex = 12;
            this.progressPlay.Value = 50;
            // 
            // enterTname
            // 
            this.enterTname.BackColor = System.Drawing.SystemColors.Control;
            this.enterTname.Location = new System.Drawing.Point(404, 490);
            this.enterTname.Multiline = true;
            this.enterTname.Name = "enterTname";
            this.enterTname.Size = new System.Drawing.Size(204, 42);
            this.enterTname.TabIndex = 13;
            this.enterTname.TextChanged += new System.EventHandler(this.enterTname_TextChanged);
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Location = new System.Drawing.Point(628, 490);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(55, 47);
            this.OK.TabIndex = 15;
            this.OK.Text = "ок";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(27, 506);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(92, 31);
            this.help.TabIndex = 16;
            this.help.Text = "Помощь";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Tama_waste
            // 
            this.Tama_waste.Image = ((System.Drawing.Image)(resources.GetObject("Tama_waste.Image")));
            this.Tama_waste.Location = new System.Drawing.Point(87, 347);
            this.Tama_waste.Name = "Tama_waste";
            this.Tama_waste.Size = new System.Drawing.Size(133, 105);
            this.Tama_waste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tama_waste.TabIndex = 17;
            this.Tama_waste.TabStop = false;
            this.Tama_waste.Visible = false;
            // 
            // Tama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(824, 558);
            this.Controls.Add(this.enterTname);
            this.Controls.Add(this.YES);
            this.Controls.Add(this.Tama_waste);
            this.Controls.Add(this.help);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.progressPlay);
            this.Controls.Add(this.progressFeed);
            this.Controls.Add(this.progressCure);
            this.Controls.Add(this.progressSleep);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.CURE);
            this.Controls.Add(this.PLAY);
            this.Controls.Add(this.SLEEP);
            this.Controls.Add(this.Enter_name);
            this.Controls.Add(this.Your_name);
            this.Controls.Add(this.FEED);
            this.Controls.Add(this.pictureTama);
            this.MaximizeBox = false;
            this.Name = "Tama";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAMAGOTCHI";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonHighlight;
            this.Load += new System.EventHandler(this.Tama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tama_waste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YES;
        private System.Windows.Forms.Button FEED;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Your_name;
        private System.Windows.Forms.Label Enter_name;
        private System.Windows.Forms.Button SLEEP;
        private System.Windows.Forms.Button PLAY;
        private System.Windows.Forms.Button CURE;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.ProgressBar progressSleep;
        private System.Windows.Forms.ProgressBar progressCure;
        private System.Windows.Forms.ProgressBar progressFeed;
        private System.Windows.Forms.ProgressBar progressPlay;
        private System.Windows.Forms.TextBox enterTname;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.PictureBox Tama_waste;
        private System.Windows.Forms.PictureBox pictureTama;
    }
}

