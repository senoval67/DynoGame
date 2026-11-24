using Senoval67.DunoGame.Background;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
    public Counter _counter;
    public JumpPlayer _jumpPlayer;
    public MainBackground _mainBackground;
    void Start()
    {
        _mainBackground.Init();
        _counter.Init();

    }

    void FixedUpdate()
    {
        _mainBackground.Tick();
        _counter.ScoreCounter();
        _jumpPlayer.Tick();
    }
}
