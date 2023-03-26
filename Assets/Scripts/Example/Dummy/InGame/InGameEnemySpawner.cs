using UnityEngine;

namespace Example.Dummy.InGame
{
    // 例) インゲーム中のエネミー生成クラスみたいな例
    public class InGameEnemySpawner : MonoBehaviour
    {
        public IEnemy Spawn(int id)
        {
            UnityEngine.Debug.Log($"{nameof(Spawn)} id:{id}");
            return null;
        }
    }

    public interface IEnemy
    {
        string Id { get; set; }
    }
}