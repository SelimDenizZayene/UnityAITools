using UnityEngine;

namespace Zayene.UnityAITools.BehaviourTree
{
    public abstract class BehaviourTree : MonoBehaviour
    {
        public Node root;
        public BlackBoard blackBoard;
    }
}