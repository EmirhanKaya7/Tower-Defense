using System;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 offSet;
    private GameObject turret;
   

    private Color startColor;
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Cant build");
            return;
        }

        GameObject turretToBuild = BuildManager.Instance.GetTurretToBuild();
        turret = Instantiate(turretToBuild, transform.position + offSet, transform.rotation, BuildManager.Instance.turretParent);
    }

    private void OnMouseEnter() 
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;

    }
}
