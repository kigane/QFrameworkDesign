namespace QFrameworkDesign
{
    public struct KillEnemyCommand : ICommand
    {
        public void OnExecute()
        {
            GameModel.Instance.Count.Value++;

            if (GameModel.Instance.Count.Value == 9)
            {
                GamePassEvent.Trigger();
            }
        }
    }
}