using System;

namespace QFrameworkDesign
{
    public class BindableProperty<T> where T : IEquatable<T>
    {
        private T mValue;
        public Action<T> mOnValueChanged;

        public T Value {
            get => mValue;
            set {
                if (!value.Equals(mValue))
                {
                    mValue = value;
                    mOnValueChanged?.Invoke(value);
                }
            }
        }
    }
}
