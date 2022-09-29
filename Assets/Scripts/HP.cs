using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int HitPoints = 15;

    void Update ()
    {
        if(HitPoints<0)
        {
            PlayerStats.Money++;
            Destroy(gameObject);
        }
    }
}
