using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal struct NanoTweenHandle
    {
        public readonly MonoBehaviour Context;
        public readonly Coroutine Routine;
        
        public NanoTweenHandle(MonoBehaviour context, Coroutine routine)
        {
            Context = context;
            Routine = routine;
        }
    }
}