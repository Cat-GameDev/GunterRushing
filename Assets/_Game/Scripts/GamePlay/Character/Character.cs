using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : GameUnit
{
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected Animator anim;
    protected float damge;
    protected string currentAnim;
    protected void ChangeAnim(string animName)
    {
        if (currentAnim != animName)
        {
            anim.ResetTrigger(currentAnim);
            currentAnim = animName;
            anim.SetTrigger(currentAnim);
        }
    }

    protected virtual void OnInit()
    {
        
    }
}
