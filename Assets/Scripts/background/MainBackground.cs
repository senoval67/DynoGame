using UnityEngine;

namespace Senoval67.DunoGame.Background
{
    public class MainBackground : MonoBehaviour
    {
        [SerializeField] private PoolBackground _poolBackground;
        [SerializeField] private SpawnBackground _backgroundSpawner;
        [SerializeField] private TeleportBackground _backgroundTeleport;
        [SerializeField] private MoverBackground _backgorundMover;
        public void Init()
        {
            _poolBackground.SpawnPool();
            _backgroundSpawner.BackgroundSpawner();
        }
        public void Tick()
        {
            _backgroundTeleport.BackgroundTeleport();
            _backgorundMover.BackgorundMove();
        }
    }
}
