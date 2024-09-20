//
//   A tweening system for asset embedding.
//
//   https://github.com/HoSHIZA/NanoTween
//   
//   Copyright (c) 2024 HoSHIZA
//   
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//   of this software and associated documentation files (the "Software"), to deal
//   in the Software without restriction, including without limitation the rights
//   to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//   copies of the Software, and to permit persons to whom the Software is
//   furnished to do so, subject to the following conditions:
//   
//   The above copyright notice and this permission notice shall be included in all
//   copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//   AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//   LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//   OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//   SOFTWARE.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using UnityEngine;

namespace NanoTweenRootNamespace.Helpers
{
    [SuppressMessage("ReSharper", "ConvertClosureToMethodGroup")]
    internal static class LerpFunction
    {
        public static readonly Func<float, float, float, float> Float = static (from, to, t) => Mathf.LerpUnclamped(from, to, t);
        public static readonly Func<int, int, float, int> Int = static (from, to, t) => Mathf.RoundToInt(Mathf.LerpUnclamped(from, to, t));
        
        public static readonly Func<Color, Color, float, Color> Color = static (from, to, t) => UnityEngine.Color.LerpUnclamped(from, to, t);
        public static readonly Func<Color32, Color32, float, Color32> Color32 = static (from, to, t) => UnityEngine.Color32.LerpUnclamped(from, to, t);
        
        public static readonly Func<Vector2, Vector2, float, Vector2> Vector2 = static (from, to, t) => UnityEngine.Vector2.LerpUnclamped(from, to, t);
        public static readonly Func<Vector3, Vector3, float, Vector3> Vector3 = static (from, to, t) => UnityEngine.Vector3.LerpUnclamped(from, to, t);
        public static readonly Func<Vector4, Vector4, float, Vector4> Vector4 = static (from, to, t) => UnityEngine.Vector4.LerpUnclamped(from, to, t);
        
        public static readonly Func<string, string, float, string> String = static (from, to, t) =>
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