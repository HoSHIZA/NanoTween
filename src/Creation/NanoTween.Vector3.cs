using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(Vector3 from, Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(from, to, duration, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(default, to, duration, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(this MonoBehaviour owner, Vector3 from, Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(owner, from, to, duration, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(this MonoBehaviour owner, Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(owner, default, to, duration, LerpFunction.Vector3);
        }
    }
}