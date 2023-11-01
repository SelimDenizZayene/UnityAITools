using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    [Serializable]
    public class BlackBoard
    {
        Dictionary<string, object> BBData = new Dictionary<string, object>();

        public BlackBoard() { }

        public void AddOrOverwriteEntry(string key, object value)
        {
            if (BBData.ContainsKey(key))
            {
                BBData[key] = value;
            }
            else
            {
                BBData.Add(key, value);
            }
        }

        public void RemoveEntry(string key)
        {
            if (!BBData.ContainsKey(key)) return;
            BBData.Remove(key);
        }

        public object GetEntry(string key)
        {
            if(BBData.ContainsKey(key))
            { 
                return BBData[key];
            }
            return null;
        }

    }
}