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