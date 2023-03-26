using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Tutorial
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField] private HelloScreen helloScreen;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<GamePresenter>();
            builder.Register<HelloWorldService>(Lifetime.Singleton);
            builder.RegisterComponent(helloScreen);
        }
    }
}