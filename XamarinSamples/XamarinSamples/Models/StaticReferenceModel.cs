using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinSamples.Helpers;

namespace XamarinSamples.Models
{
    public class StaticReferenceModel : ObservableObject
    {
        public class StringableDouble
        {
            public double Value { private set; get; } = 0;
            public override string ToString() => Value.ToString();
            public StringableDouble(double value)
            {
                Value = value;
            }
        }

        public class NamedColor
        {
            public static readonly List<NamedColor> All;
            static NamedColor()
            {
                All = new List<NamedColor>()
                {
                    new NamedColor("Red", Color.FromRgb(255, 0, 0)),
                    new NamedColor("Yellow", Color.FromRgb(255, 255, 0)),
                    new NamedColor("Green", Color.FromRgb(0, 255, 0)),
                    new NamedColor("Cyan", Color.FromRgb(0, 255, 255)),
                    new NamedColor("Blue", Color.FromRgb(0, 0, 255))
                };
            }
            public string Name { private set; get; }
            public Color Color { private set; get; }
            private NamedColor(string name, Color color)
            {
                Name = name;
                Color = color;
            }
        }

        #region Static fields and properties.
        //  # XAMLのstatic参照について(e.g. Text={x:Static local:Sometype.StaticMember})
        //      ・まず、static参照はBindingでない点に留意すること。
        //      ・XAMLにおける書式は異なるし、値の変更がBindingターゲットに反映されることはない。
        //      ・参照対象のメンバは、フィールドでもプロパティでもよい。
        //      ・参照対象の型を、参照元に合わせる必要がある。
        //          XAMLのBindingと共に利用することのあるStringFormatだが、static参照では利用できない。
        public static readonly string StaticField = "Static field's value.";
        public static string StaticProperty => "Static property's value.";
        public static readonly double StaticNum = 3.5;
        public static readonly StringableDouble StaticDouble = new StringableDouble(3.5);
        public static CounterModel StaticCounterModel { private set; get; } = new CounterModel();
        public static string CounterString => StaticCounterModel.Counter.ToString();
        public static List<NamedColor> All => NamedColor.All;
        #endregion

    }
}
