using QFramework;
using UnityEngine;

namespace QFrameworkDemo
{
    public interface IAchievementSystem : ISystem {}

    public class AchievementSystem : AbstractSystem, IAchievementSystem
    {
        protected override void OnInit()
        {
            var model = this.GetModel<ICounterModel>();

            this.RegisterEvent<CountChangedEvent>(e => {
                if (model.Count == 10)
                {
                    Debug.Log("点击菜鸟 成就达成");
                }
                else if (model.Count == 20)
                {
                    Debug.Log("点击达人 成就达成");
                }
                else if (model.Count == -5)
                {
                     Debug.Log("你可真会点啊 成就达成");
                }
            });
        }
    }
}
