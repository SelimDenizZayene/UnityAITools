using System;

namespace Zayene.UnityAITools.BehaviourTree
{
    /// <summary>
    /// if the condition is true evaluates child otherwise returns failure.
    /// </summary>
    public class Condition : Decorator
    {
        public string condKey;
        private bool condValue;
        public Condition(string condKey) : base() { this.condKey = condKey; }
        public Condition(BehaviourTree tree, string condKey) : base(tree) { this.condKey = condKey; }

        public override NodeState Evaluate()
        {
            try 
            {
                condValue = (bool)tree.blackBoard.GetEntry(condKey);
            } 
            catch(Exception e) 
            {
                throw e;
            }

            if (condValue)
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