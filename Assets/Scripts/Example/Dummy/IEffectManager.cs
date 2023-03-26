using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Example.Dummy
{
    // 例) エフェクト管理みたいなインタフェース
    public interface IEffectManager
    {
        UniTask<IEffectHandle> RentAsync(string effectFilePath);

        void Return(IEffectHandle effectHandle);
    }

    // 例) エフェクトを表すハンドル
    public interface IEffectHandle
    {
        // 再生
        void Play();
        // 停止
        void Stop();
        // 一時停止
        void Pause();
        // 再開
        void Resume();
    }
    
    public class EffectHandle : IEffectHandle
    {
        public void Play() => throw new NotImplementedException($"{nameof(Play)}");
        public void Stop() => throw new NotImplementedException($"{nameof(Stop)}");
        public void Pause() => throw new NotImplementedException($"{nameof(Pause)}");
        public void Resume() => throw new NotImplementedException($"{nameof(Resume)}");
    }
}