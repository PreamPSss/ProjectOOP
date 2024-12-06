using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] GameObject scythe;
    [SerializeField] public GameObject Bullet { get { return scythe; } set { scythe = value; } }
    [field: SerializeField] Transform weaponSpawnPoint;
    [SerializeField] public Transform BulletSpawnPoint { get { return weaponSpawnPoint; } set { weaponSpawnPoint = value; } }

    [SerializeField] public float WaitTime { get; set; }
    [SerializeField] public float Timer { get; set; }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && WaitTime >= Timer)
        {
            GameObject obj = Instantiate(scythe, BulletSpawnPoint.position, Quaternion.identity);
            Scythe Scythe = obj.GetComponent<Scythe>();
            Scythe.Init(10, this);
        }
    }


    void Start()
    {
        Init(100);
        WaitTime = 1.0f;
        Timer = 0.0f;

    }
    void Update()
    {
        Shoot();
    }
}

