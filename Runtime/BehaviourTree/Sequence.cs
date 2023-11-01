using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    public class Sequence : Node
    {
        public Sequence(BehaviourTree tree) : base(tree) { }
        public Sequence(Node parent) : base(parent) { }
        public Sequence(BehaviourTree tree, List<Node> children) : base(tree, children) { }
    }
}