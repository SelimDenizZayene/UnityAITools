using System.Collections.Generic;

namespace Zayene.UnityAITools.BehaviourTree
{
    public class Sequence : Node
    {
        public Sequence(BehaviourTree tree) : base(tree) { }
        public Sequence(Node parent) : base(parent) { }
        public Sequence(BehaviourTree tree, List<Node> children) : base(tree, children) { }

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