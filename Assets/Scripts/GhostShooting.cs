using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GhostShooting : Enemy 
{
    [field: SerializeField] public GameObject boom;
    [SerializeField]  public Transform boomPos;
    public float Boomtimer;
    private GameObject player;
    public override void Behavior()
    {
        Instantiate(boom, boomPos.position, Quaternion.identity);
    }
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        Boomtimer += Time.deltaTime;
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance < 20)
        {
            Boomtimer += Time.deltaTime;
                if (Boomtimer > 2)
            {
                Boomtimer = 0;
                Behavior();
            }
        }
        
    }
   
}
