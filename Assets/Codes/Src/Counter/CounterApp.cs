using QFramework;
using UnityEngine;

namespace QFrameworkDemo
{
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            // 向Architecture的IOCContainer的字典中注册并添加实例。
            this.RegisterSystem<IAchievementSystem>(new AchievementSystem());
            this.RegisterModel<ICounterModel>(new CounterModel());
            this.RegisterUtility<IStorage>(new Storage());
        }

        // 命令拦截
        protected override void ExecuteCommand(ICommand command)
        {
            Debug.Log($"Before {command.GetType().Name} execute");
            base.ExecuteCommand(command);
            Debug.Log($"After {command.GetType().Name} execute");
        }
    }

}