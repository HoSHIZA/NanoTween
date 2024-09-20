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
using UnityEngine;

namespace NanoTweenRootNamespace
{
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<T> CreateTween<T>(T to, float duration, Func<T, T, float, T> lerp)
        {
            return NanoTweenBuilder<T>.Create(default, to, duration, lerp);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<T> CreateTween<T>(T from, T to, float duration, Func<T, T, float, T> lerp)
        {
            return NanoTweenBuilder<T>.Create(from, to, duration, lerp);
        }

        [MethodImpl(256)]
        public static NanoTweenBuilder<T> CreateTween<T>(this MonoBehaviour owner, T to, float duration, Func<T, T, float, T> lerp)
        {
            return NanoTweenBuilder<T>.Create(owner, default, to, duration, lerp);
        }

        [MethodImpl(256)]
        public static NanoTweenBuilder<T> CreateTween<T>(this MonoBehaviour owner, T from, T to, float duration, Func<T, T, float, T> lerp)
        {
            return NanoTweenBuilder<T>.Create(owner, from, to, duration, lerp);
        }
    }
}