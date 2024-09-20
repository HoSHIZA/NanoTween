using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTween(Color from, Color to, float duration)
        {
            return NanoTweenBuilder<Color>.Create(from, to, duration, LerpFunction.Color);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTween(Color to, float duration)
        {
            return NanoTweenBuilder<Color>.Create(default, to, duration, LerpFunction.Color);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTween(this MonoBehaviour owner, Color from, Color to, float duration)
        {
            return NanoTweenBuilder<Color>.Create(owner, from, to, duration, LerpFunction.Color);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTween(this MonoBehaviour owner, Color to, float duration)
        {
            return NanoTweenBuilder<Color>.Create(owner, default, to, duration, LerpFunction.Color);
        }
    }
}