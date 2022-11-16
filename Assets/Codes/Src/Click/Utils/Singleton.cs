using System;
using System.Reflection;

namespace QFrameworkDesign
{
    public class Singleton<T> where T : Singleton<T>
    {
        private static T mInstance;

        public static T Instance {
            get 
            {
                if (mInstance == null)
                {
                    Type type = typeof(T);
                    ConstructorInfo[] ctors = type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
                    ConstructorInfo ctor = Array.Find(ctors, c => c.GetParameters().Length == 0);

                    if (ctor == null)
                    {
                        throw new Exception($"Non Public Constructor Not Found in {type.Name}");
                    }

                    mInstance = ctor.Invoke(null) as T;
                }

                return mInstance;
            }
        }
    }
}