using VContainer;

namespace Example.Dummy.InGame
{
    // 例) インゲーム中の全体管理クラス､みたいな例
    public class InGameManager
    {
        [Inject]
        private ISoundManager _soundManager;

        [Inject]
        private IEffectManager _effectManager;

        [Inject]
        private InGameTurnManager _inGameTurnManager;

        [Inject]
        private InGameEnemySpawner _inGameEnemySpawner;

        public InGameManager()
        {
            UnityEngine.Debug.Log($"{nameof(InGameManager)} Constructor");
        }

        public void Dump()
        {
            UnityEngine.Debug.Log($"{nameof(Dump)} \n" +
                                  $"    ISoundManager:{_soundManager != null} \n" +
                                  $"    IEffectManager:{_effectManager != null} \n" +
                                  $"    InGameTurnManager:{_inGameTurnManager != null} \n" +
                                  $"    InGameEnemySpawner:{_inGameEnemySpawner != null} \n");
        }
    }
}