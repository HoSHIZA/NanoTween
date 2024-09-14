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
using System.Runtime.CompilerServices;
using NanoTweenRootNamespace.Helpers;
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<T> CreateTween<T>(this MonoBehaviour owner, T from, T to, float duration, Func<T, T, float, T> lerp)
        {
            return NanoTweenBuilder<T>.Create(owner, from, to, duration, lerp);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<float> CreateTween(this MonoBehaviour owner, float from, float to, float duration)
        {
            return NanoTweenBuilder<float>.Create(owner, from, to, duration, LerpFunction.Float);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<int> CreateTween(this MonoBehaviour owner, int from, int to, float duration)
        {
            return NanoTweenBuilder<int>.Create(owner, from, to, duration, LerpFunction.Int);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTween(this MonoBehaviour owner, Color from, Color to, float duration)
        {
            return NanoTweenBuilder<Color>.Create(owner, from, to, duration, LerpFunction.Color);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTween(this MonoBehaviour owner, Color32 from, Color32 to, float duration)
        {
            return NanoTweenBuilder<Color32>.Create(owner, from, to, duration, LerpFunction.Color32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTween(this MonoBehaviour owner, Vector2 from, Vector2 to, float duration)
        {
            return NanoTweenBuilder<Vector2>.Create(owner, from, to, duration, LerpFunction.Vector2);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(this MonoBehaviour owner, Vector3 from, Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(owner, from, to, duration, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(this MonoBehaviour owner, Vector4 from, Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(owner, from, to, duration, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Quaternion> CreateTween(this MonoBehaviour owner, Quaternion from, Quaternion to, float duration)
        {
            return NanoTweenBuilder<Quaternion>.Create(owner, from, to, duration, LerpFunction.Quaternion);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<string> CreateTween(this MonoBehaviour owner, string from, string to, float duration)
        {
            return NanoTweenBuilder<string>.Create(owner, from, to, duration, LerpFunction.String);
        }
    }
}