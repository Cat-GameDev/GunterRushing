using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] protected Transform skin;
    [SerializeField] private Gun gun;
    [SerializeField] private Enemy enemy;
    
    
    private void Start() 
    {
        OnInit();
    }

    void Update()
    {
        // if(!GameManager.Instance.IsState(GameState.GamePlay) || IsDead)
        //     return;
        
        if (Input.GetMouseButton(0))
        {
            Moving();
            
        }
        else
        {
            ChangeAnim(Constants.PLAYER_IDLE);  
        }
        AutoShoot();

        // enemies = LevelManager.Instance.GetEnemies();
  
    }

    protected override void OnInit()
    {
        moveSpeed = playerData.playerMoveSpeed;
        damge = playerData.playerDamge;
    }

    private void Moving()
    {
        TF.position = JoystickControl.direct * moveSpeed * Time.deltaTime + TF.transform.position;

        if (JoystickControl.direct != Vector3.zero)
        {
            skin.forward = JoystickControl.direct;
        }
        ChangeAnim(Constants.PLAYER_RUN);
    }

    private void AutoShoot()
    {
        gun.Shooting(enemy.transform);
    }

}
