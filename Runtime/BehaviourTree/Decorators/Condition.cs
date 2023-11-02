namespace Zayene.UnityAITools.BehaviourTree
{
    public class Condition : Decorator
    {
        private string condKey;
        public Condition(string condKey) : base() { this.condKey = condKey; }
        public Condition(BehaviourTree tree, string condKey) : base(tree) { this.condKey = condKey; }

        public override NodeState Evaluate()
        {
            if(tree.blackBoard.GetEntry(condKey) == null)
            {
                state = NodeState.Failure;
                return state;
            }
            if ((bool)tree.blackBoard.GetEntry(condKey))
            {
                state = child.Evaluate();
                return state;
            }
            else
            {
                state = NodeState.Failure;
                return state;
            }
        }
    }
}