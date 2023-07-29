using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueBubbleController : MonoBehaviour
{
    private GameObject dialogueBubble;
    private void Awake()
    {
        dialogueBubble = GameObject.Find("DialogueBubble");
    }

    public void HideElement()
    {
        dialogueBubble.SetActive(false);
    }

    public void ShowElement(string textToShow)
    {
        dialogueBubble.SetActive(true);
        gameObject.GetComponent<TextTyperController>().showDialogue(textToShow, dialogueBubble.GetComponentInChildren<TMP_Text>());
    }
}
