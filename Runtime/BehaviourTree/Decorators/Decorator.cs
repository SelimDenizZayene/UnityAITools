using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    public abstract class Decorator : Node
    {
        public Node child;

        public Decorator() : base() { }
        public Decorator(BehaviourTree tree) : base(tree) { }

        /// <summary>
        /// Attaches child to this node.
        /// </summary>
        public void AddChild(Node child)
        {
            child.parent = this;
            child.tree = this.tree;
            this.child = child;
        }
    }
}