namespace QFrameworkDemo
{
    using UnityEngine;
    using UnityEditor;
    using QFramework;
    public class EditorCounterApp : EditorWindow, IController
    {
        public ICounterModel model;
    
        [MenuItem("QFramework/CounterApp")]
        private static void Open() {
            var window = GetWindow<EditorCounterApp>();
            window.titleContent = new GUIContent("CounterApp");
            window.Show();
        }

        private void OnEnable() {
            model = this.GetModel<ICounterModel>();
        }

        private void OnDisable() {
            model = null;
        }

        public IArchitecture GetArchitecture()
        {
            return CounterApp.Interface;
        }
    
        private void OnGUI() {
            if (GUILayout.Button("+"))
            {
                this.SendCommand<IncreaseCountCommand>();
            }
            GUILayout.Label(model.Count.Value.ToString());
            if (GUILayout.Button("-"))
            {
                this.SendCommand<DecreaseCountCommand>();
            }
        }
    }
}
