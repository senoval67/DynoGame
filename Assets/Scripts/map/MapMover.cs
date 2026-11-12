using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MapMover : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("minimum speed.")]
    [SerializeField] private float minSpeed;

    [Tooltip("max speed.")]
    [SerializeField] private float maxSpeed;

    [Tooltip("curent cpeed.")]
    [SerializeField] private float speed;

    [Tooltip("Boost moving speed per second.")]
    [SerializeField] private float BoostSpeedPerSecond;

    [SerializeField] private bool isPlay;


    private void Update()
    {
        if (this.isPlay) 
        {
            Vector3 position = transform.position;
            position = Vector3.Lerp(position, position + Vector3.left, Time.deltaTime * this.speed);
            transform.position = position;
        }
    }

    private IEnumerator SpeedCounter()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            this.speed += BoostSpeedPerSecond / 10;

            this.speed = Mathf.Clamp(this.speed, this.minSpeed, this.maxSpeed);
        }
    }

    public void OnGameStart() => StartCoroutine(SpeedCounter());

    public void OnPause() =>this.isPlay = false;

    public void OnContinue() => this.isPlay = true;

}
