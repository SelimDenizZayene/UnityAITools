using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    [Serializable]
    public class BlackBoard
    {
        Dictionary<string, object> BBData = new Dictionary<string, object>();

        public event Action<string> onBBKeyUpdated;

        public BlackBoard() { }

        public void AddOrOverwriteEntry(string key, object value)
        {
            if (BBData.ContainsKey(key))
            {
                BBData[key] = value;
                onBBKeyUpdated?.Invoke(key);
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
            onBBKeyUpdated?.Invoke(key);
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