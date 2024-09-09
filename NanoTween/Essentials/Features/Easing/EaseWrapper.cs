using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NanoTweenRootNamespace.Easing
{
    [Serializable]
    internal struct EaseWrapper
    {
        [SerializeField] private EaseType _easeType;
        [SerializeField] private EasePower _easePower;
        [SerializeField] private AnimationCurve _curve;
        
        private readonly Func<float, float> _function;
        
        public EaseWrapper(Ease ease, AnimationCurve curve = null) : this()
        {
            _easeType = EaseUtility.GetEaseType(ease);
            _easePower = EaseUtility.GetEasePower(ease);
            _curve = curve;

            if (_easeType == EaseType.Custom && _curve == null)
            {
                _function = EaseUtility.GetFunction(ease);
            }
        }
        
        public EaseWrapper(Func<float, float> func) : this()
        {
            _easeType = EaseType.Custom;
            _function = func;
        }
        
        public EaseWrapper(AnimationCurve curve) : this()
        {
            _easeType = EaseType.Custom;
            _curve = curve;
        }
        
        [MethodImpl(256)]
        public float Evaluate(float t)
        {
            if (_easeType == EaseType.Custom)
            {
                return _function?.Invoke(t) ?? (_curve?.Evaluate(t) ?? EaseFunction.Linear(t));
            }
            
            if (_easePower == EasePower.Linear)
            {
                return EaseUtility.Evaluate(t, Ease.Linear);
            }
            
            return EaseUtility.Evaluate(t, _easeType, _easePower);
        }
        
        public static implicit operator EaseWrapper(Ease ease)
        {
            return new EaseWrapper(ease);
        }
        
        public static implicit operator EaseWrapper(Func<float, float> func)
        {
            return new EaseWrapper(func);
        }
        
        public static implicit operator EaseWrapper(AnimationCurve curve)
        {
            return new EaseWrapper(curve);
        }

        public static EaseWrapper Default = new(Ease.Linear);
    }
}