using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    public class Node
    {
        public Node parent = null;
        public List<Node> children = null;

        public NodeState state;

        #region Constructors

        public Node() { }

        public Node(List<Node> children)
        {
            foreach (Node node in children)
            {
                AddChild(node);
            }

        }

        #endregion

        public void AddChild(Node child)
        {
            child.parent = this;
            children.Add(child);
        }

        public virtual NodeState GetState() => NodeState.Failure;
    }
}