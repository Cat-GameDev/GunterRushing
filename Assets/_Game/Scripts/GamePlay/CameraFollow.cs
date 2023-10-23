using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : Singleton<CameraFollow>
{
    public Transform TF;
    public Transform playerTF;

    [SerializeField] Vector3 offset;

    private void LateUpdate()
    {
        // if(!GameManager.Instance.IsState(GameState.GamePlay))
        //     return;
        Vector3 targetPosition = playerTF.position + offset;


        TF.position = Vector3.Lerp(TF.position, targetPosition, Time.deltaTime * 5f);
    }
}







