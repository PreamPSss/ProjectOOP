using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform target;

    void Update()
    {
        Vector3 Newposition = new Vector3(target.position.x,target.position.y,-10f);
        transform.position = Vector3.Slerp(transform.position, Newposition,FollowSpeed*Time.deltaTime);
    }
}
