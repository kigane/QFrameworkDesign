using QFramework;
using UnityEngine;

namespace QFrameworkDemo
{
    public interface IStorage : IUtility 
    {
        void SaveInt(string key, int val);
        int LoadInt(string key);
    }

    public class Storage : IStorage
    {
        public void SaveInt(string key, int val)
        {
            PlayerPrefs.SetInt(key, val);
        }

        public int LoadInt(string key)
        {
            return PlayerPrefs.GetInt(key);
        }        
    }
}