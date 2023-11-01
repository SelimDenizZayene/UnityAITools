using System.Collections.Generic;

namespace Zayene.UnityAITools.BehaviourTree
{
    public class Selector : CompositeNode
    {
        public Selector() : base() { }
        public Selector(BehaviourTree tree) : base(tree) { }

        /// <summary>
        /// Selector Node, acts as a OR gate
        /// </summary>
        /// <returns>Returns Success when any child executes successfully</returns>
        public override NodeState Evaluate()
        {
            foreach (Node child in children)
            {
                switch (child.Evaluate()) 
                {
                    case NodeState.Failure:
                        continue;
                    case NodeState.Success:
                        state = NodeState.Success;
                        return state;
                    case NodeState.Active:
                        state = NodeState.Active;
                        return state;
                    default:
                        continue;
                }
            }

            state = NodeState.Failure;
            return state;
        }
    }
}