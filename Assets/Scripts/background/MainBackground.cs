using UnityEngine;

namespace Senoval67.DunoGame.Background
{
    public class MainBackground : MonoBehaviour
    {
        public SpawnBackground backgroundSpawner;
        public TeleportBackground backgroundTeleport;
        public MoverBackground backgorundMover;
        private void Start()
        {
            backgroundSpawner.BackgroundSpawner();
        }
        private void Update()
        {
            backgroundTeleport.BackgroundTeleport();
            backgorundMover.BackgorundMove();
        }
    }
}
