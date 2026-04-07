using Microsoft.Web.WebView2.WinForms;
using System;
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

            // Caminho físico para a pasta do projeto
            string projectDir = AppDomain.CurrentDomain.BaseDirectory;

            // Registra a pasta virtual "app" para acessar arquivos locais
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping(
                "app.local",           // host virtual
                projectDir,            // pasta física
                Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind.Allow
            );

            // Agora podemos navegar usando URL virtual
            string url = "https://app.local/index.html";
            webView.CoreWebView2.Navigate(url);
        }
    }
}