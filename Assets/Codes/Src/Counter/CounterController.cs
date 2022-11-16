using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFrameworkDemo
{
    // Controller
    public class CounterController : MonoBehaviour, IController
    {
        // view 提供关键组件的引用
        public Button btnAdd;
        public Button btnSub;
        public Text countText;
        
        // model
        // private int count = 0;
        private ICounterModel mCounterModel;

        public IArchitecture GetArchitecture()
        {
            return CounterApp.Interface;
        }

        // Start is called before the first frame update
        void Start()
        {
            mCounterModel = this.GetModel<ICounterModel>();
            // 监听输入
            btnAdd.onClick.AddListener(() => {
                // 交互逻辑
                // mCounterModel.count++;
                this.SendCommand<IncreaseCountCommand>();

                // 表现逻辑
                // UpdateView();
            });

            btnSub.onClick.AddListener(() => {
                // mCounterModel.count--;
                this.SendCommand<DecreaseCountCommand>();
            });

            this.RegisterEvent<CountChangedEvent>(e => {
                UpdateView();
            }).UnRegisterWhenGameObjectDestroyed(gameObject);

            UpdateView();
        }

        private void UpdateView()
        {
            countText.text = mCounterModel.Count.ToString();
        }
    }
}
