using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Default : Bullet
{
    [SerializeField] protected G_Default g_Default;
    void Start()
    {
        OnInit();
    }

    public override void BulletDamge(float damge)
    {
        damge = g_Default.GetDamge();
    }

    private void OnInit()
    {
        moveSpeed = g_Default.GetMoveSpeed();
        BulletDamge(damge);
    }

    public override void BulletFly(Transform target)
    {
        OnInit();
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
