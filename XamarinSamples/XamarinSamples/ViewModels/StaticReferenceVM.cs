using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinSamples.Helpers;
using XamarinSamples.Models;

namespace XamarinSamples.ViewModels
{
    public class StaticReferenceVM : BaseVM
    {

        #region Instance constractors.
        public StaticReferenceVM()
        {
            IncrementStaticCounterCommand = new Command(async () => await ExecuteIncrementStaticCounterCommand());
            ResetStaticCounterCommand = new Command(async () => ExecuteResetStaticCounterCommand());
        }
        #endregion

        #region Instance commands.
        public Command IncrementStaticCounterCommand { get; set; }
        public Command ResetStaticCounterCommand { get; set; }
        #endregion

        #region Instance command definitions.
        async Task ExecuteResetStaticCounterCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var oldValue = StaticReferenceModel.StaticCounterModel.Counter;
                StaticReferenceModel.StaticCounterModel.ResetCounter();
                Debug.WriteLine(oldValue + " -> " + StaticReferenceModel.StaticCounterModel.Counter);
            }
            catch (Exception ex)
            {
                this.ExceptionHandler(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        async Task ExecuteIncrementStaticCounterCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var oldValue = StaticReferenceModel.StaticCounterModel.Counter;
                StaticReferenceModel.StaticCounterModel.IncrementCounter();
                Debug.WriteLine(oldValue + " -> " + StaticReferenceModel.StaticCounterModel.Counter);
            }
            catch (Exception ex)
            {
                this.ExceptionHandler(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        void ExceptionHandler(Exception ex)
        {
            this.ExceptionHandler(ex);
        }
        #endregion

    }
}
