using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<float> CreateTween(float from, float to, float duration)
        {
            return NanoTweenBuilder<float>.Create(from, to, duration, LerpFunction.Float);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<float> CreateTween(float to, float duration)
        {
            return NanoTweenBuilder<float>.Create(default, to, duration, LerpFunction.Float);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<float> CreateTween(this MonoBehaviour owner, float from, float to, float duration)
        {
            return NanoTweenBuilder<float>.Create(owner, from, to, duration, LerpFunction.Float);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<float> CreateTween(this MonoBehaviour owner, float to, float duration)
        {
            return NanoTweenBuilder<float>.Create(owner, default, to, duration, LerpFunction.Float);
        }
    }
}