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
    public class BindingVM : BaseVM
    {

        #region Instance fields and properties.
        public BindingModel StaticBindingModel { private set; get; } = BindingModel.StaticBindingModel;
        public BindingModel StaticBindingModelAnother { private set; get; } = BindingModel.StaticBindingModel;
        public BindingModel BindingModel { private set; get; } = new BindingModel(); // BindingContextの対象はプロパティでなければならない。
        #endregion

        #region Instance constructors.
        public BindingVM()
        {
            IncrementStaticCounterCommand = new Command(async () => await ExecuteIncrementStaticCounterCommand());
            ResetStaticCounterCommand = new Command(async () => ExecuteResetStaticCounterCommand());
            IncrementCounterCommand = new Command(async () => await ExecuteIncrementCounterCommand());
            ResetCounterCommand = new Command(async () => await ExecuteResetCounterCommand());
        }
        #endregion

        #region Instance commands.
        public Command IncrementStaticCounterCommand { get; set; }
        public Command ResetStaticCounterCommand { get; set; }
        public Command IncrementCounterCommand { get; set; }
        public Command ResetCounterCommand { get; set; }
        #endregion

        #region Instance command definitions
        async Task ExecuteResetStaticCounterCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                this.StaticBindingModel.CounterModel.ResetCounter();
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
                this.StaticBindingModel.CounterModel.IncrementCounter();
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
        async Task ExecuteResetCounterCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                this.BindingModel.CounterModel.ResetCounter();
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
        async Task ExecuteIncrementCounterCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                this.BindingModel.CounterModel.IncrementCounter();
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
