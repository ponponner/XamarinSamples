using XamarinSamples.Helpers;
using XamarinSamples.Models;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinSamples.ViewModels
{
    public class BaseVM : ObservableObject
    {

        #region Static fields and properties.
        private static readonly PropertyChangedEventArgs PropertyChangedEventArgsOfIsBusy = new PropertyChangedEventArgs(nameof(IsBusy));
        #endregion

        #region Instance fields and properties.
        bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }
        #endregion

    }
}

