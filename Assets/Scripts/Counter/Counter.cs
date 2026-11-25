using Senoval67.DunoGame.Background;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text _textSettings;
    private float _time;

    public void Tick() 
    {
        _time = Time.realtimeSinceStartup;
        _textSettings.text = ((int)_time).ToString();
    }
}
