using System;

namespace QFrameworkDesign
{
    // 因为需要每个事件都有独属的一份代码(独有的委托)，所以需要加泛型参数。
    // 通过继承共享代码，因此希望传入的泛型参数是Event的子类。(而非任意类型都行)
    public class Event<T> where T : Event<T>
    {
        public static Action mOnEvent;

        public static void Register(Action onEvent)
        {
            mOnEvent += onEvent;
        }
        
        public static void UnRegister(Action onEvent)
        {
            mOnEvent -= onEvent;
        }
        
        public static void Trigger()
        {
            mOnEvent?.Invoke();
        }
    }
    
}
