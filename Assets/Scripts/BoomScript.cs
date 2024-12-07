using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomScript : Weapon
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;


    public override void Move()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }
    public override void OnHitWith(Character character)
    {
        if (character is Player)
            character.TakeDamage(this.Damage);

    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Move();
    }
}
