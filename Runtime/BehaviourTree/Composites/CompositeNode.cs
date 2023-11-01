using System.Collections.Generic;

namespace Zayene.UnityAITools.BehaviourTree
{
    public abstract class CompositeNode : Node
    {
        public List<Node> children = new();

        public CompositeNode() { }
        public CompositeNode(BehaviourTree tree) : base(tree) { }

        /// <summary>
        /// Attaches child to this node.
        /// </summary>
        public void AddChild(Node child)
        {
            child.parent = this;
            child.tree = this.tree;
            children.Add(child);
        }
    }
}