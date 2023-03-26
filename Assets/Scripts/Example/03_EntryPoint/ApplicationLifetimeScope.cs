using VContainer;
using VContainer.Unity;
using ILogger = Example.Dummy.ILogger;
using Logger = Example.Dummy.Logger;

namespace Example._03_EntryPoint
{
    public class ApplicationLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // RegisterEntryPointで指定したクラスはEntryPointと呼ばる.
            // いわゆる開始時処理クラスとして使うことができ､IContainerBuilderでのBuild後に､Resolveを呼ばなくてもインスタンス化される.
            // ※RegisterEntryPointに指定するクラスは､VContainerが提供するインタフェースを1つ以上実装しないと使えない. cf)EntryPointDispatcher.
            builder.RegisterEntryPoint<ApplicationEntryPoint>();

            // ※EntryPoint内では､他にDIした型も使うことができる.
            builder.Register<ILogger, Logger>(Lifetime.Singleton);
        }
    }
}