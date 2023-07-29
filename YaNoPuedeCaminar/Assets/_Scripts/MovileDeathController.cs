using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovileDeathController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float range;
    private Vector2 initialPosition;
    private bool isMovingUpwards = true;
    private Rigidbody2D mobileDeathRb;

    // Start is called before the first frame update
    void Start()
    {
        mobileDeathRb = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingUpwards)
        {
            if (initialPosition.y + range > transform.position.y) { mobileDeathRb.velocity = new Vector2(0.0f, speed); }
            else { isMovingUpwards = false; }
        }
        else
        {
            if (initialPosition.y - range < transform.position.y) { mobileDeathRb.velocity = new Vector2(0.0f, -speed); }
            else { isMovingUpwards = true; }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<DeathController>().Die();
        }
    }
}
