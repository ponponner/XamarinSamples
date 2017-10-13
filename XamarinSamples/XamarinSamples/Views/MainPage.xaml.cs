using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinSamples.Views
{
    public partial class MainPage : ContentPage
    {
        public readonly List<ContentPage> SamplePages;

        public MainPage()
        {
            InitializeComponent();

            Title = "Xamarin Samples";

            BindingContext = this.SamplePages = new List<ContentPage>()
            {
                new ReferenceStaticPage(),
                new BindingPage()
            };
        }

        private void OnSamplePageSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync((ContentPage)e.SelectedItem);
        }
    }
}
