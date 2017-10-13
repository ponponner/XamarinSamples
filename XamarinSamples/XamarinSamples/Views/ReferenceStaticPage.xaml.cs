using System;
using Xamarin.Forms;
using XamarinSamples.ViewModels;

namespace XamarinSamples.Views
{
    public partial class ReferenceStaticPage : ContentPage
    {

        public StaticReferenceVM StaticReferenceVM { private set; get; }

        public ReferenceStaticPage()
        {
            InitializeComponent();

            this.Title = "x:Static";

            BindingContext = StaticReferenceVM = new StaticReferenceVM();
        }

        #region Event handlers.
        private void OnClickIncrementStaticCounterButton(object sender, EventArgs e)
        {
            this.StaticReferenceVM.IncrementStaticCounterCommand.Execute(e);
        }
        private void OnClickResetStaticCounterButton(object sender, EventArgs e)
        {
            this.StaticReferenceVM.ResetStaticCounterCommand.Execute(e);
        }
        #endregion

    }
}
