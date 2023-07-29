using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathlyObstacleController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<GenericSoundController>().play();
            collision.GetComponent<DeathController>().Die();   
        }
    }
}
