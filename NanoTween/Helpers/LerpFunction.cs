using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace NanoTweenRootNamespace.Helpers
{
    [SuppressMessage("ReSharper", "ConvertClosureToMethodGroup")]
    internal static class LerpFunction
    {
        public static readonly Func<float, float, float, float> Float = (from, to, t) => Mathf.LerpUnclamped(from, to, t);
        public static readonly Func<int, int, float, int> Int = (from, to, t) => Mathf.RoundToInt(Mathf.LerpUnclamped(from, to, t));
        
        public static readonly Func<Color, Color, float, Color> Color = (from, to, t) => UnityEngine.Color.LerpUnclamped(from, to, t);
        public static readonly Func<Color32, Color32, float, Color32> Color32 = (from, to, t) => UnityEngine.Color32.LerpUnclamped(from, to, t);
        
        public static readonly Func<Vector2, Vector2, float, Vector2> Vector2 = (from, to, t) => UnityEngine.Vector2.LerpUnclamped(from, to, t);
        public static readonly Func<Vector3, Vector3, float, Vector3> Vector3 = (from, to, t) => UnityEngine.Vector3.LerpUnclamped(from, to, t);
        public static readonly Func<Vector4, Vector4, float, Vector4> Vector4 = (from, to, t) => UnityEngine.Vector4.LerpUnclamped(from, to, t);
        
        public static readonly Func<Quaternion, Quaternion, float, Quaternion> Quaternion = (from, to, t) => UnityEngine.Quaternion.LerpUnclamped(from, to, t);
        
        public static readonly Func<string, string, float, string> String = (from, to, t) =>
        {
            var resultLength = Mathf.Max(from.Length, to.Length);
            var currentTextLength = Mathf.RoundToInt(resultLength * t);
            
            var result = new StringBuilder(resultLength);
            
            for (var i = 0; i < resultLength; i++)
            {
                if (i < currentTextLength)
                {
                    if (i < to.Length)
                    {
                        result.Append(to[i]);
                    }
                }
                else
                {
                    if (i < from.Length)
                    {
                        result.Append(from[i]);
                    }
                }
            }

            return result.ToString();
        };
    }
}