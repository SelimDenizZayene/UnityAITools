using System;
using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    public abstract class BehaviourTree : MonoBehaviour
    {
        public Node root;
        public BlackBoard blackBoard = new();

        #region Constructors

        public BehaviourTree() { }

        public BehaviourTree(Node root)
        {
            root.tree = this;
            this.root = root;
        }

        public BehaviourTree(Node root, BlackBoard blackBoard)
        {
            root.tree = this;
            this.root = root;
            this.blackBoard = blackBoard;
        }

        #endregion

        public void Start()
        {
            InitTree();
        }
        public void Update()
        {
            if (root != null)
            {
                root.Evaluate();
            }
        }

        public virtual void InitTree() { }
    }
}