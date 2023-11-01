using System.Collections.Generic;

namespace Zayene.UnityAITools.BehaviourTree
{
    public class Selector : Node
    {
        public Selector(BehaviourTree tree) : base(tree) { }
        public Selector(Node parent) : base(parent) { }
        public Selector(BehaviourTree tree, List<Node> children) : base(tree, children) { }

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