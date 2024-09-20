using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<int> CreateTween(int from, int to, float duration)
        {
            return NanoTweenBuilder<int>.Create(from, to, duration, LerpFunction.Int);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<int> CreateTween(int to, float duration)
        {
            return NanoTweenBuilder<int>.Create(default, to, duration, LerpFunction.Int);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<int> CreateTween(this MonoBehaviour owner, int from, int to, float duration)
        {
            return NanoTweenBuilder<int>.Create(owner, from, to, duration, LerpFunction.Int);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<int> CreateTween(this MonoBehaviour owner, int to, float duration)
        {
            return NanoTweenBuilder<int>.Create(owner, default, to, duration, LerpFunction.Int);
        }
    }
}