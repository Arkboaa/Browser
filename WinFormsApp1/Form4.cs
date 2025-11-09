using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.AcceptsReturn = false;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (webView21?.CoreWebView2 != null)
            {
                webView21!.Reload();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/");

        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.instagram.com/");
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.x.com/");
        }

        private void spotifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.spotify.com/");
        }

        private void steamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://store.steampowered.com/");
        }

        private void amazonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.amazon.com.tr/");
        }

        private void hesaptanÇıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Dispose();

        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void küçültToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void büyütToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Hide();
            panel1.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void dizigomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.dizigom101.com/");
        }


        private void trendyolGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://tgoyemek.com/");
        }

        private void yemeksepetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.yemeksepeti.com/");
        }

        private void getirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://getir.com/yemek");
        }

        private void migrosYemekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.migros.com.tr/yemek");
        }

        private void tiktokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.tiktok.com");
        }

        private void epicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://store.epicgames.com/tr");
        }

        private void whatsAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://web.whatsapp.com");
        }

        private void twitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.twitch.tv");
        }

        private void kickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://kick.com");
        }

        private void eDevletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://giris.turkiye.gov.tr/Giris");
        }

        private void meüOBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://obs.mersin.edu.tr");
        }

        private void meruzemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://ue.mersin.edu.tr");
        }
        private void webView21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                menuStrip1.Show();
                panel1.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
                webView21.GoBack();
        }

        private void btnFrwd_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward)
                webView21.GoForward();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            webView21.Source = new Uri("" + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.com/");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.PerformClick();
            }
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            if (webView21 != null && webView21.Source != null)
            {
                textBox1.Text = webView21.Source.AbsoluteUri;
            }
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int startIndex = 8;
            if (startIndex > textBox1.TextLength)
                startIndex = textBox1.TextLength;

            int length = Math.Max(0, textBox1.TextLength - startIndex);

            textBox1.Focus();
            textBox1.Select(startIndex, length);
        }
    }
}
