using Example.Dummy;
using UnityEngine;
using UnityEngine.Assertions;
using VContainer;
using VContainer.Unity;
using ILogger = Example.Dummy.ILogger;
using Logger = Example.Dummy.Logger;

namespace Example._01_SimpleDI
{
    // 起動確認用のMonoBehaviour
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private EffectManager effectManager;

        private IObjectResolver _objectResolver;

        private void Start()
        {
            Assert.IsNotNull(effectManager);

            // まず､ContainerBuilderを作る(このクラスがDIコンテナを作る)
            var containerBuilder = new ContainerBuilder();

            // ContainerBuilderに､DIしてほしい型を一通り登録する
            // ※順番は何でも良い
            containerBuilder.Register<ILogger, Logger>(Lifetime.Singleton);
            containerBuilder.Register<ISoundManager, SoundManager>(Lifetime.Singleton);
            containerBuilder.Register<AppManager>(Lifetime.Singleton);
            // 登録したい型がMonoBehaviourの場合は､RegisterComponentメソッドでインスタンスを登録する
            containerBuilder.RegisterComponent<IEffectManager>(effectManager);

            // ※Registerの方法は､他にも色々ある(以下はLoggerクラスの他の登録方法の例)
            // ex) メソッドチェーンで記述的に登録する
            // containerBuilder.Register<Logger>(Lifetime.Singleton).As<ILogger>();
            // ex) 生成済みインスタンスを登録する
            // containerBuilder.RegisterInstance<ILogger>(new Logger());

            // ビルドしてDIコンテナを生成
            // ※このタイミングで､リフレクションで依存が解決される
            // ※Registerした型のインスタンスの生成はまだ
            _objectResolver = containerBuilder.Build();

            // DIコンテナからResolveすると､はじめてインスタンスが作られる
            // ※試しに以下のブロックをコメントアウトすると、インスタンス生成されないことが確認できる
            _objectResolver.Resolve<AppManager>().Dump();
        }

        private void OnDestroy()
        {
            // Lifetime.Singletonの場合､Registerした型のインスタンスのライフサイクルは､DIコンテナと同期する.
            // DIコンテナをDisposeすれば､IDisposableを継承した型のDisposeも呼ばれる
            _objectResolver.Dispose();
        }
    }
}