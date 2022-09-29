using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == object1.position || transform.position == object2.position ){
            PlayerStats.Lives--;
            Destroy(gameObject);
        }
    }
}
