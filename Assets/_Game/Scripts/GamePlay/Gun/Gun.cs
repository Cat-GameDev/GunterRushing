using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : GameUnit
{
    [SerializeField] protected GunData gunData;
    [SerializeField] protected B_Default bullet;
    [SerializeField] protected Transform gunPoint;
    protected float moveSpeed;
    protected float damge;
    protected float fireRateTime;
    protected float shootDelay = 0f;

    public float GetMoveSpeed()
    {
        return this.moveSpeed;
    }

    public float GetDamge()
    {
        return this.damge;
    }

    public virtual void Shooting(Transform targetPosition)
    {
        // shootDelay += Time.deltaTime;
        // if(fireRateTime < shootDelay)
        // {
        //     Instantiate(bullet, gunPoint.position, gunPoint.rotation);
        //     bullet.BulletFly(targetPosition);
        //     shootDelay = 0;
        // }
        // Debug.Log(2);
        
    }


}

