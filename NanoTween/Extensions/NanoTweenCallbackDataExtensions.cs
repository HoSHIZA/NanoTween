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

using System.Runtime.CompilerServices;

namespace NanoTweenRootNamespace.Extensions
{
    internal static class NanoTweenCallbackDataExtensions
    {
        [MethodImpl(256)]
        public static void InvokeStart<T>(this NanoTweenCallbackData callbackData, ref NanoTweenData<T> data) 
        {
            callbackData.InvokeValueUpdate(data.Lerp(0f));
        }
        
        [MethodImpl(256)]
        public static void InvokeEnd<T>(this NanoTweenCallbackData callbackData, ref NanoTweenData<T> data)
        {
            callbackData.InvokeValueUpdate(data.Lerp(1f));
        }
        
        [MethodImpl(256)]
        public static void InvokeUpdate<T>(this NanoTweenCallbackData callbackData, ref NanoTweenData<T> data, float t)
        {
            callbackData.InvokeValueUpdate(data.Lerp(t));
        }
    }
}