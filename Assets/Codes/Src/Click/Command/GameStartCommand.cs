namespace QFrameworkDesign
{
    public struct GameStartCommand : ICommand
    {
        public void OnExecute()
        {
            GameStartEvent.Trigger();
        }
    }
}