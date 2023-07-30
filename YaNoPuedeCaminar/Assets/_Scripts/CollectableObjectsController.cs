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
            GameObject.Find("ObjectControl").GetComponent<animatorobject>().SetVariable();
            gameObject.GetComponent<GenericSoundController>().play();
            GameManager.instance.UpdateGameState(GameState.Animating);
            GameObject.Destroy(this.gameObject);
            SceneController.instance.LoadLevel();
            BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().Stop();
        }
    }

}
