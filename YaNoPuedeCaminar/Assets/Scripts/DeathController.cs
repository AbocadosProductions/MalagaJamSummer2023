using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    private Vector3 initialPosition = Vector3.zero;
    private Vector3 initialRotation = Vector3.zero;
    private float deathTime = 0.25f;

    public void Die()
    {
        gameObject.GetComponent<AnimatorController>().ChangeAnimationState("Death");
        Invoke("RestartLevel", 0.15f);
    }

    private void RestartLevel()
    {
        gameObject.GetComponent<AnimatorController>().ChangeAnimationState("Idle");
        gameObject.transform.position = initialPosition;
        gameObject.transform.eulerAngles = initialRotation;
        gameObject.GetComponent<CucarachaMovementController>().stop();

    }
}
