namespace Zayene.UnityAITools.BehaviourTree
{
    public class Inverter : Decorator
    {
        public Inverter() : base() { }
        public Inverter(BehaviourTree tree) : base(tree) { }

        /// <summary>
        /// Inverts the child node state
        /// </summary>
        public override NodeState Evaluate()
        {
            NodeState _state = child.Evaluate();
            if (_state == NodeState.Success)
            {
                state = NodeState.Failure;
                return state;
            }
            if(_state == NodeState.Failure)
            {
                state = NodeState.Success;
                return state;
            }
            state = _state;
            return state;
        }
    }
}