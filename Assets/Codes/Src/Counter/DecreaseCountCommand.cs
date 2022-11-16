using QFramework;

namespace QFrameworkDemo
{
    class DecreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<ICounterModel>().Count.Value--;
            this.SendEvent<CountChangedEvent>();
        }
    }
}