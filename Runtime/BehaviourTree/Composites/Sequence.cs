using System.Collections.Generic;

namespace Zayene.UnityAITools.BehaviourTree
{
    public class Sequence : CompositeNode
    {
        public Sequence() : base() { }
        public Sequence(BehaviourTree tree) : base(tree) { }

        /// <summary>
        /// Sequence Node, acts as an And gate
        /// </summary>
        /// <returns>Returns Success when all children execute successfully in order</returns>
        public override NodeState Evaluate()
        {
            foreach (Node child in children)
            {
                switch (child.Evaluate())
                {
                    case NodeState.Failure:
                        state = NodeState.Failure;
                        return state;
                    case NodeState.Success:
                        continue;
                    case NodeState.Active:
                        state = NodeState.Active;
                        return state;
                    default:
                        continue;
                }
            }

            state = NodeState.Success;
            return state;
        }
    }
}