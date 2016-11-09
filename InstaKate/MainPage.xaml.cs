using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;
using Windows.Web.Http.Filters;

// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=391641

namespace InstaKate
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const string USER_AGENT =
"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_3) " +
"AppleWebKit/537.36 (KHTML, like Gecko) " +
"Chrome/45.0.2414.0 Safari/537.36";
        const string clientId = "1234567890abcdef1234567890abcdef";
        const string redirectUri = "http://localhost/";
        string address = $"https://api.instagram.com/oauth/authorize/?client_id={clientId}&redirect_uri={redirectUri}&response_type=token";
        

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            webView.Navigate( new Uri(address));

            
        }


        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные события, описывающие, каким образом была достигнута эта страница.
        /// Этот параметр обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Подготовьте здесь страницу для отображения.

            // TODO: Если приложение содержит несколько страниц, обеспечьте
            // обработку нажатия аппаратной кнопки "Назад", выполнив регистрацию на
            // событие Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Если вы используете NavigationHelper, предоставляемый некоторыми шаблонами,
            // данное событие обрабатывается для вас.
        }

   

        private void webView_FrameNavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            var s = webView.InvokeScriptAsync("eval", new string[] { "document.cookie;" });
        }

        private void webView_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            //var s = webView.InvokeScriptAsync("eval", new string[] { "document.cookie;" });
            HttpBaseProtocolFilter baseFilter = new HttpBaseProtocolFilter();
            //foreach (HttpCookie cookie in baseFilter.CookieManager.GetCookies(new Uri(sender.Source.ToString())))
            //    {
            //    if (cookie.Name.Equals("access_token"))
            //    {
            //        string value = cookie.Value;
            //    }
            //}
            WebView webView1 = sender as WebView;
            string html = webView1.InvokeScript("eval", new string[] { "document.documentElement.outerHTML;" });
        }
    }
}
