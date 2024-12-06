using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public HealthBar healthBar;
    public Animator anim;
    public Rigidbody2D rb;

    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else return false;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        //healthBar.UpdateHealthBar(health);
        IsDead();
    }

    public void Init(int newHealth)
    {
        Health = newHealth;
        //healthBar.SetMaxHealth(newHealth);

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
}
