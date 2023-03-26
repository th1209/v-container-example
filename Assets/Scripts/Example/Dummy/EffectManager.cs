using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Example.Dummy
{
    public class EffectManager : MonoBehaviour, IEffectManager
    {
        public async UniTask<IEffectHandle> RentAsync(string effectFilePath)
        {
            UnityEngine.Debug.Log($"{nameof(RentAsync)} effectFilePath:{effectFilePath}");
            throw new NotImplementedException($"{nameof(RentAsync)} effectFilePath:{effectFilePath}");
            return new EffectHandle();
        }

        public void Return(IEffectHandle effectHandle)
        {
            UnityEngine.Debug.Log($"{nameof(Return)}");
        }

        private void OnDestroy()
        {
            UnityEngine.Debug.Log($"{nameof(EffectManager)} OnDestroy");
        }
    }
}