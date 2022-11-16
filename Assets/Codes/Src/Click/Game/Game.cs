using UnityEngine;

namespace QFrameworkDesign
{
    public class Game : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameStartEvent.Register(OnGameStart);
        }

        private void OnGameStart()
        {
            transform.Find("Enemies").gameObject.SetActive(true);
        }

        // Update is called once per frame
        private void OnDestroy()
        {
            GameStartEvent.UnRegister(OnGameStart);
        }
    }
    
}
