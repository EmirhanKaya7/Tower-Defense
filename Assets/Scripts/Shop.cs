using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.Instance;
    }

    public void PurchaseTurret()
    {
        Debug.Log("PurchaseTurret");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseAnotherTurret()
    {
        Debug.Log("PurchaseAnotherTurret");
        buildManager.SetTurretToBuild(buildManager.AnotherTurretPrefab);
    }
}
