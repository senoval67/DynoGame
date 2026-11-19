using UnityEngine;

namespace Senoval67.DunoGame.Background
{
    public class BackgorundMover : MonoBehaviour
    {
        [SerializeField] private float _movingSpeed = 5;
        private backgroundSpawner backgroundSpawner;
        public void MoveBackground()
        {//сделать 1 картинка и каждый кадр, все сотальные считаются от ее фактического положения , 
            Vector2 positions = backgroundSpawner._createdReactransformBeckground[0].anchoredPosition;
            positions.x -= _movingSpeed;
            backgroundSpawner._createdReactransformBeckground[0].anchoredPosition = positions;
            float WightOne = backgroundSpawner._createdReactransformBeckground[0].sizeDelta.x;
            float PositionsOneX = backgroundSpawner._createdReactransformBeckground[0].anchoredPosition.x;
            float pos = PositionsOneX - WightOne + WightOne + WightOne;
            backgroundSpawner._createdReactransformBeckground[1].anchoredPosition = new Vector2(pos, backgroundSpawner._createdReactransformBeckground[0].anchoredPosition.y);

        }
    }
}