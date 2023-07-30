using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class TutorailController : MonoBehaviour
{
    private string text1 = "Las IAS se han vuelto locas, pero a nosotras nos da igual.";
    private string text2 = "Hay algo que celebrar...\r\n¿Nos ayudas?";
    private string text3 = "Pulsa <b>Q</b> y <b>E</b> para moverte.\r\nNecesitamos 4 objetos.";

    private int actualChildIndex = 0;

    private void ShowElement(int dialogueToShow, string textToShow)
    {
        gameObject.transform.GetChild(dialogueToShow).gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.GetComponent<TextTyperController>().showDialogue(textToShow, gameObject.transform.GetChild(dialogueToShow).gameObject.GetComponentInChildren<TMP_Text>());
    }

    private void ShowButton()
    {
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
    }

    private void ActivateChildren()
    {
        switch (actualChildIndex)
        {
            case 0:
                ShowElement(actualChildIndex, text1);
                break;
            case 1:
                ShowElement(actualChildIndex, text2);
                break;
            case 2:
                ShowElement(actualChildIndex, text3);
                break;
            case 3:
                ShowButton();
                break;
            default: 
                break;

        }
    }

    private void Start()
    {
        StartCoroutine(InitializeTutorial(0, 0.01f, text1));
        StartCoroutine(InitializeTutorial(1, 3.0f, text2));
        StartCoroutine(InitializeTutorial(2, 5.0f, text3));
        StartCoroutine(InitializeTutorial(3, 7.0f));

       
    }

    private IEnumerator InitializeTutorial(int index, float time, string text=null)
    {
        float t = 0;
        while (t < time)
        {
            t += Time.deltaTime;
            yield return null;
        }
        if (text != null) { ShowElement(index, text); }
        else { ShowButton(); }
    }

    public void LoadGame()
    {
        SceneController.instance.LoadLevel();
    }
}
