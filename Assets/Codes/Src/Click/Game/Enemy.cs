using UnityEngine;

namespace QFrameworkDesign
{
    public class Enemy : MonoBehaviour
    {
        public GameObject gamePassPanel;

        private void OnMouseDown() {
            Destroy(gameObject);
            new KillEnemyCommand().OnExecute();
        }
    }
    
}
