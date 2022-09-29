using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Spawner : MonoBehaviour
{
    public Transform tankPrefab1;
    public Transform tankPrefab2;
    public Transform flyingPrefab1;
    public Transform flyingPrefab2;
    public Transform basicPrefab1;
    public Transform basicPrefab2;

    public Transform spawnPoint1;
    public Transform spawnPoint2;

    public float timeBetweenWaves = 30f;
    private float countdown = 5f;
    public static int wave = 1;
    private int basic = 10;
    private int tank = 0;
    private int flying = 0;
    private int enemies = 0;
    private float gate;
    private float start;
    

    void Update ()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves + enemies;
        }
        countdown -= Time.deltaTime;
        
    }

    IEnumerator SpawnWave()
    {
        enemies = basic + tank + flying;
        Debug.Log("Wave incomming!");
        for (int i = 1; i<(enemies+1); i++)
        {
            if(i%3==0 && flying>1){
                SpawnFlying();
            }
            else if(i%5==0 && tank>1){
                SpawnTank();
            }
            else{
                SpawnBasic();
            }
            yield return new WaitForSeconds(0.5f);
        }
        wave++;
        PlayerStats.Waves--;
        if(wave%5==1){
            flying+=3;
        }
        if(wave%3==1){
            tank+=2;
        }
        basic++;
    }

    void SpawnBasic ()
    {
        gate = Random.Range(1, 100);
        start = Random.Range(1, 100);
        if(gate <= 50){
            if(start <= 50){
                Instantiate(basicPrefab1, spawnPoint1.position, spawnPoint1.rotation);
            }
            else{
                 Instantiate(basicPrefab1, spawnPoint2.position, spawnPoint2.rotation);
            }            
        }
        else{
            if(start <= 50){
                Instantiate(basicPrefab2, spawnPoint1.position, spawnPoint1.rotation);
            }
            else{
                 Instantiate(basicPrefab2, spawnPoint2.position, spawnPoint2.rotation);
            }       
        }
    }

    void SpawnFlying ()
    {
        gate = Random.Range(1, 100);
        start = Random.Range(1, 100);
        if(gate <= 50){
            if(start <= 50){
                Instantiate(flyingPrefab1, spawnPoint1.position, spawnPoint1.rotation);
            }
            else{
                Instantiate(flyingPrefab1, spawnPoint2.position, spawnPoint2.rotation);
            }            
        }
        else{
            if(start <= 50){
                Instantiate(flyingPrefab2, spawnPoint1.position, spawnPoint1.rotation);
            }
            else{
                Instantiate(flyingPrefab2, spawnPoint2.position, spawnPoint2.rotation);
            }           
        }
    }

    void SpawnTank ()
    {
        gate = Random.Range(1, 100);
        start = Random.Range(1, 100);
        if(gate <= 50){
            if(start<= 50){
                Instantiate(tankPrefab1, spawnPoint1.position, spawnPoint1.rotation);
            }
            else{
                Instantiate(tankPrefab1, spawnPoint2.position, spawnPoint2.rotation);
            }
        }
        else{
            if(start <= 50){
                Instantiate(tankPrefab2, spawnPoint1.position, spawnPoint1.rotation);
            }
            else{
                Instantiate(tankPrefab2, spawnPoint2.position, spawnPoint2.rotation);
            }
        }
    }
}
