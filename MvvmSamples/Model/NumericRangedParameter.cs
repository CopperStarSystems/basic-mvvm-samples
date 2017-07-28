//  --------------------------------------------------------------------------------------
// MvvmSamples.NumericRangedParameter.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

namespace MvvmSamples.Model
{
    public class NumericRangedParameter : ParameterBase<int>
    {
        int value;

        public int MaxValue { get; set; }

        public int MinValue { get; set; }

        public override int Value
        {
            get => value;
            set
            {
                if (value > MaxValue)
                    value = MaxValue;
                if (value < MinValue)
                    value = MinValue;
                this.value = value;
            }
        }
    }
}