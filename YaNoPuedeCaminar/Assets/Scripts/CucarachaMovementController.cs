using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CucarachaMovementController : MonoBehaviour
{
    private bool leftMovement = false;
    private bool rightMovement = false;
    private float xForce = 50f;
    private float yForce = 50f; 
    private Vector2 leftMovementForce = new Vector2(0f, 0f);
    private Vector2 rightMovementForce = new Vector2(0f, 0f);
    private Vector2 lastForce = new Vector2(0f, 0f);
    private Rigidbody2D cucharachaRb = null;
    private float angle;

    private IEnumerator coroutine;

    void Start()
    {
        cucharachaRb = GetComponent<Rigidbody2D>();
        rightMovementForce.x = xForce;
        rightMovementForce.y = yForce;
        leftMovementForce.x = -xForce;
        leftMovementForce.y = yForce;
    }

    void Update()
    {

        if (GameManager.instance.state == GameState.Playing)
        {
            GetInputs();
            HandleInputs();
        }
    }

    private void GetInputs()
    {
        leftMovement = Input.GetKeyDown(KeyCode.Q);
        rightMovement = Input.GetKeyDown(KeyCode.E);
    }

    private void HandleInputs()
    {
        if (leftMovement)
        {
            cucharachaRb.AddRelativeForce(leftMovementForce);
            ROTATOR(leftMovementForce.x);
        }
        else if (rightMovement)
        {
            cucharachaRb.AddRelativeForce(rightMovementForce);
            ROTATOR(rightMovementForce.x);
        }
    }

    // TODO Renombrar
    private void ROTATOR(float force)
    {
        if (force > 0.0f) angle = -30.0f;
        else angle = 30.0f;
        transform.Rotate(0.0f, 0.0f, angle, Space.Self);
    }

    // TODO Pasarlo a Evento
    public void stop()
    {
        cucharachaRb.velocity = Vector3.zero;
        cucharachaRb.angularVelocity = 0.0f;
    }
}