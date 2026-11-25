using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    [SerializeField] private JumpPlayer _jumpPlayer;
    public void Init()
    {
        _jumpPlayer.Init();
    }
    public void Tick()
    {
        _jumpPlayer.Tick();
    }
}
