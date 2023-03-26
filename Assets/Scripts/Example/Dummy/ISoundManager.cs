using System;
using Cysharp.Threading.Tasks;

namespace Example.Dummy
{
    // 例) サウンドリソース管理・再生みたいなインタフェース
    public interface ISoundManager
    {
        UniTask<ISoundPlayHandle> LoadSoundResourceAsync(string soundFilePath);

        void ReleaseSoundResource(string soundFilePath);
    }

    // 例) サウンドを表すハンドル
    public interface ISoundPlayHandle
    {
        void Play(string soundName);
    }
}