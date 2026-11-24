using UnityEngine;

namespace Senoval67.DunoGame.Background
{
    public class MainBackground : MonoBehaviour
    {
        public PoolBackground _poolBackground;
        public SpawnBackground backgroundSpawner;
        public TeleportBackground backgroundTeleport;
        public MoverBackground backgorundMover;
        public void Init()
        {
            _poolBackground.SpawnPool();
            backgroundSpawner.BackgroundSpawner();
        }
        public void Tick()
        {
            backgroundTeleport.BackgroundTeleport();
            backgorundMover.BackgorundMove();
        }
    }
}
