using System;

namespace Zayene.UnityAITools.BehaviourTree
{
    [Serializable]
    public abstract class Node
    {
        public NodeState state;

        public BehaviourTree tree;
        public Node parent = null;

        #region Constructors

        public Node() { }

        public Node(BehaviourTree tree) 
        {
            this.tree = tree;
        }

        #endregion

        /// <summary>
        /// Runs every frame.
        /// </summary>
        /// <returns>the state of the Node</returns>
        public abstract NodeState Evaluate();
    }
}