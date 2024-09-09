using System;
using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<T> CreateTween<T>(this MonoBehaviour context, T from, T to, float duration, Func<T, T, float, T> lerp)
        {
            return NanoTweenBuilder<T>.Create(context, from, to, duration, lerp);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<float> CreateTween(this MonoBehaviour context, float from, float to, float duration)
        {
            return NanoTweenBuilder<float>.Create(context, from, to, duration, LerpFunction.Float);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<int> CreateTween(this MonoBehaviour context, int from, int to, float duration)
        {
            return NanoTweenBuilder<int>.Create(context, from, to, duration, LerpFunction.Int);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTween(this MonoBehaviour context, Color from, Color to, float duration)
        {
            return NanoTweenBuilder<Color>.Create(context, from, to, duration, LerpFunction.Color);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTween(this MonoBehaviour context, Color32 from, Color32 to, float duration)
        {
            return NanoTweenBuilder<Color32>.Create(context, from, to, duration, LerpFunction.Color32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTween(this MonoBehaviour context, Vector2 from, Vector2 to, float duration)
        {
            return NanoTweenBuilder<Vector2>.Create(context, from, to, duration, LerpFunction.Vector2);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(this MonoBehaviour context, Vector3 from, Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(context, from, to, duration, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(this MonoBehaviour context, Vector4 from, Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(context, from, to, duration, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Quaternion> CreateTween(this MonoBehaviour context, Quaternion from, Quaternion to, float duration)
        {
            return NanoTweenBuilder<Quaternion>.Create(context, from, to, duration, LerpFunction.Quaternion);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<string> CreateTween(this MonoBehaviour context, string from, string to, float duration)
        {
            return NanoTweenBuilder<string>.Create(context, from, to, duration, LerpFunction.String);
        }
    }
}