using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney= 20;

    public static int Lives;
    public int startLives = 20;

    public static int Waves;
    public int cap = 10;
    
    void Start ()
    {
        Money = startMoney;
        Lives = startLives;
        Waves = cap;
    }
}
