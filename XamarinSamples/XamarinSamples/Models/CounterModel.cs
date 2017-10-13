using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSamples.Helpers;

namespace XamarinSamples.Models
{
    public class CounterModel : ObservableObject
    {

        #region Static fields and properties.
        public static CounterModel StaticCounterModel { private set; get; } = new CounterModel();
        #endregion

        #region Instance fields and properties.
        int _counter;
        int _stepWidth;
        public int Counter
        {
            get => _counter;
            set => SetProperty(ref _counter, value);
        }
        public String CounterString
        {
            get => Counter.ToString();
        }
        public int CounterInvalid { private set; get; }
        public int StepWidth
        {
            get => _stepWidth;
            set => SetProperty(ref _stepWidth, value);
        }
        #endregion

        #region Instance methods.
        public CounterModel()
        {
            this.StepWidth = 1;
            this.ResetCounter();
        }
        public void ResetCounter()
        {
            this.Counter = 0;
            this.CounterInvalid = 0;
        }
        public void IncrementCounter()
        {
            this.Counter += this.StepWidth;
            this.CounterInvalid += StepWidth;
        }
        #endregion

    }
}
