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
    internal static partial class NanoTween
    {
        [MethodImpl(256)]
        public static NanoTweenBuilder<Single> CreateTween(Single from, Single to, float duration)
        {
            return NanoTweenBuilder<Single>.Create(from, to, duration, LerpFunction.Single);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Single> CreateTweenInf(Single from, Single to)
        {
            return NanoTweenBuilder<Single>.Create(from, to, 0f, LerpFunction.Single);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Single> CreateTween(Single to, float duration)
        {
            return NanoTweenBuilder<Single>.Create(default, to, duration, LerpFunction.Single);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Single> CreateTweenInf(Single to)
        {
            return NanoTweenBuilder<Single>.Create(default, to, 0f, LerpFunction.Single);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Single> CreateTween(this MonoBehaviour owner, Single from, Single to, float duration)
        {
            return NanoTweenBuilder<Single>.Create(owner, from, to, duration, LerpFunction.Single);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Single> CreateTween(this MonoBehaviour owner, Single to, float duration)
        {
            return NanoTweenBuilder<Single>.Create(owner, default, to, duration, LerpFunction.Single);
        }

        [MethodImpl(256)]
        public static NanoTweenBuilder<Int32> CreateTween(Int32 from, Int32 to, float duration)
        {
            return NanoTweenBuilder<Int32>.Create(from, to, duration, LerpFunction.Int32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Int32> CreateTweenInf(Int32 from, Int32 to)
        {
            return NanoTweenBuilder<Int32>.Create(from, to, 0f, LerpFunction.Int32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Int32> CreateTween(Int32 to, float duration)
        {
            return NanoTweenBuilder<Int32>.Create(default, to, duration, LerpFunction.Int32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Int32> CreateTweenInf(Int32 to)
        {
            return NanoTweenBuilder<Int32>.Create(default, to, 0f, LerpFunction.Int32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Int32> CreateTween(this MonoBehaviour owner, Int32 from, Int32 to, float duration)
        {
            return NanoTweenBuilder<Int32>.Create(owner, from, to, duration, LerpFunction.Int32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Int32> CreateTween(this MonoBehaviour owner, Int32 to, float duration)
        {
            return NanoTweenBuilder<Int32>.Create(owner, default, to, duration, LerpFunction.Int32);
        }

        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTween(Color from, Color to, float duration)
        {
            return NanoTweenBuilder<Color>.Create(from, to, duration, LerpFunction.Color);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTweenInf(Color from, Color to)
        {
            return NanoTweenBuilder<Color>.Create(from, to, 0f, LerpFunction.Color);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTween(Color to, float duration)
        {
            return NanoTweenBuilder<Color>.Create(default, to, duration, LerpFunction.Color);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color> CreateTweenInf(Color to)
        {
            return NanoTweenBuilder<Color>.Create(default, to, 0f, LerpFunction.Color);
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

        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTween(Color32 from, Color32 to, float duration)
        {
            return NanoTweenBuilder<Color32>.Create(from, to, duration, LerpFunction.Color32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTweenInf(Color32 from, Color32 to)
        {
            return NanoTweenBuilder<Color32>.Create(from, to, 0f, LerpFunction.Color32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTween(Color32 to, float duration)
        {
            return NanoTweenBuilder<Color32>.Create(default, to, duration, LerpFunction.Color32);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Color32> CreateTweenInf(Color32 to)
        {
            return NanoTweenBuilder<Color32>.Create(default, to, 0f, LerpFunction.Color32);
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

        [MethodImpl(256)]
        public static NanoTweenBuilder<String> CreateTween(String from, String to, float duration)
        {
            return NanoTweenBuilder<String>.Create(from, to, duration, LerpFunction.String);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<String> CreateTweenInf(String from, String to)
        {
            return NanoTweenBuilder<String>.Create(from, to, 0f, LerpFunction.String);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<String> CreateTween(String to, float duration)
        {
            return NanoTweenBuilder<String>.Create(default, to, duration, LerpFunction.String);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<String> CreateTweenInf(String to)
        {
            return NanoTweenBuilder<String>.Create(default, to, 0f, LerpFunction.String);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<String> CreateTween(this MonoBehaviour owner, String from, String to, float duration)
        {
            return NanoTweenBuilder<String>.Create(owner, from, to, duration, LerpFunction.String);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<String> CreateTween(this MonoBehaviour owner, String to, float duration)
        {
            return NanoTweenBuilder<String>.Create(owner, default, to, duration, LerpFunction.String);
        }

        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTween(Vector2 from, Vector2 to, float duration)
        {
            return NanoTweenBuilder<Vector2>.Create(from, to, duration, LerpFunction.Vector2);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTweenInf(Vector2 from, Vector2 to)
        {
            return NanoTweenBuilder<Vector2>.Create(from, to, 0f, LerpFunction.Vector2);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTween(Vector2 to, float duration)
        {
            return NanoTweenBuilder<Vector2>.Create(default, to, duration, LerpFunction.Vector2);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector2> CreateTweenInf(Vector2 to)
        {
            return NanoTweenBuilder<Vector2>.Create(default, to, 0f, LerpFunction.Vector2);
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

        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(Vector3 from, Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(from, to, duration, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTweenInf(Vector3 from, Vector3 to)
        {
            return NanoTweenBuilder<Vector3>.Create(from, to, 0f, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(default, to, duration, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTweenInf(Vector3 to)
        {
            return NanoTweenBuilder<Vector3>.Create(default, to, 0f, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(this MonoBehaviour owner, Vector3 from, Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(owner, from, to, duration, LerpFunction.Vector3);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector3> CreateTween(this MonoBehaviour owner, Vector3 to, float duration)
        {
            return NanoTweenBuilder<Vector3>.Create(owner, default, to, duration, LerpFunction.Vector3);
        }

        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(Vector4 from, Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(from, to, duration, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTweenInf(Vector4 from, Vector4 to)
        {
            return NanoTweenBuilder<Vector4>.Create(from, to, 0f, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(default, to, duration, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTweenInf(Vector4 to)
        {
            return NanoTweenBuilder<Vector4>.Create(default, to, 0f, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(this MonoBehaviour owner, Vector4 from, Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(owner, from, to, duration, LerpFunction.Vector4);
        }
        
        [MethodImpl(256)]
        public static NanoTweenBuilder<Vector4> CreateTween(this MonoBehaviour owner, Vector4 to, float duration)
        {
            return NanoTweenBuilder<Vector4>.Create(owner, default, to, duration, LerpFunction.Vector4);
        }

    }
}