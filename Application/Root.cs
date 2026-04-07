using Microsoft.Web.WebView2.WinForms;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using GameLib;

namespace Application
{
    public class Root : Form
    {
        private WebView2 webView;

        public Root()
        {
            this.Text = "Jogo das Canastras";
            this.Width = 1000;
            this.Height = 600;

            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(webView);

            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.AddHostObjectToScript("game", new Core());

            string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "index.html");

            if (File.Exists(htmlPath))
                webView.CoreWebView2.Navigate(htmlPath);
            else
                webView.NavigateToString("<h1>HTML NÃO ENCONTRADO</h1>");
        }

        private void InitializeComponent()
        {

        }
    }
}