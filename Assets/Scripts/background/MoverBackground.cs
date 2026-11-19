using UnityEngine;

namespace Senoval67.DunoGame.Background
{
    public class MoverBackground : MonoBehaviour
    {
        [SerializeField] private float _movingSpeed = 5;
        public SpawnBackground BackgroundSpawner;
        public void BackgorundMove()
        {//Первая картнка
            Vector2 positions = BackgroundSpawner._createdReactransformBeckground[0].anchoredPosition;
            positions.x -= _movingSpeed;
            BackgroundSpawner._createdReactransformBeckground[0].anchoredPosition = positions;
        
            float WightOne = BackgroundSpawner._createdReactransformBeckground[0].sizeDelta.x;
            float PositionsOneX = BackgroundSpawner._createdReactransformBeckground[0].anchoredPosition.x;
            float pos = PositionsOneX - WightOne + WightOne + WightOne;
            BackgroundSpawner._createdReactransformBeckground[1].anchoredPosition = new Vector2(pos, BackgroundSpawner._createdReactransformBeckground[0].anchoredPosition.y);

        }
    }
}