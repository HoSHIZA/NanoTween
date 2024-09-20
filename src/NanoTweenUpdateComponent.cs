using UnityEngine;

namespace NanoTweenRootNamespace
{
    [AddComponentMenu("")]
    public sealed class NanoTweenUpdateComponent : MonoBehaviour
    {
        private static NanoTweenUpdateComponent _instance;
        
        public static NanoTweenUpdateComponent GetOrCreate()
        {
            if (_instance) return _instance;
            
            var go = new GameObject("NanoTween Update")
            {
                hideFlags = HideFlags.HideAndDontSave
            };
            
            DontDestroyOnLoad(go);
            
            _instance = go.AddComponent<NanoTweenUpdateComponent>();
            
            return _instance;
        }
    }
}