using System;
using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    /// <summary>
    /// Halts the Behaviour Tree at this node for waitDuration
    /// </summary>
    public class WaitTask : Node
    {
        public float waitDuration;
        private float timer = 0f;

        public WaitTask(float waitDuration)
        {
            this.waitDuration = waitDuration;
        }

        public override NodeState Evaluate()
        {
            if (waitDuration <= 0)
            {
                timer = 0f;
                state = NodeState.Success;
                return state;
            }

            if(timer < waitDuration)
            {
                timer += Time.deltaTime;
                state = NodeState.Active;
                return state;
            }

            timer = 0f;
            state = NodeState.Success;
            return state;
        }
    }
}