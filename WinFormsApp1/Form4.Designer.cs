namespace WinFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            menuStrip1 = new MenuStrip();
            sosyalMedyaToolStripMenuItem = new ToolStripMenuItem();
            instagramToolStripMenuItem = new ToolStripMenuItem();
            xToolStripMenuItem = new ToolStripMenuItem();
            tiktokToolStripMenuItem = new ToolStripMenuItem();
            whatsAppToolStripMenuItem = new ToolStripMenuItem();
            videoToolStripMenuItem = new ToolStripMenuItem();
            youtubeToolStripMenuItem = new ToolStripMenuItem();
            dizigomToolStripMenuItem = new ToolStripMenuItem();
            twitchToolStripMenuItem = new ToolStripMenuItem();
            kickToolStripMenuItem = new ToolStripMenuItem();
            müzikToolStripMenuItem = new ToolStripMenuItem();
            spotifyToolStripMenuItem = new ToolStripMenuItem();
            oyunToolStripMenuItem = new ToolStripMenuItem();
            steamToolStripMenuItem = new ToolStripMenuItem();
            epicToolStripMenuItem = new ToolStripMenuItem();
            alışverişToolStripMenuItem = new ToolStripMenuItem();
            amazonToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            hesaptanÇıkışYapToolStripMenuItem = new ToolStripMenuItem();
            uygulamayıKapatToolStripMenuItem = new ToolStripMenuItem();
            pencereToolStripMenuItem = new ToolStripMenuItem();
            küçültToolStripMenuItem = new ToolStripMenuItem();
            büyütToolStripMenuItem = new ToolStripMenuItem();
            gizleToolStripMenuItem = new ToolStripMenuItem();
            tamEkranToolStripMenuItem = new ToolStripMenuItem();
            yemekToolStripMenuItem = new ToolStripMenuItem();
            trendyolGoToolStripMenuItem = new ToolStripMenuItem();
            yemeksepetiToolStripMenuItem = new ToolStripMenuItem();
            getirToolStripMenuItem = new ToolStripMenuItem();
            migrosYemekToolStripMenuItem = new ToolStripMenuItem();
            resmiToolStripMenuItem = new ToolStripMenuItem();
            eDevletToolStripMenuItem = new ToolStripMenuItem();
            meüOBSToolStripMenuItem = new ToolStripMenuItem();
            meruzemToolStripMenuItem = new ToolStripMenuItem();
            btnFrwd = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(800, 362);
            webView21.Source = new Uri("https://google.com", UriKind.Absolute);
            webView21.TabIndex = 2;
            webView21.ZoomFactor = 1D;
            webView21.SourceChanged += webView21_SourceChanged;
            webView21.KeyDown += webView21_KeyDown;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(192, 192, 255);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sosyalMedyaToolStripMenuItem, videoToolStripMenuItem, müzikToolStripMenuItem, oyunToolStripMenuItem, alışverişToolStripMenuItem, eXITToolStripMenuItem, pencereToolStripMenuItem, yemekToolStripMenuItem, resmiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 43);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // sosyalMedyaToolStripMenuItem
            // 
            sosyalMedyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { instagramToolStripMenuItem, xToolStripMenuItem, tiktokToolStripMenuItem, whatsAppToolStripMenuItem });
            sosyalMedyaToolStripMenuItem.ForeColor = Color.FromArgb(64, 0, 64);
            sosyalMedyaToolStripMenuItem.Name = "sosyalMedyaToolStripMenuItem";
            sosyalMedyaToolStripMenuItem.Size = new Size(114, 39);
            sosyalMedyaToolStripMenuItem.Text = "Sosyal Medya";
            sosyalMedyaToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // instagramToolStripMenuItem
            // 
            instagramToolStripMenuItem.BackColor = Color.RosyBrown;
            instagramToolStripMenuItem.Image = Resource1.Instagram;
            instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            instagramToolStripMenuItem.Size = new Size(224, 26);
            instagramToolStripMenuItem.Text = "Instagram";
            instagramToolStripMenuItem.Click += instagramToolStripMenuItem_Click;
            // 
            // xToolStripMenuItem
            // 
            xToolStripMenuItem.BackColor = Color.DodgerBlue;
            xToolStripMenuItem.Image = (Image)resources.GetObject("xToolStripMenuItem.Image");
            xToolStripMenuItem.Name = "xToolStripMenuItem";
            xToolStripMenuItem.Size = new Size(224, 26);
            xToolStripMenuItem.Text = "X";
            xToolStripMenuItem.Click += xToolStripMenuItem_Click;
            // 
            // tiktokToolStripMenuItem
            // 
            tiktokToolStripMenuItem.BackColor = Color.FromArgb(192, 0, 192);
            tiktokToolStripMenuItem.Image = Resource1.TikTok;
            tiktokToolStripMenuItem.Name = "tiktokToolStripMenuItem";
            tiktokToolStripMenuItem.Size = new Size(224, 26);
            tiktokToolStripMenuItem.Text = "Tiktok";
            tiktokToolStripMenuItem.Click += tiktokToolStripMenuItem_Click;
            // 
            // whatsAppToolStripMenuItem
            // 
            whatsAppToolStripMenuItem.BackColor = Color.Green;
            whatsAppToolStripMenuItem.Image = Resource1.WhatsApp;
            whatsAppToolStripMenuItem.Name = "whatsAppToolStripMenuItem";
            whatsAppToolStripMenuItem.Size = new Size(224, 26);
            whatsAppToolStripMenuItem.Text = "WhatsApp";
            whatsAppToolStripMenuItem.Click += whatsAppToolStripMenuItem_Click;
            // 
            // videoToolStripMenuItem
            // 
            videoToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            videoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { youtubeToolStripMenuItem, dizigomToolStripMenuItem, twitchToolStripMenuItem, kickToolStripMenuItem });
            videoToolStripMenuItem.ForeColor = Color.FromArgb(64, 0, 64);
            videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            videoToolStripMenuItem.Size = new Size(62, 39);
            videoToolStripMenuItem.Text = "Video";
            // 
            // youtubeToolStripMenuItem
            // 
            youtubeToolStripMenuItem.BackColor = Color.Red;
            youtubeToolStripMenuItem.ForeColor = Color.White;
            youtubeToolStripMenuItem.Image = Resource1.YouTube;
            youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            youtubeToolStripMenuItem.Size = new Size(149, 26);
            youtubeToolStripMenuItem.Text = "Youtube";
            youtubeToolStripMenuItem.Click += youtubeToolStripMenuItem_Click;
            // 
            // dizigomToolStripMenuItem
            // 
            dizigomToolStripMenuItem.Name = "dizigomToolStripMenuItem";
            dizigomToolStripMenuItem.Size = new Size(149, 26);
            dizigomToolStripMenuItem.Text = "Dizigom";
            dizigomToolStripMenuItem.Click += dizigomToolStripMenuItem_Click;
            // 
            // twitchToolStripMenuItem
            // 
            twitchToolStripMenuItem.BackColor = Color.Purple;
            twitchToolStripMenuItem.ForeColor = Color.FromArgb(255, 192, 255);
            twitchToolStripMenuItem.Image = Resource1.Twitch;
            twitchToolStripMenuItem.Name = "twitchToolStripMenuItem";
            twitchToolStripMenuItem.Size = new Size(149, 26);
            twitchToolStripMenuItem.Text = "Twitch";
            twitchToolStripMenuItem.Click += twitchToolStripMenuItem_Click;
            // 
            // kickToolStripMenuItem
            // 
            kickToolStripMenuItem.BackColor = Color.Green;
            kickToolStripMenuItem.ForeColor = Color.FromArgb(128, 255, 128);
            kickToolStripMenuItem.Name = "kickToolStripMenuItem";
            kickToolStripMenuItem.Size = new Size(149, 26);
            kickToolStripMenuItem.Text = "Kick";
            kickToolStripMenuItem.Click += kickToolStripMenuItem_Click;
            // 
            // müzikToolStripMenuItem
            // 
            müzikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { spotifyToolStripMenuItem });
            müzikToolStripMenuItem.ForeColor = Color.FromArgb(64, 0, 64);
            müzikToolStripMenuItem.Name = "müzikToolStripMenuItem";
            müzikToolStripMenuItem.Size = new Size(62, 39);
            müzikToolStripMenuItem.Text = "Müzik";
            // 
            // spotifyToolStripMenuItem
            // 
            spotifyToolStripMenuItem.BackColor = Color.DarkSeaGreen;
            spotifyToolStripMenuItem.ForeColor = Color.White;
            spotifyToolStripMenuItem.Image = Resource1.Spotify;
            spotifyToolStripMenuItem.Name = "spotifyToolStripMenuItem";
            spotifyToolStripMenuItem.Size = new Size(139, 26);
            spotifyToolStripMenuItem.Text = "Spotify";
            spotifyToolStripMenuItem.Click += spotifyToolStripMenuItem_Click;
            // 
            // oyunToolStripMenuItem
            // 
            oyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { steamToolStripMenuItem, epicToolStripMenuItem });
            oyunToolStripMenuItem.ForeColor = Color.FromArgb(64, 0, 64);
            oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            oyunToolStripMenuItem.Size = new Size(57, 39);
            oyunToolStripMenuItem.Text = "Oyun";
            // 
            // steamToolStripMenuItem
            // 
            steamToolStripMenuItem.BackColor = Color.RoyalBlue;
            steamToolStripMenuItem.ForeColor = Color.White;
            steamToolStripMenuItem.Image = Resource1.Steam;
            steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            steamToolStripMenuItem.Size = new Size(134, 26);
            steamToolStripMenuItem.Text = "Steam";
            steamToolStripMenuItem.Click += steamToolStripMenuItem_Click;
            // 
            // epicToolStripMenuItem
            // 
            epicToolStripMenuItem.BackColor = Color.Black;
            epicToolStripMenuItem.ForeColor = Color.White;
            epicToolStripMenuItem.Image = Resource1.Epic_Games;
            epicToolStripMenuItem.Name = "epicToolStripMenuItem";
            epicToolStripMenuItem.Size = new Size(134, 26);
            epicToolStripMenuItem.Text = "Epic";
            epicToolStripMenuItem.Click += epicToolStripMenuItem_Click;
            // 
            // alışverişToolStripMenuItem
            // 
            alışverişToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { amazonToolStripMenuItem });
            alışverişToolStripMenuItem.ForeColor = Color.FromArgb(64, 0, 64);
            alışverişToolStripMenuItem.Name = "alışverişToolStripMenuItem";
            alışverişToolStripMenuItem.Size = new Size(77, 39);
            alışverişToolStripMenuItem.Text = "Alışveriş";
            // 
            // amazonToolStripMenuItem
            // 
            amazonToolStripMenuItem.Image = Resource1.Amazon;
            amazonToolStripMenuItem.Name = "amazonToolStripMenuItem";
            amazonToolStripMenuItem.Size = new Size(147, 26);
            amazonToolStripMenuItem.Text = "Amazon";
            amazonToolStripMenuItem.Click += amazonToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            eXITToolStripMenuItem.BackColor = Color.Red;
            eXITToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hesaptanÇıkışYapToolStripMenuItem, uygulamayıKapatToolStripMenuItem });
            eXITToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            eXITToolStripMenuItem.Margin = new Padding(0, 0, 2, 0);
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(52, 39);
            eXITToolStripMenuItem.Text = "EXIT";
            // 
            // hesaptanÇıkışYapToolStripMenuItem
            // 
            hesaptanÇıkışYapToolStripMenuItem.BackColor = SystemColors.ButtonShadow;
            hesaptanÇıkışYapToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            hesaptanÇıkışYapToolStripMenuItem.Image = Resource1.Profile;
            hesaptanÇıkışYapToolStripMenuItem.Name = "hesaptanÇıkışYapToolStripMenuItem";
            hesaptanÇıkışYapToolStripMenuItem.Size = new Size(217, 26);
            hesaptanÇıkışYapToolStripMenuItem.Text = "Hesaptan Çıkış Yap";
            hesaptanÇıkışYapToolStripMenuItem.Click += hesaptanÇıkışYapToolStripMenuItem_Click;
            // 
            // uygulamayıKapatToolStripMenuItem
            // 
            uygulamayıKapatToolStripMenuItem.BackColor = Color.Red;
            uygulamayıKapatToolStripMenuItem.ForeColor = Color.White;
            uygulamayıKapatToolStripMenuItem.Image = Resource1.Shutdown;
            uygulamayıKapatToolStripMenuItem.Name = "uygulamayıKapatToolStripMenuItem";
            uygulamayıKapatToolStripMenuItem.Size = new Size(217, 26);
            uygulamayıKapatToolStripMenuItem.Text = "Uygulamayı Kapat";
            uygulamayıKapatToolStripMenuItem.Click += uygulamayıKapatToolStripMenuItem_Click;
            // 
            // pencereToolStripMenuItem
            // 
            pencereToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            pencereToolStripMenuItem.BackColor = Color.Black;
            pencereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { küçültToolStripMenuItem, büyütToolStripMenuItem, gizleToolStripMenuItem, tamEkranToolStripMenuItem });
            pencereToolStripMenuItem.ForeColor = Color.Red;
            pencereToolStripMenuItem.Margin = new Padding(0, 0, 5, 0);
            pencereToolStripMenuItem.Name = "pencereToolStripMenuItem";
            pencereToolStripMenuItem.RightToLeft = RightToLeft.No;
            pencereToolStripMenuItem.Size = new Size(74, 39);
            pencereToolStripMenuItem.Text = "Pencere";
            // 
            // küçültToolStripMenuItem
            // 
            küçültToolStripMenuItem.BackColor = SystemColors.ControlLight;
            küçültToolStripMenuItem.Image = Resource1.Collapse;
            küçültToolStripMenuItem.Name = "küçültToolStripMenuItem";
            küçültToolStripMenuItem.ShortcutKeyDisplayString = "F11";
            küçültToolStripMenuItem.Size = new Size(165, 26);
            küçültToolStripMenuItem.Text = "Küçült";
            küçültToolStripMenuItem.Click += küçültToolStripMenuItem_Click;
            // 
            // büyütToolStripMenuItem
            // 
            büyütToolStripMenuItem.BackColor = SystemColors.ControlDark;
            büyütToolStripMenuItem.Image = Resource1.Expand;
            büyütToolStripMenuItem.Name = "büyütToolStripMenuItem";
            büyütToolStripMenuItem.Size = new Size(165, 26);
            büyütToolStripMenuItem.Text = "Büyüt";
            büyütToolStripMenuItem.Click += büyütToolStripMenuItem_Click;
            // 
            // gizleToolStripMenuItem
            // 
            gizleToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            gizleToolStripMenuItem.Image = Resource1.Hide;
            gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            gizleToolStripMenuItem.Size = new Size(165, 26);
            gizleToolStripMenuItem.Text = "Gizle";
            gizleToolStripMenuItem.Click += gizleToolStripMenuItem_Click;
            // 
            // tamEkranToolStripMenuItem
            // 
            tamEkranToolStripMenuItem.BackColor = SystemColors.ControlText;
            tamEkranToolStripMenuItem.ForeColor = SystemColors.Control;
            tamEkranToolStripMenuItem.Name = "tamEkranToolStripMenuItem";
            tamEkranToolStripMenuItem.Size = new Size(165, 26);
            tamEkranToolStripMenuItem.Text = "Tam Ekran";
            tamEkranToolStripMenuItem.Click += tamEkranToolStripMenuItem_Click;
            // 
            // yemekToolStripMenuItem
            // 
            yemekToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trendyolGoToolStripMenuItem, yemeksepetiToolStripMenuItem, getirToolStripMenuItem, migrosYemekToolStripMenuItem });
            yemekToolStripMenuItem.Name = "yemekToolStripMenuItem";
            yemekToolStripMenuItem.Size = new Size(66, 39);
            yemekToolStripMenuItem.Text = "Yemek";
            // 
            // trendyolGoToolStripMenuItem
            // 
            trendyolGoToolStripMenuItem.BackColor = Color.OrangeRed;
            trendyolGoToolStripMenuItem.ForeColor = Color.Black;
            trendyolGoToolStripMenuItem.Image = Resource1.T_Lowercase;
            trendyolGoToolStripMenuItem.Name = "trendyolGoToolStripMenuItem";
            trendyolGoToolStripMenuItem.Size = new Size(185, 26);
            trendyolGoToolStripMenuItem.Text = "Trendyol Go";
            trendyolGoToolStripMenuItem.Click += trendyolGoToolStripMenuItem_Click;
            // 
            // yemeksepetiToolStripMenuItem
            // 
            yemeksepetiToolStripMenuItem.BackColor = Color.Tomato;
            yemeksepetiToolStripMenuItem.ForeColor = Color.Black;
            yemeksepetiToolStripMenuItem.Image = Resource1.Y;
            yemeksepetiToolStripMenuItem.Name = "yemeksepetiToolStripMenuItem";
            yemeksepetiToolStripMenuItem.Size = new Size(185, 26);
            yemeksepetiToolStripMenuItem.Text = "Yemeksepeti";
            yemeksepetiToolStripMenuItem.Click += yemeksepetiToolStripMenuItem_Click;
            // 
            // getirToolStripMenuItem
            // 
            getirToolStripMenuItem.BackColor = Color.MediumOrchid;
            getirToolStripMenuItem.ForeColor = Color.White;
            getirToolStripMenuItem.Image = Resource1.Goodreads;
            getirToolStripMenuItem.Name = "getirToolStripMenuItem";
            getirToolStripMenuItem.Size = new Size(185, 26);
            getirToolStripMenuItem.Text = "Getir";
            getirToolStripMenuItem.Click += getirToolStripMenuItem_Click;
            // 
            // migrosYemekToolStripMenuItem
            // 
            migrosYemekToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            migrosYemekToolStripMenuItem.ForeColor = Color.White;
            migrosYemekToolStripMenuItem.Image = Resource1.Marker_M;
            migrosYemekToolStripMenuItem.Name = "migrosYemekToolStripMenuItem";
            migrosYemekToolStripMenuItem.Size = new Size(185, 26);
            migrosYemekToolStripMenuItem.Text = "Migros Yemek";
            migrosYemekToolStripMenuItem.Click += migrosYemekToolStripMenuItem_Click;
            // 
            // resmiToolStripMenuItem
            // 
            resmiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eDevletToolStripMenuItem, meüOBSToolStripMenuItem, meruzemToolStripMenuItem });
            resmiToolStripMenuItem.Name = "resmiToolStripMenuItem";
            resmiToolStripMenuItem.Size = new Size(63, 39);
            resmiToolStripMenuItem.Text = "Resmi";
            // 
            // eDevletToolStripMenuItem
            // 
            eDevletToolStripMenuItem.BackColor = Color.Red;
            eDevletToolStripMenuItem.ForeColor = Color.White;
            eDevletToolStripMenuItem.Image = (Image)resources.GetObject("eDevletToolStripMenuItem.Image");
            eDevletToolStripMenuItem.Name = "eDevletToolStripMenuItem";
            eDevletToolStripMenuItem.Size = new Size(154, 26);
            eDevletToolStripMenuItem.Text = "E-Devlet";
            eDevletToolStripMenuItem.Click += eDevletToolStripMenuItem_Click;
            // 
            // meüOBSToolStripMenuItem
            // 
            meüOBSToolStripMenuItem.BackColor = Color.Wheat;
            meüOBSToolStripMenuItem.Image = (Image)resources.GetObject("meüOBSToolStripMenuItem.Image");
            meüOBSToolStripMenuItem.Name = "meüOBSToolStripMenuItem";
            meüOBSToolStripMenuItem.Size = new Size(154, 26);
            meüOBSToolStripMenuItem.Text = "Meü OBS";
            meüOBSToolStripMenuItem.Click += meüOBSToolStripMenuItem_Click;
            // 
            // meruzemToolStripMenuItem
            // 
            meruzemToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            meruzemToolStripMenuItem.ForeColor = Color.White;
            meruzemToolStripMenuItem.Image = Resource1.Video_Call;
            meruzemToolStripMenuItem.Name = "meruzemToolStripMenuItem";
            meruzemToolStripMenuItem.Size = new Size(154, 26);
            meruzemToolStripMenuItem.Text = "Meruzem";
            meruzemToolStripMenuItem.Click += meruzemToolStripMenuItem_Click;
            // 
            // btnFrwd
            // 
            btnFrwd.Location = new Point(49, 3);
            btnFrwd.Name = "btnFrwd";
            btnFrwd.Size = new Size(40, 40);
            btnFrwd.TabIndex = 4;
            btnFrwd.Text = "►";
            btnFrwd.UseVisualStyleBackColor = true;
            btnFrwd.Click += btnFrwd_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "◄";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnFrwd);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(701, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 6;
            button1.Text = "GİT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox1.Location = new Point(184, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "https://";
            textBox1.Size = new Size(513, 40);
            textBox1.TabIndex = 5;
            textBox1.Text = "https://";
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.MouseDoubleClick += textBox1_MouseDoubleClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 5F);
            button3.Location = new Point(138, 3);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 4;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(95, 3);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 4;
            button2.Text = "F5";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(webView21);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 362);
            panel2.TabIndex = 6;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GT3RS";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form4_FormClosed;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sosyalMedyaToolStripMenuItem;
        private ToolStripMenuItem instagramToolStripMenuItem;
        private ToolStripMenuItem xToolStripMenuItem;
        private ToolStripMenuItem videoToolStripMenuItem;
        private ToolStripMenuItem youtubeToolStripMenuItem;
        private ToolStripMenuItem müzikToolStripMenuItem;
        private ToolStripMenuItem spotifyToolStripMenuItem;
        private ToolStripMenuItem oyunToolStripMenuItem;
        private ToolStripMenuItem steamToolStripMenuItem;
        private ToolStripMenuItem alışverişToolStripMenuItem;
        private ToolStripMenuItem amazonToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem hesaptanÇıkışYapToolStripMenuItem;
        private ToolStripMenuItem uygulamayıKapatToolStripMenuItem;
        private ToolStripMenuItem dizigomToolStripMenuItem;
        private ToolStripMenuItem pencereToolStripMenuItem;
        private ToolStripMenuItem küçültToolStripMenuItem;
        private ToolStripMenuItem gizleToolStripMenuItem;
        private ToolStripMenuItem büyütToolStripMenuItem;
        private ToolStripMenuItem yemekToolStripMenuItem;
        private ToolStripMenuItem trendyolGoToolStripMenuItem;
        private ToolStripMenuItem yemeksepetiToolStripMenuItem;
        private ToolStripMenuItem getirToolStripMenuItem;
        private ToolStripMenuItem migrosYemekToolStripMenuItem;
        private ToolStripMenuItem tiktokToolStripMenuItem;
        private ToolStripMenuItem epicToolStripMenuItem;
        private ToolStripMenuItem resmiToolStripMenuItem;
        private ToolStripMenuItem whatsAppToolStripMenuItem;
        private ToolStripMenuItem twitchToolStripMenuItem;
        private ToolStripMenuItem kickToolStripMenuItem;
        private ToolStripMenuItem eDevletToolStripMenuItem;
        private ToolStripMenuItem meüOBSToolStripMenuItem;
        private ToolStripMenuItem meruzemToolStripMenuItem;
        private ToolStripMenuItem tamEkranToolStripMenuItem;
        private Button btnFrwd;
        private Button btnBack;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}