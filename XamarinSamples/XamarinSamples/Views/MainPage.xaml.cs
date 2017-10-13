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

        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ContentPage;
            if (item == null)
                return;

            Navigation.PushAsync((ContentPage)e.SelectedItem);

            (sender as ListView).SelectedItem = null;
        }
    }
}
