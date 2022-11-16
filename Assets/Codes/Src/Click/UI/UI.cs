using UnityEngine;

namespace QFrameworkDesign
{
    public class UI : MonoBehaviour
    {
        private void Awake() {
            GamePassEvent.Register(OnGamePass);
        }

        private void OnGamePass()
        {
            transform.Find("Canvas/GamePassPanel").gameObject.SetActive(true);
        }

        private void OnDestroy() {
            GamePassEvent.UnRegister(OnGamePass);
        }
    }
}
