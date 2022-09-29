using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkTowardsBase : MonoBehaviour
{
    public float Speed;
    public Transform target;
    void Start()
    {
        target.GetComponent<Transform>();
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
    }
}
