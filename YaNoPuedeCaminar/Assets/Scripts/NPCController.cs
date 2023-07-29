using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{

    [SerializeField] string message;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("SceneManager").GetComponent<DialogueBubbleController>().ShowElement("Frasecilla");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("SceneManager").GetComponent<DialogueBubbleController>().HideElement();
        }
    }
}
