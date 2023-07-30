using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController2 : MonoBehaviour
{

    [SerializeField] string message;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("DialogueBubble2").GetComponent<DialogueBubbleController>().ShowElement(message);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("DialogueBubble2").GetComponent<DialogueBubbleController>().HideElement();
        }
    }
}
