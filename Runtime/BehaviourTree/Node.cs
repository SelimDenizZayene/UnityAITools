using System;
using System.Collections.Generic;

namespace Zayene.UnityAITools.BehaviourTree
{
    [Serializable]
    public class Node
    {
        public NodeState state;

        public BehaviourTree tree;
        public Node parent = null;
        public List<Node> children = null;

        #region Constructors

        public Node(BehaviourTree tree) 
        {
            this.tree = tree;
        }

        public Node(Node parent) 
        {
            this.tree = parent.tree;
            this.parent = parent;
        }

        public Node(BehaviourTree tree, List<Node> children)
        {
            this.tree = tree;
            foreach (Node node in children)
            {
                AddChild(node);
            }
        }

        #endregion

        public void AddChild(Node child)
        {
            child.parent = this;
            child.tree = this.tree;
            children.Add(child);
        }

        public virtual NodeState Evaluate() => NodeState.Failure;
    }
}