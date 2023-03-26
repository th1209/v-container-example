using Example.Dummy;
using UnityEngine;
using UnityEngine.Assertions;
using VContainer;
using VContainer.Unity;
using ILogger = Example.Dummy.ILogger;
using Logger = Example.Dummy.Logger;

namespace Example._02_LifetimeScope
{
    // アプリケーション全体で使われるLifetimeScope
    public class ApplicationLifetimeScope : LifetimeScope
    {
        [SerializeField] private EffectManager effectManager;

        protected override void Configure(IContainerBuilder builder)
        {
            Assert.IsNotNull(effectManager);

            builder.Register<ILogger, Logger>(Lifetime.Singleton);
            builder.Register<ISoundManager, SoundManager>(Lifetime.Singleton);
            builder.Register<AppManager>(Lifetime.Singleton);
            builder.RegisterComponent<IEffectManager>(effectManager);
        }
    }
}