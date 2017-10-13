
using System;
using Xamarin.Forms;
using XamarinSamples.ViewModels;

namespace XamarinSamples.Views
{
    public partial class BindingPage : ContentPage
    {
        public BindingVM BindingVM { private set; get; }

        public BindingPage()
        {
            InitializeComponent();

            this.Title = nameof(BindingPage);

            BindingContext = BindingVM = new BindingVM();
        }

        #region Event handlers.
        private void OnClickResetStaticCounterButton(object sender, EventArgs e)
        {
            this.BindingVM.ResetStaticCounterCommand.Execute(e);
        }
        private void OnClickIncrementStaticCounterButton(object sender, EventArgs e)
        {
            this.BindingVM.IncrementStaticCounterCommand.Execute(e);
        }
        private void OnClickResetCounterButton(object sender, EventArgs e)
        {
            this.BindingVM.ResetCounterCommand.Execute(e);
        }
        private void OnClickIncrementCounterButton(object sender, EventArgs e)
        {
            this.BindingVM.IncrementCounterCommand.Execute(e);
        }
        #endregion

    }
}
