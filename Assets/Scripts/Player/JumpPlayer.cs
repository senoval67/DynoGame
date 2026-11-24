using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UIElements;

public class JumpPlayer : MonoBehaviour
{
    private float _playerPositions = -1.5f;

    private bool _jump;
    private bool _jumpingHeight;
    public void Tick()
    {
        if (transform.position.y == -1.5f && Input.GetKeyDown(KeyCode.Space))
        {
            _jump = true;
        }
        if (transform.position.y >= 2f)
        {
            _jump = false;
            _jumpingHeight = true;
        }
        TransPlayer();
    }

    public void TransPlayer()
    {
        if (_jump)
        {
            _playerPositions += 0.1f;
            transform.position = new Vector2(-6, _playerPositions);
        }
        if (_jumpingHeight && !_jump && transform.position.y >= -1.4f)
        {
            _playerPositions -= 0.1f;
            transform.position = new Vector2(-6, _playerPositions);
        }

    }
}