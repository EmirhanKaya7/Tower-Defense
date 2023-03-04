
using System;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager Instance;
    public Transform turretParent;


    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one instance");
            return;
        }
        Instance = this;
    }

    public GameObject standardTurretPrefab;

    private void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
    
    
    
}