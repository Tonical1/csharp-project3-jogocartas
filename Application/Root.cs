using Microsoft.Web.WebView2.WinForms;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Application
{
    public class Root : Form
    {
        private WebView2 webView;

        public Root()
        {
            this.Text = "Meu App WebView2";
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

            // Caminho para seu HTML
            string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "index.html");

            string exeFolder = AppDomain.CurrentDomain.BaseDirectory;
            Process.Start(new ProcessStartInfo()
            {
                FileName = exeFolder,
                UseShellExecute = true,
                Verb = "open"
            }); 

            if (File.Exists(htmlPath))
                webView.CoreWebView2.Navigate(htmlPath);
            else
                webView.NavigateToString("<h1>HTML NÃO ENCONTRADO</h1>");
        }
    }
}