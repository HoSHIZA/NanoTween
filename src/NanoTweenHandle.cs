using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal struct NanoTweenHandle
    {
        public readonly MonoBehaviour Owner;
        public readonly Coroutine Routine;
        
        public NanoTweenHandle(MonoBehaviour owner, Coroutine routine)
        {
            Owner = owner;
            Routine = routine;
        }
    }
}