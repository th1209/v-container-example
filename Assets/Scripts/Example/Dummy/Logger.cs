using System;

namespace Example.Dummy
{
    public class Logger : ILogger, IDisposable
    {
        public Logger()
        {
            UnityEngine.Debug.Log($"{nameof(Logger)} Constructor");
        }

        public void Log(string message)
            => UnityEngine.Debug.Log(message);

        public void Dispose()
        {
            UnityEngine.Debug.Log($"{nameof(Logger)} Dispose");
        }
    }
}