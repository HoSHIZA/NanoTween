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