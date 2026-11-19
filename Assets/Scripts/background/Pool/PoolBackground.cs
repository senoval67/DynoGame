using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UIElements;

public class PoolBackground :MonoBehaviour
{
    [SerializeField] private GameObject _prefabBackground;
    [SerializeField] private RectTransform _transformParentBackground;

    [SerializeField] public int _poolCount;
    [SerializeField] public List<GameObject>_backgroundPool = new List<GameObject>();


    public void Start()
    {
        for (int i=0;i < _poolCount ;i++) 
        {
            _backgroundPool.Add(Instantiate(_prefabBackground, _transformParentBackground));
        }
    }

    public GameObject Get() 
    {
        if (_backgroundPool.Count > 0) 
        {
            GameObject prefabbackground = _prefabBackground;
            prefabbackground.SetActive(true);
            return prefabbackground;
        }
        return Create();
    }

    public void Return(GameObject prefabbackground) 
    {
        prefabbackground.SetActive(false);
        _backgroundPool.Add(prefabbackground);
    }

    private GameObject Create() 
    {
        GameObject background = Instantiate(_prefabBackground, _transformParentBackground);
        return background;
    }
}
