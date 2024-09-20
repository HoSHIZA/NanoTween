using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<string> CreateTween(string from, string to, float duration)
        {
            return NanoTweenBuilder<string>.Create(from, to, duration, LerpFunction.String);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<string> CreateTween(string to, float duration)
        {
            return NanoTweenBuilder<string>.Create(default, to, duration, LerpFunction.String);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<string> CreateTween(this MonoBehaviour owner, string from, string to, float duration)
        {
            return NanoTweenBuilder<string>.Create(owner, from, to, duration, LerpFunction.String);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<string> CreateTween(this MonoBehaviour owner, string to, float duration)
        {
            return NanoTweenBuilder<string>.Create(owner, default, to, duration, LerpFunction.String);
        }
    }
}