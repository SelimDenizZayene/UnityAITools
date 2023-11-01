using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    public class Selector : Node
    {
        public Selector(BehaviourTree tree) : base(tree) { }
        public Selector(Node parent) : base(parent) { }
        public Selector(BehaviourTree tree, List<Node> children) : base(tree, children) { }
    }
}