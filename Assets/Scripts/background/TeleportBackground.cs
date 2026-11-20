using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Senoval67.DunoGame.Background
{
    public class TeleportBackground : MonoBehaviour
    {

        public SpawnBackground BackgroundSpawner;

        [SerializeField] private float ZoneTeleport;



        public void BackgroundTeleport()
        {

            
            float corner = 0;
            int k = 1;
            for (int i = 0; i < BackgroundSpawner._createdReactransformBeckground.Count; i++)
            {
                if (BackgroundSpawner._createdReactransformBeckground[i].anchoredPosition.x <= ZoneTeleport)
                {
                    RectTransform LastBackground = BackgroundSpawner._createdReactransformBeckground.Last();
                    RectTransform rt = LastBackground.GetComponent<RectTransform>();
                    corner += rt.sizeDelta.x * (BackgroundSpawner._createdReactransformBeckground.Count - 1);
                    BackgroundSpawner._createdReactransformBeckground[i].anchoredPosition = new Vector2(corner, rt.anchoredPosition.y);
                    k++;
                    if (k <= BackgroundSpawner._createdReactransformBeckground.Count)
                    {
                        k = 1;
                    }
                    var VRdan = BackgroundSpawner._createdReactransformBeckground[k].anchoredPosition;
                    BackgroundSpawner._createdReactransformBeckground[i].anchoredPosition = BackgroundSpawner._createdReactransformBeckground[k].anchoredPosition;
                    BackgroundSpawner._createdReactransformBeckground[k].anchoredPosition = VRdan;
                }
            }
        }
    }
}