using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(Vector4 from, Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(from, to, duration, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(default, to, duration, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(this MonoBehaviour owner, Vector4 from, Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(owner, from, to, duration, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(this MonoBehaviour owner, Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(owner, default, to, duration, LerpFunction.Vector4);
        }
    }
}