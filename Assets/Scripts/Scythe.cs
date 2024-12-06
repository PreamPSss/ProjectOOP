using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scythe : Weapon
{
    [SerializeField] float speed;
    private void Start()
    {
        Damage = 10;
        speed = 4.0f * GetShootDirection();
    }

    public override void Move()
    {
        //S = V*T
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;

        Debug.Log("Banana move constasnt with speed using Transform");
    }
    private void FixedUpdate()
    {
        Move();
    }
    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
            character.TakeDamage(this.Damage);
    }
}