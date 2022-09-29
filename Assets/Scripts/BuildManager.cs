using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake ()
    {
        instance = this;
    }

    public GameObject AR15Prefab;
    public GameObject TAR21Prefab;
    public GameObject P7Prefab;
    public GameObject ThunderPrefab;
    public GameObject UKM2000Prefab;
    public GameObject PKPrefab;
    public GameObject M99Prefab;
    public GameObject SVDPrefab;
    public GameObject KSGPrefab;
    public GameObject SPAS12Prefab;
    public GameObject UMP9Prefab;
    public GameObject VectorPrefab;

    public NodeUI nodeUI;

    private TurretBlueprint turretToBuild;
    private Node selectedNode;

    public bool CanBuild { get { return turretToBuild != null;}}

    public void BuildTurretOn (Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enought money");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
    }
    
    public void SelectNode (Node node)
    {
        if (selectedNode == node){
            DeselecteNode();
            return;
        }
        selectedNode = node;
        turretToBuild = null;
        nodeUI.SetTarget(node);
    }    

    public void DeselecteNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
        DeselecteNode();
    }
}
