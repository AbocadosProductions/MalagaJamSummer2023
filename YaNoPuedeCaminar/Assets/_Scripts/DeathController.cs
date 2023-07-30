using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    private Vector3 initialPosition = Vector3.zero;
    private Vector3 initialRotation = Vector3.zero;
    private float deathTime = 0.35f;
    [SerializeField] CinemachineVirtualCamera camToPrio = null;
    [SerializeField] CinemachineVirtualCamera camToUnPrio = null;


    public void Die()
    {
        gameObject.GetComponent<CucarachaSoundPlayer>().playDeathMultiSound();
        gameObject.GetComponent<AnimatorController>().ChangeAnimationState("Death");
        Invoke("RestartLevel", deathTime);
    }

    private void LoadLevelData()
    {
        initialPosition =  SceneController.instance.GetInitialPosition();
        initialRotation =  SceneController.instance.GetInitialRotation();
    }

    private void RestartLevel()
    {
        ResetCamera();
        SceneController.instance.LoadLevelData();
        LoadLevelData();
        gameObject.GetComponent<AnimatorController>().ChangeAnimationState("Idle");
        gameObject.transform.position = initialPosition;
        gameObject.transform.eulerAngles = initialRotation;
        gameObject.GetComponent<CucarachaMovementController>().stop();

    }

    private void ResetCamera()
    {
        if (camToPrio != null) 
        {
            camToPrio.Priority = 10; 
            camToUnPrio.Priority = 0;
        }

    }
}
