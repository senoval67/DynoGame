using Senoval67.DunoGame.Background;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private MainBackground _mainBackground;
    [SerializeField] private MainPlayer _mainPlayer;
    public void Start()
    {
        _mainPlayer.Init();
        _mainBackground.Init();
    }

    public void FixedUpdate()
    {
        _mainBackground.Tick();
        _counter.Tick();
        _mainPlayer.Tick();
    }
}
