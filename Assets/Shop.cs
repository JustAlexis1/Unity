using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint AR15_bp;
    public TurretBlueprint TAR21_bp;
    public TurretBlueprint P7_bp;
    public TurretBlueprint Thunder_bp;
    public TurretBlueprint UKM2000_bp;
    public TurretBlueprint PK_bp;
    public TurretBlueprint M99_bp;
    public TurretBlueprint SVD_bp;
    public TurretBlueprint KSG_bp;
    public TurretBlueprint SPAS12_bp;
    public TurretBlueprint UMP9_bp;
    public TurretBlueprint Vector_bp;

    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectAR15 ()
    {
        Debug.Log("AR purchased");
        buildManager.SelectTurretToBuild(AR15_bp);
    }

    public void SelectTAR21 ()
    {
        Debug.Log("TAR purchased");
        buildManager.SelectTurretToBuild(TAR21_bp);
    }

    public void SelectP7 ()
    {
        Debug.Log("P7 purchased");
        buildManager.SelectTurretToBuild(P7_bp);
    }

    public void SelectThunder ()
    {
        Debug.Log("Thunder purchased");
        buildManager.SelectTurretToBuild(Thunder_bp);
    }

    public void SelectUKM2000 ()
    {
        Debug.Log("UKM purchased");
        buildManager.SelectTurretToBuild(UKM2000_bp);
    }

    public void SelectPK ()
    {
        Debug.Log("PK purchased");
        buildManager.SelectTurretToBuild(PK_bp);
    }

    public void SelectM99 ()
    {
        Debug.Log("M99 purchased");
        buildManager.SelectTurretToBuild(M99_bp);
    }

    public void SelectSVD ()
    {
        Debug.Log("SVD purchased");
        buildManager.SelectTurretToBuild(SVD_bp);
    }

    public void SelectKSG ()
    {
        Debug.Log("KSG purchased");
        buildManager.SelectTurretToBuild(KSG_bp);
    }

    public void SelectSPAS12 ()
    {
        Debug.Log("SPAS purchased");
        buildManager.SelectTurretToBuild(SPAS12_bp);
    }

    public void SelectUMP9 ()
    {
        Debug.Log("UMP purchased");
        buildManager.SelectTurretToBuild(UMP9_bp);
    }

    public void SelectVector ()
    {
        Debug.Log("Vector purchased");
        buildManager.SelectTurretToBuild(Vector_bp);
    }
}
