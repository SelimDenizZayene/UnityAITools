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

        /// <summary>
        /// Adds a new key value pair or updates an existing one
        /// </summary>
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

        /// <summary>
        /// Updates a key with a new value if it exists
        /// </summary>
        public void UpdateEntry(string key, object value)
        {
            if (!BBData.ContainsKey(key)) return;

            BBData[(key)] = value;
            OnBBKeyUpdated?.Invoke(key);
        }

        /// <summary>
        /// Removes a key value pair from the BBData
        /// </summary>
        public void RemoveEntry(string key)
        {
            if (!BBData.ContainsKey(key)) return;

            BBData.Remove(key);
        }

        /// <summary>
        /// Finds and returns the object associated with the key, returns null if none exists
        /// </summary>
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