using Example.Dummy.InGame;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions;
using VContainer;
using VContainer.Unity;

namespace Example._02_LifetimeScope
{
    // InGame用のSceneでのみ使われる､みたいな気持ちのLifetimeScope(※ApplicationLifetimeScopeを親に設定してある)
    public class InGameSceneLifetimeScope : LifetimeScope
    {
        [SerializeField] private InGameEnemySpawner inGameEnemySpawner;

        protected override void Configure(IContainerBuilder builder)
        {
            Assert.IsNotNull(inGameEnemySpawner);

            builder.Register<InGameManager>(Lifetime.Scoped);
            builder.Register<InGameTurnManager>(Lifetime.Scoped);
            builder.RegisterComponent<InGameEnemySpawner>(inGameEnemySpawner);

        }
    }

    // ↓以下、依存関係構築の確認用
    [CustomEditor(typeof(InGameSceneLifetimeScope))]
    public class InGameSceneLifetimeScopeEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!Application.isPlaying) return;
            
            var lifetimeScope = target as InGameSceneLifetimeScope;
            Assert.IsNotNull(lifetimeScope);

            if (GUILayout.Button("Dump"))
            {
                // ↓InGameManagerに､全ての依存が設定されてあるのを確かめる.
                // ※2度以上押しても､1回しかインスタンス生成されていないのが分かる
                var inGameManager = lifetimeScope.Container.Resolve<InGameManager>();
                inGameManager.Dump();
            }
        }
    }
}