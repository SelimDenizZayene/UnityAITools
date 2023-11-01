using System;
using System.Collections.Generic;
using System.Linq;

namespace Zayene.UnityAITools.BehaviourTree
{
    [Serializable]
    public class BlackBoard
    {
        Dictionary<string, object> BBData = new Dictionary<string, object>();

        public event Action<string> OnBBKeyUpdated;

        public BlackBoard() { }

        public void AddOrOverwriteEntry(string key, object value)
        {
            if (BBData.ContainsKey(key))
            {
                BBData[key] = value;
                OnBBKeyUpdated?.Invoke(key);
            }
            else
            {
                BBData.Add(key, value);
            }
        }

        public void UpdateEntry(string key, object value)
        {
            if (!BBData.ContainsKey(key)) return;

            BBData[(key)] = value;
            OnBBKeyUpdated?.Invoke(key);
        }

        public void RemoveEntry(string key)
        {
            if (!BBData.ContainsKey(key)) return;

            BBData.Remove(key);
        }

        public object GetEntry(string key)
        {
            if (!BBData.ContainsKey(key)) return null;
            
            return BBData[key];
        }

        public List<string> GetKeys()
        {
            return BBData.Keys.ToList();
        }

        public Dictionary<string, object> GetBBData()
        {
            return BBData;
        }

    }
}