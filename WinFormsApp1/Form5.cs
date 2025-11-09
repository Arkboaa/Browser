using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        private WebView2 webView;

        public Form5()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            webView = new WebView2
            {
                Left = listBox1.Right + 20,
                Top = listBox1.Top,
                Width = 640,
                Height = 360
            };

            this.Controls.Add(webView);
            await webView.EnsureCoreWebView2Async(null);

            if (webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = true;
                webView.CoreWebView2.Settings.IsStatusBarEnabled = false;
                webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
                webView.CoreWebView2.Settings.AreHostObjectsAllowed = true;
            }

            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string apiKey = "AIzaSyAnQVfdwcvMTSXE7w8TcUIBVrmrmXMDouQ";
            string searchQuery = txtSearch.Text;

            listBox1.Items.Clear();
            await SearchYouTubeAsync(apiKey, searchQuery);
        }

        private async Task SearchYouTubeAsync(string apiKey, string query)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey,
                ApplicationName = "WinFormsApp1"
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = query;
            searchListRequest.MaxResults = 10;
            searchListRequest.Type = "video";

            var response = await searchListRequest.ExecuteAsync();

            foreach (var item in response.Items)
            {
                if (item.Id.Kind == "youtube#video")
                {
                    string title = item.Snippet.Title;
                    string videoId = item.Id.VideoId;
                    string url = $"https://www.youtube.com/watch?v={videoId}";

                    listBox1.Items.Add($"{title} - {url}");
                }
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string selected = listBox1.SelectedItem.ToString();
            if (!selected.Contains("watch?v=")) return;

            string videoId = selected.Split(new string[] { "watch?v=" }, StringSplitOptions.None)[1];

            // ✅ Yerel bir HTML dosyası oluşturup YouTube player'ı oraya gömüyoruz
            string htmlPath = Path.Combine(Application.StartupPath, "player.html");

            string htmlContent = $@"
<!DOCTYPE html>
<html>
<head>
<meta charset='UTF-8'>
<meta http-equiv='X-UA-Compatible' content='IE=edge'>
<style>
html, body {{ margin:0; padding:0; background-color:black; height:100%; }}
iframe {{ width:100%; height:100%; border:none; }}
</style>
</head>
<body>
<iframe 
    src='https://www.youtube.com/embed/{videoId}?autoplay=1&rel=0'
    title='YouTube video player'
    allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; fullscreen'
    allowfullscreen>
</iframe>
</body>
</html>";

            File.WriteAllText(htmlPath, htmlContent, System.Text.Encoding.UTF8);
            webView.Source = new Uri(htmlPath);
        }
    }
}
