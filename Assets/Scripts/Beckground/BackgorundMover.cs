using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;
public class BackgorundMover : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnedBackground = new List<GameObject>();
    [SerializeField] private RectTransform _transformParentBackground;
    [SerializeField] private float _movingSpeed = 5;
    [SerializeField] private float ZoneTeleport = -1930;

    private List<RectTransform> _createdReactransformBeckground = new List<RectTransform>();

    private void Start()
    {
        float corner=0;
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

    private void FixedUpdate()
    {
        CheckBackground();
        MoveBackground();
    }

    private void CheckBackground()
    {
        RectTransform LastBackground = _createdReactransformBeckground.Last();
        float corner = 0;
        for (int i = 0; i < _createdReactransformBeckground.Count; i++)
        {
            if (_createdReactransformBeckground[i].anchoredPosition.x <= ZoneTeleport)
            {
                Debug.Log(_createdReactransformBeckground[i].position.x);
                RectTransform rt = LastBackground.GetComponent<RectTransform>();
                corner += rt.sizeDelta.x * (_createdReactransformBeckground.Count-1);// или же *3
                Vector2 newaPositions = new Vector2(corner, rt.anchoredPosition.y);
                _createdReactransformBeckground[i].anchoredPosition = newaPositions; // адаптация кода 

            }
            
        }
    }

    private void MoveBackground()
    {
        for (int i = 0; i < _createdReactransformBeckground.Count; i++) 
        {
            //Vector2 positions = _createdReactransformBeckground[i].position;
            //positions = Vector2.Lerp(positions, positions + Vector2.left, _movingSpeed); // A + (B-A)*t
            //_createdReactransformBeckground[i].position = positions; /*сделал по примеру*/

            Vector2 positions = _createdReactransformBeckground[i].anchoredPosition;
            positions.x -= _movingSpeed;
            _createdReactransformBeckground[i].anchoredPosition = positions;// свое 
        }


    }
}