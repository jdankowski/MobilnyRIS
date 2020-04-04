using MobilnyRIS.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MobilnyRIS
{
    public partial class App : Application
    {
      

        public App()
        {
            InitializeComponent();

            //MainPage = new MyContentPage2();
            //MainPage = new NavigationPage(new MyNavigationPage)();
            MainPage = new NavigationPage(new MyNavigationPage2)() { BarBackgroundColor=Color.GreenYellow, BarTextColor=Color.Red } ;
                                                                    // property? field? read-only?  
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
