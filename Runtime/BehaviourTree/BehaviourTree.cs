using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    public abstract class BehaviourTree : MonoBehaviour
    {
        public Node root;
        public BlackBoard blackBoard = new();

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

        public abstract void InitTree();
    }
}