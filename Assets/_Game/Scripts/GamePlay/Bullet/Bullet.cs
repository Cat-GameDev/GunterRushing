using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : GameUnit
{
    public float moveSpeed;
    public float damge;

    public void BulletAction(Transform target, float damge)
    {
        BulletFly(target);
        BulletDamge(damge);
    }

    public virtual void BulletFly(Transform target)
    {

    }

    public virtual void BulletDamge(float damge)
    {

    }
}
