namespace QFrameworkDesign
{
    public class GameModel : Singleton<GameModel>
    {
        private GameModel() {}
        public BindableProperty<int> Count = new(){ Value = 0 };
        public BindableProperty<int> Score = new(){ Value = 0 };
    }
}

