using System;
using VContainer;

namespace Example.Dummy
{
    public class AppManager : IDisposable
    {
        [Inject]
        private ILogger _logger;

        [Inject]
        private ISoundManager _soundManager;

        [Inject]
        private IEffectManager _effectManager;

        public AppManager()
        {
            UnityEngine.Debug.Log($"{nameof(AppManager)} Constructor");
        }

        public void Dump()
        {
            UnityEngine.Debug.Log($"{nameof(Dump)} \n" +
                                  $"    ILogger:{_logger != null} \n" +
                                  $"    ISoundManager:{_soundManager != null} \n" +
                                  $"    IEffectManager:{_effectManager != null}");
        }

        public void Dispose()
        {
            UnityEngine.Debug.Log($"{nameof(AppManager)} Dispose");
        }
    }
}