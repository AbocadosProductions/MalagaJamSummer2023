using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueBubbleController : MonoBehaviour
{
    private GameObject dialogueBubble;
    private void Awake()
    {
    }

    public void HideElement()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    public void ShowElement(string textToShow)
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.GetComponent<TextTyperController>().showDialogue(textToShow, gameObject.transform.GetChild(0).gameObject.GetComponentInChildren<TMP_Text>());
    }
}
