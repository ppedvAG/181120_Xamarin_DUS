using Navigation.MD;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Navigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Einstiegspunkt
            // MainPage = new MainPage();
            // MainPage = new NavigationPage(new MainPage());
            // MainPage = new TabbedPageDemo();
            MainPage = new MDPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
