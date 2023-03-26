using System;

namespace Example.Dummy
{
    // 例) ロガーのラッパーみたいなインタフェース
    public interface ILogger
    {
        void Log(string message);
    }
}