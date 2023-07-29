using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectableObjectsController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<GenericSoundController>().play();
            GameObject.Destroy(this.gameObject);
            SceneController.instance.LoadLevel();
        }
    }
}
