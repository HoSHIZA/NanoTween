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
using UnityEngine;
using Object = UnityEngine.Object;

namespace NanoTweenRootNamespace.Extensions
{
    internal static class NanoTweenBuilderExtensions
    {
        /// <summary>
        /// Outputs the current value every update using <c>Debug.Log</c>.
        /// </summary>
        public static NanoTweenBuilder<T> WithUnityLogger<T>(this NanoTweenBuilder<T> builder, 
            LogType logType = LogType.Log, Object context = null)
        {
            return builder.OnUpdate(v =>
            {
                var message = v.ToString();
                
                switch (logType)
                {
                    case LogType.Log:        Debug.Log(message, context); break;
                    case LogType.Warning:    Debug.LogWarning(message, context); break;
                    case LogType.Assert:     Debug.LogAssertion(message, context); break;
                    case LogType.Exception:
                    case LogType.Error:      Debug.LogError(message, context); break;
                }
            });
        }

        /// <summary>
        /// Outputs a message every update using <c>Debug.Log</c>.
        /// </summary>
        public static NanoTweenBuilder<T> WithUnityLogger<T>(this NanoTweenBuilder<T> builder, 
            Func<T, string> message, LogType logType = LogType.Log, Object context = null)
        {
            return builder.OnUpdate(v =>
            {
                var messageText = message.Invoke(v);
                
                switch (logType)
                {
                    case LogType.Log:        Debug.Log(messageText, context); break;
                    case LogType.Warning:    Debug.LogWarning(messageText, context); break;
                    case LogType.Assert:     Debug.LogAssertion(messageText, context); break;
                    case LogType.Exception:
                    case LogType.Error:      Debug.LogError(messageText, context); break;
                }
            });
        }

        /// <summary>
        /// Enables forced repaint of the editor on every update.
        /// </summary>
        public static NanoTweenBuilder<T> WithForceEditorRepaint<T>(this NanoTweenBuilder<T> builder)
        {
#if UNITY_EDITOR
            return builder.OnUpdate(v =>
            {
                UnityEditor.EditorApplication.QueuePlayerLoopUpdate();
                UnityEditorInternal.InternalEditorUtility.RepaintAllViews();
            });
#endif
        }
    }
}