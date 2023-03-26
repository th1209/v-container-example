using System;
using Example.Dummy;
using VContainer.Unity;

namespace Example._03_EntryPoint
{
    // Applicationの最初の初期化処理を表すクラス
    public class ApplicationEntryPoint : IStartable, IDisposable
    {
        // ※EntryPointに指定したクラスも､依存を注入して使うことが出来る
        private ILogger _logger;

        public ApplicationEntryPoint(ILogger logger)
        {
            _logger = logger;
            _logger.Log($"{nameof(ApplicationEntryPoint)} Constructor");
        }

        public void Start()
        {
            _logger.Log($"{nameof(ApplicationEntryPoint)} {nameof(Start)}");
        }

        public void Dispose()
        {
            _logger.Log($"{nameof(ApplicationEntryPoint)} {nameof(Dispose)}");
        }
    }
}