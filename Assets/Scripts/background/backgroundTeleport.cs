using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Senoval67.DunoGame.Background
{
    public class backgroundTeleport : MonoBehaviour
    {

        private backgroundSpawner backgroundSpawner;

        [SerializeField] private float ZoneTeleport = -1930;
        public void CheckBackground()
        {
            RectTransform LastBackground = backgroundSpawner._createdReactransformBeckground.Last();
            float corner = 0;
            for (int i = 0; i < backgroundSpawner._createdReactransformBeckground.Count; i++)
            {
                if (backgroundSpawner._createdReactransformBeckground[i].anchoredPosition.x <= ZoneTeleport)
                {
                    RectTransform rt = LastBackground.GetComponent<RectTransform>();
                    corner += rt.sizeDelta.x * (backgroundSpawner._createdReactransformBeckground.Count - 1);// или же *3
                    Vector2 newaPositions = new Vector2(corner, rt.anchoredPosition.y);
                    backgroundSpawner._createdReactransformBeckground[i].anchoredPosition = newaPositions; // адаптация кода 
                }
            }
        }
    }
}
