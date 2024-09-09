using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using NanoTweenRootNamespace.Easing;
using Unity.Collections.LowLevel.Unsafe;

namespace NanoTweenRootNamespace
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    internal struct NanoTweenData<T>
    {
        public TweenState State;
        
        public NanoTweenDataCore Core;
        public NanoTweenCallbackData Callback;
        
        public T From;
        public T To;
        
        public Func<T, T, float, T> LerpFunction;
        
        [MethodImpl(256)]
        public T Lerp(float t)
        {
            return LerpFunction.Invoke(From, To, Core.Ease.Evaluate(t));
        }
        
        public static readonly NanoTweenData<T> Default = new()
        {
            Core = NanoTweenDataCore.Default,
            Callback = NanoTweenCallbackData.Default,
        };
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    internal struct NanoTweenDataCore
    {
        public TweenState State;

        public EaseWrapper Ease;
        
        public double Time;
        public float Duration;
        public float PlaybackSpeed;
        
        public TimeKind TimeKind;
        
        public DelayType DelayType;
        public DelayMode DelayMode;
        public float Delay;
        
        public LoopType LoopType;
        public bool AffectLoopsOnDuration;
        public int LoopCount;
        
        public static readonly NanoTweenDataCore Default = new()
        {
            Ease = EaseWrapper.Default,
            PlaybackSpeed = 1,
            AffectLoopsOnDuration = false,
            LoopCount = 1,
        };
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    internal struct NanoTweenCallbackData
    {
        public byte CallbackStates;
        public object State1;
        public object State2;
        public object State3;
        
        public object ValueUpdateAction;
        
        public object OnUpdateAction;
        public Action OnStartAction;
        public Action OnStartDelayedAction;
        public Action OnCancelAction;
        public Action OnCompleteAction;
        public Action OnPauseAction;
        public Action OnResumeAction;
        
        [MethodImpl(256)]
        public void InvokeValueUpdate<T>(in T value)
        {
            switch (CallbackStates)
            {
                case 0: UnsafeUtility.As<object, Action<T>>(ref ValueUpdateAction)?.Invoke(value); break;
                case 1: UnsafeUtility.As<object, Action<T, object>>(ref ValueUpdateAction)?.Invoke(value, State1); break;
                case 2: UnsafeUtility.As<object, Action<T, object, object>>(ref ValueUpdateAction)?.Invoke(value, State1, State2); break;
                case 3: UnsafeUtility.As<object, Action<T, object, object, object>>(ref ValueUpdateAction)?.Invoke(value, State1, State2, State3); break;
            }
            
            UnsafeUtility.As<object, Action<T>>(ref OnUpdateAction)?.Invoke(value);
        }
        
        [MethodImpl(256)]
        public void SubscribeToOnUpdateAction<T>(Action<T> callback)
        {
            UnsafeUtility.As<object, Action<T>>(ref OnUpdateAction) += callback;
        }
        
        public static readonly NanoTweenCallbackData Default = new()
        {
        };
    }

    [PublicAPI]
    public enum TweenState : byte
    {
        Idle,
        Scheduled,
        Delayed,
        Running,
        Completed,
        Canceled,
    }
    
    [PublicAPI]
    public enum LoopType : byte
    {
        Restart,
        Yoyo,
    }
    
    [PublicAPI]
    public enum DelayType : byte
    {
        FirstLoop,
        EveryLoop,
    }
    
    [PublicAPI]
    public enum DelayMode : byte
    {
        AffectOnDuration,
        SkipValuesDuringDelayed,
    }
}