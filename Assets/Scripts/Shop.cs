using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.Instance;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("PurchaseTurret");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseMissileTurret()
    {
        Debug.Log("PurchaseAnotherTurret");
        buildManager.SetTurretToBuild(buildManager.missileTurretPrefab);
    }
}
