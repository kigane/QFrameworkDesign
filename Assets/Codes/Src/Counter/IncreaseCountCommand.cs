using QFramework;

namespace QFrameworkDemo
{
    class IncreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<ICounterModel>().Count.Value++;
            this.SendEvent<CountChangedEvent>();
        }
    }
}