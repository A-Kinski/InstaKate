using InstaSharp;
using InstaSharp.Endpoints;
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
      

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            
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

        private async void loginButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string username = "aceloina;";//loginTextBox.Text;
            string password = "hjvfyjdf";//passwordTextBox.Text;

            const string clientId = "eea65716bf9b4124bc7ba86d9ec5ff69";
            const string clientSecret = "8f48e4223d504497bb34870551aac4c3";
            const string redirectUri = "http://localhost/";

            var config = new InstagramConfig(clientId, clientSecret, redirectUri);
            var scopes = new List<OAuth.Scope>()
            {
                OAuth.Scope.Basic
            };

            var auth = Instagram.AuthByCredentials(username, password, config, scopes);

            var users = new Users(config, auth);
            var userFeed = await users.Feed(null, null, null).ConfigureAwait(false);
        }
    }
}
