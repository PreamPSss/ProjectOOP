using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed = 8f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")* speed,rb.velocity.y);
        if (Input.GetKey(KeyCode.Space))
            rb.velocity = new Vector2(rb.velocity.x,speed);
    }

}
