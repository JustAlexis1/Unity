using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public GameObject turret;
    public TurretBlueprint turretBlueprint;
    public bool isUpgraded = false;
    BuildManager buildManager;
    
    void Start ()
    {
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition ()
    {
        return transform.position;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        
        if (turret != null)
        {
            buildManager.SelectNode(this);
            return;
        }

        if(!buildManager.CanBuild)
        {
            return;
        }

        buildManager.BuildTurretOn(this);
    }

    public void UpgradeTurret ()
    {
        if (PlayerStats.Money < turretBlueprint.cost)
        {
            return;
        }
        PlayerStats.Money -= turretBlueprint.upgradeCost;
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.upgradedPrefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;
    }

    
}
