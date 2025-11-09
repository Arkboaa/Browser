using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private HashSet<string> blockedHosts = new HashSet<string>();
        private HashSet<string> whiteListedHosts = new HashSet<string>();

        private const string EasyListUrl = "https://raw.githubusercontent.com/smed79/easylist-hosts/main/hosts";
        private const string LocalEasyListFile = "easylist_hosts.txt";

        public Form4()
        {
            InitializeComponent();
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.AcceptsReturn = false;
        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            if (webView21 != null)
            {
                // WebView2 ortamını başlat
                if (webView21.CoreWebView2 == null)
                    await webView21.EnsureCoreWebView2Async();

                // EasyList’i güncelle ve yükle
                await UpdateEasyListAsync();
                LoadEasyList();

                // AdBlock mantığını ekle
                AddEasyListAdBlock();

                // Başlangıç sayfası
                webView21.Source = new Uri("https://www.google.com/");
            }
        }

        private async Task UpdateEasyListAsync()
        {
            try
            {
                using (var http = new HttpClient())
                {
                    string content = await http.GetStringAsync(EasyListUrl);
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LocalEasyListFile);
                    await File.WriteAllTextAsync(path, content);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("EasyList güncellenemedi: " + ex.Message);
            }
        }

        private void LoadEasyList()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LocalEasyListFile);
            blockedHosts.Clear();
            whiteListedHosts.Clear();

            if (!File.Exists(path))
                return;

            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                string trimmed = line.Trim();
                if (string.IsNullOrWhiteSpace(trimmed) || trimmed.StartsWith("!") || trimmed.StartsWith("[") || trimmed.Contains("##"))
                    continue;

                if (trimmed.StartsWith("@@||"))
                {
                    string host = ParseHost(trimmed.Substring(4));
                    if (!string.IsNullOrEmpty(host))
                        whiteListedHosts.Add(host.ToLower());
                }
                else if (trimmed.StartsWith("||"))
                {
                    string host = ParseHost(trimmed.Substring(2));
                    if (!string.IsNullOrEmpty(host))
                        blockedHosts.Add(host.ToLower());
                }
            }
        }

        private string ParseHost(string rule)
        {
            int end = rule.IndexOfAny(new char[] { '^', '/', '$', '?' });
            if (end <= 0)
                return end == 0 ? null : rule;
            return rule.Substring(0, end);
        }

        private void AddEasyListAdBlock()
        {
            webView21.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.All);
            webView21.CoreWebView2.WebResourceRequested += (sender, args) =>
            {
                try
                {
                    Uri reqUri = new Uri(args.Request.Uri);
                    string host = reqUri.Host.ToLower();

                    if (IsHostInList(host, whiteListedHosts))
                        return;

                    if (IsHostInList(host, blockedHosts))
                    {
                        args.Response = webView21.CoreWebView2.Environment.CreateWebResourceResponse(
                            Stream.Null, 403, "Blocked by EasyList", "Content-Type: text/plain");
                    }
                }
                catch { }
            };
        }

        private bool IsHostInList(string host, HashSet<string> list)
        {
            var parts = host.Split('.');
            for (int i = 0; i <= parts.Length - 2; i++)
            {
                string domain = string.Join(".", parts, i, parts.Length - i);
                if (list.Contains(domain))
                    return true;
            }
            return false;
        }

        // -------------------------------------------------------------------
        // BU KISIMDAN SONRASI SENİN ORİJİNAL KODUN, HİÇ DOKUNULMADI
        // -------------------------------------------------------------------

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

        private void sahibindenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://sahibinden.com");
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
            webView21.Source = new Uri(textBox1.Text);
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

        private void webView21_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
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