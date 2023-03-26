using Example._03_EntryPoint;
using VContainer;
using VContainer.Unity;
using ILogger = Example.Dummy.ILogger;
using Logger = Example.Dummy.Logger;

namespace Example._04_BuildCallbacks
{
    public class ApplicationLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // IContainerBuilderは､ビルド完了時コールバックを設定することができる.
            // EntryPoint処理の規模が小さいなら､これで代替するのもあり.
            builder.RegisterBuildCallback(objectResolver =>
            {
                UnityEngine.Debug.Log("OnBuildEndCallback");
            });
            // Build失敗時のコールバックを登録することもできる.
            builder.RegisterEntryPointExceptionHandler(exception =>
            {
                UnityEngine.Debug.LogError($"OnBuildException exception:{exception.GetType().Name} exceptionMessage:{exception.Message}");
            });

            builder.Register<ILogger, Logger>(Lifetime.Singleton);
        }
    }
}