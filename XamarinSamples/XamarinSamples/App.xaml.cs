using XamarinSamples.Preset.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using XamarinSamples.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinSamples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
