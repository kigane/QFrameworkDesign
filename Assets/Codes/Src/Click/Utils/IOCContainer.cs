using System;
using System.Collections.Generic;

namespace QFrameworkDesign
{
    public class IOCContainer
    {
        private Dictionary<Type, object> mInstances = new();

        public void Register<T>(T instance)
        {
            var key = typeof(T);
            if (mInstances.ContainsKey(key))
            {
                mInstances[key] = instance;
            }
            else
            {
                mInstances.Add(key, instance);
            }
        }

        public T Get<T>() where T : class
        {
            var key = typeof(T);
            if (mInstances.TryGetValue(key, out var retObj))
            {
                return retObj as T; // 使用as必须有class约束或更严的类型约束
            }

            return null;
        }
    }
}