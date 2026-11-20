using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Senoval67.DunoGame.Background
{
    public class SpawnBackground : MonoBehaviour
    {
        [SerializeField] private PoolBackground _poolBackground;

        public List<RectTransform> _createdReactransformBeckground = new List<RectTransform>();

        public void BackgroundSpawner()
        {
            _poolBackground.Get();
            float corner = 0;
            for (int i = 0; i < _poolBackground._backgroundPool.Count; i++)
            {
                RectTransform rt = _poolBackground._backgroundPool[i].GetComponent<RectTransform>();
                corner = rt.sizeDelta.x;
                rt.anchoredPosition = new Vector2(corner, 0);
                _createdReactransformBeckground.Add(rt);
            }

        }

    }
}