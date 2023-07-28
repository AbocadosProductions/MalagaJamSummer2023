using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CucarachaMovementController : MonoBehaviour
{
    private bool leftMovement = false;
    private bool rightMovement = false;
    private float breakTime = 0.5f;
    private float xForce = 50f;
    private float yForce = 50f; 
    private Vector2 leftMovementForce = new Vector2(0f, 0f);
    private Vector2 rightMovementForce = new Vector2(0f, 0f);
    private Vector2 lastForce = new Vector2(0f, 0f);
    private Rigidbody2D cucharachaRb = null;

    private IEnumerator coroutine;

    void Start()
    {
        cucharachaRb = GetComponent<Rigidbody2D>();
        leftMovementForce = new Vector2(xForce * (Mathf.Cos(transform.rotation.z) + Mathf.Sin(transform.rotation.z)), xForce * (Mathf.Cos(transform.rotation.z) + Mathf.Sin(transform.rotation.z)));
        rightMovementForce.x = xForce;
        rightMovementForce.y = yForce;
    }

    void Update()
    {
        GetInputs();
        HandleInputs();
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
            //cucharachaRb.AddForce(leftMovementForce);
            coroutine = Break(leftMovementForce);
            StartCoroutine(coroutine);
            ROTATOR();
        }
        else if (rightMovement)
        {
            cucharachaRb.AddForce(rightMovementForce);
            coroutine = Break(rightMovementForce);
            StartCoroutine(coroutine);
        }
    }

    private IEnumerator Break(Vector2 direction)
    {
        while (true)
        {
            yield return new WaitForSeconds(breakTime);
            cucharachaRb.AddForce(direction * new Vector2(-1f, -1f));
            StopCoroutine(coroutine);
        }
    }

    private void ROTATOR()
    {
        transform.Rotate(0.0f, 0.0f, 30.0f, Space.Self);
    }
}