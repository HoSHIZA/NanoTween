using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTween(Color32 from, Color32 to, float duration)
        {
            return NanoTweenBuilder<Color32>.Create(from, to, duration, LerpFunction.Color32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTween(Color32 to, float duration)
        {
            return NanoTweenBuilder<Color32>.Create(default, to, duration, LerpFunction.Color32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTween(this MonoBehaviour owner, Color32 from, Color32 to, float duration)
        {
            return NanoTweenBuilder<Color32>.Create(owner, from, to, duration, LerpFunction.Color32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTween(this MonoBehaviour owner, Color32 to, float duration)
        {
            return NanoTweenBuilder<Color32>.Create(owner, default, to, duration, LerpFunction.Color32);
        }
    }
}