using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private Transform target;
    public float range = 15f;
    public int damage = 5;
    private string enemyTag = "Enemy";
    public Animator animator;
    private GameObject victim;

    void Start ()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget ()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
                victim = nearestEnemy;
            }
        }
        if(nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
            animator.SetFloat("Shoot", 1f);
        }
        else
        {
            target = null;
            animator.SetFloat("Shoot", 0f);
        }
    }

    void Update ()
    {
        
        if (target == null) 
        {
            return;
        }
        
    }

    void OnDrawGizmosSelected ()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

    void Shoot ()
    {
        Debug.Log("SHOOT");
        victim.GetComponent<HP> ().HitPoints -= damage;
    }

    public void Upgrade ()
    {
        damage++;
        PlayerStats.Money -= 5;
    }
}
