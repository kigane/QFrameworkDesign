using QFramework;
using UnityEngine;

namespace QFrameworkDemo
{
    public interface ICounterModel : IModel
    {
        public BindableProperty<int> Count {get;}
    }

    public class CounterModel : AbstractModel, ICounterModel
    {
        // private int mCount = 0;
        private IStorage mStorage;

        public BindableProperty<int> Count {get;} = new(0);

        // public int Count
        // {
        //     get => mCount;
        //     set 
        //     {
        //         if (mCount != value)
        //         {
        //             mCount = value;
        //             mStorage.SaveInt(nameof(Count), mCount);
        //         }
        //     }
        // }

        protected override void OnInit()
        {
            mStorage = this.GetUtility<IStorage>();
            Count.Value = mStorage.LoadInt(nameof(Count));
            // 监听OnValueChange事件
            Count.RegisterWithInitValue(newVal => {
                mStorage.SaveInt(nameof(Count), newVal);
            });
        }
    }
}