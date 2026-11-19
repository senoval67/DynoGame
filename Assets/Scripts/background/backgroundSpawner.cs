using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Senoval67.DunoGame.Background
{
    public class backgroundSpawner : MonoBehaviour
    {

        [SerializeField] private List<GameObject> _spawnedBackground = new List<GameObject>();

        [SerializeField] private RectTransform _transformParentBackground;

        public List<RectTransform> _createdReactransformBeckground = new List<RectTransform>();

        public void SpawnBackground()
        {
            float corner = 0;
            for (int i = 0; i < _spawnedBackground.Count; i++)
            {
                GameObject SPBackground = Instantiate(_spawnedBackground[i], _transformParentBackground);
                RectTransform rt = SPBackground.GetComponent<RectTransform>();
                corner += rt.sizeDelta.x;
                Vector2 newaPositions = new Vector2(corner, rt.anchoredPosition.y);
                rt.anchoredPosition = (newaPositions);
                _createdReactransformBeckground.Add(rt);

            }

        }

    }
}
