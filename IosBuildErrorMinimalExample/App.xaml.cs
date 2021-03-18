using System;
using Microsoft.Extensions.Hosting;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IosBuildErrorMinimalExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var hosting = new HostBuilder();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
