//  --------------------------------------------------------------------------------------
// MvvmSamples.ParameterBase.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

namespace MvvmSamples.Model
{
    public abstract class ParameterBase<T> : ParameterBase
    {
        public virtual T Value { get; set; }
    }

    public abstract class ParameterBase
    {
        // Marker
    }
}