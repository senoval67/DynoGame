using UnityEngine;

namespace Senoval67.DunoGame.Background
{
    public class MoverBackground : MonoBehaviour
    {
        [SerializeField] public float _movingSpeed = 5;
        public SpawnBackground BackgroundSpawner;
        public void BackgorundMove()
        {
            int k = 1;
            for (int i = 0; i < BackgroundSpawner._createdReactransformBeckground.Count-1; i++)
            {
                Vector2 positions = BackgroundSpawner._createdReactransformBeckground[i].anchoredPosition;
                positions.x -= _movingSpeed;
                BackgroundSpawner._createdReactransformBeckground[i].anchoredPosition = positions;

                float WightOne = BackgroundSpawner._createdReactransformBeckground[i].sizeDelta.x;
                float PositionsOneX = BackgroundSpawner._createdReactransformBeckground[i].anchoredPosition.x;
                float pos = PositionsOneX - WightOne + WightOne + WightOne;
                BackgroundSpawner._createdReactransformBeckground[k].anchoredPosition = new Vector2(pos, BackgroundSpawner._createdReactransformBeckground[0].anchoredPosition.y);
                k++;
            }

        }
    }
}