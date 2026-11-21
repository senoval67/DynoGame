using Senoval67.DunoGame.Background;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private GameObject _scoreObject;
    public float _scoreMultipler =1f;
    private Text _textScore;
    private float _time;

    private void Start()
    {
        _textScore =_scoreObject.GetComponent<Text>();
    }

    void FixedUpdate()
    {
        ScoreCounter();
    }

    private void ScoreCounter() 
    {
        _time = Time.realtimeSinceStartup;
        _textScore.text = ((int)_time* _scoreMultipler).ToString();
    }
}
