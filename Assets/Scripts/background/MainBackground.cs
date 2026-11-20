using UnityEngine;

namespace Senoval67.DunoGame.Background
{
    public class MainBackground : MonoBehaviour
    {
        public PoolBackground _poolBackground;
        public SpawnBackground backgroundSpawner;
        public TeleportBackground backgroundTeleport;
        public MoverBackground backgorundMover;
        private void Start()
        {
            _poolBackground.SpawnPool();
            backgroundSpawner.BackgroundSpawner();
        }
        private void Update()
        {
            backgroundTeleport.BackgroundTeleport();
            backgorundMover.BackgorundMove();
        }
    }
}
