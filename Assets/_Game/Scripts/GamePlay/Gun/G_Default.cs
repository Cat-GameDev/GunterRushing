using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_Default : Gun
{
    private void Awake() 
    {
        OnInit();
    }

    private void OnInit()
    {
        moveSpeed = gunData.moveSpeedGunDefault;
        damge = gunData.damageGunDefault;
        fireRateTime = gunData.fireRateGunDefault;
    }

    public override void Shooting(Transform targetPosition)
    {
        OnInit();
        shootDelay += Time.deltaTime;
        if(fireRateTime < shootDelay)
        {
            Instantiate(bullet, gunPoint.position, gunPoint.rotation);
            bullet.BulletAction(targetPosition, damge);
            shootDelay = 0;
        }
        Debug.Log(3);
        
    }
}
