using System;
using Cysharp.Threading.Tasks;

namespace Example.Dummy
{
    public class SoundManager : ISoundManager, IDisposable
    {
        private readonly ILogger _logger;

        public SoundManager(ILogger logger)
        {
            _logger = logger;
            UnityEngine.Debug.Log($"{nameof(SoundManager)} Constructor");
        }

        public async UniTask<ISoundPlayHandle> LoadSoundResourceAsync(string soundFilePath)
        {
            _logger.Log($"{nameof(LoadSoundResourceAsync)} soundFilePath:{soundFilePath}");
            return new DummySoundPlayHandle();
        }

        public void ReleaseSoundResource(string soundFilePath)
        {
            _logger.Log($"{nameof(ReleaseSoundResource)} soundFilePath:{soundFilePath}");
        }

        public void Dispose()
        {
            UnityEngine.Debug.Log($"{nameof(SoundManager)} Dispose");
        }
    }

    public class DummySoundPlayHandle : ISoundPlayHandle
    {
        public void Play(string soundName)
            => throw new NotImplementedException($"{nameof(Play)} soundName:{soundName}");
    }
}