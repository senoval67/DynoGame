using UnityEngine;

namespace Senoval67.DunoGame.Background
{
    public class backgroundMain : MonoBehaviour
    {
        private backgroundSpawner backgroundSpawner;
        private backgroundTeleport backgroundTeleport;
        private BackgorundMover backgorundMover;
        private void Start()
        {
            backgroundSpawner.SpawnBackground();
        }
        private void Update()
        {
            backgroundTeleport.CheckBackground();
            backgorundMover.MoveBackground();
        }
    }
}