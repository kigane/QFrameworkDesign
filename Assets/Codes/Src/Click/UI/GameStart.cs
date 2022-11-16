using UnityEngine;
using UnityEngine.UI;

namespace QFrameworkDesign
{
    public class GameStart : MonoBehaviour
    {
        private void Awake() {
            transform.Find("StartBtn").gameObject.GetComponent<Button>().onClick.AddListener(()=>{
                gameObject.SetActive(false);
                new GameStartCommand().OnExecute();
            });
        }
    }
    
}
