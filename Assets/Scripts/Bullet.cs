using System;
using DG.Tweening;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform target;
    public float speed =70f;
    public GameObject impactEffect;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    public void ShootTarget()
    {
        
        transform.DOMove(target.position, speed).SetSpeedBased(true);
    }
    // Update is called once per frame
  

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        ShootTarget();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameObject effectIns = Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectIns,2f);
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }
    
    
}
