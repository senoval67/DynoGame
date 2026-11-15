using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float JumpSpeed = 7f;

    [SerializeField] private CheckJump CheckJump;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        if (CheckJump.PermissionJump && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, JumpSpeed);
            CheckJump.PermissionJump = false;
        }
    }
}
