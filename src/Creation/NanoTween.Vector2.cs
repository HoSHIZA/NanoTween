using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTween(Vector2 from, Vector2 to, float duration)
        {
            return NanoTweenBuilder<Vector2>.Create(from, to, duration, LerpFunction.Vector2);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTween(Vector2 to, float duration)
        {
            return NanoTweenBuilder<Vector2>.Create(default, to, duration, LerpFunction.Vector2);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTween(this MonoBehaviour owner, Vector2 from, Vector2 to, float duration)
        {
            return NanoTweenBuilder<Vector2>.Create(owner, from, to, duration, LerpFunction.Vector2);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTween(this MonoBehaviour owner, Vector2 to, float duration)
        {
            return NanoTweenBuilder<Vector2>.Create(owner, default, to, duration, LerpFunction.Vector2);
        }
    }
}