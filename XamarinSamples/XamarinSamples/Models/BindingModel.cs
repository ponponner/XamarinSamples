using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSamples.Helpers;

namespace XamarinSamples.Models
{
    public class BindingModel : ObservableObject
    {

        #region Static fields and properties.
        public static BindingModel StaticBindingModel { private set; get; } = new BindingModel();
        #endregion

        #region Instance fields and properties.
        public CounterModel CounterModel;
        #endregion

    }
}
