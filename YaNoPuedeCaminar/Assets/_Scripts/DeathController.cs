using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    private Vector3 initialPosition = Vector3.zero;
    private Vector3 initialRotation = Vector3.zero;
    private float deathTime = 1.25f;
    [SerializeField] CinemachineVirtualCamera camToPrio = null;
    [SerializeField] CinemachineVirtualCamera camToUnPrio = null;


    public void Die()
    {
        GameManager.instance.UpdateGameState(GameState.Death);
        gameObject.GetComponent<CucarachaSoundPlayer>().playDeathMultiSound();
        gameObject.GetComponent<AnimatorController>().ChangeAnimationState("Death");
        Invoke("RestartLevel", deathTime);
        gameObject.GetComponent<CucarachaMovementController>().stop();
    }

    private void LoadLevelData()
    {
        initialPosition =  SceneController.instance.GetInitialPosition();
        initialRotation =  SceneController.instance.GetInitialRotation();
    }

    private void RestartLevel()
    {
        gameObject.GetComponent<AnimatorController>().ChangeAnimationState("Idle");
        SceneController.instance.LoadLevelData();
        LoadLevelData();
        Invoke("MovePosition", 0.25f);
    }

    private void ResetCamera()
    {
        if (camToPrio != null) 
        {
            camToPrio.Priority = 10; 
            camToUnPrio.Priority = 0;
        }

    }

    private void MovePosition()
    {
        gameObject.transform.position = initialPosition;
        gameObject.transform.eulerAngles = initialRotation;
        ResetCamera();
        GameManager.instance.UpdateGameState(GameState.Playing);
    }
}
