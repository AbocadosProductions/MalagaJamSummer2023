using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextTyperController : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    private float waitSeconds = 0.02f;

    private IEnumerator typeLineCoroutine;

    private IEnumerator TypeLine(string dialogue)
    {
        foreach (char c in dialogue.ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(waitSeconds);
        }
        yield break;
    }

    private void Start()
    {
        dialogueText.text = string.Empty;
        typeLineCoroutine = TypeLine(string.Empty);
    }

    public void showDialogue(string dialogue)
    {
        clearDialogueBox();
        typeLineCoroutine = TypeLine(dialogue);
        StartCoroutine(typeLineCoroutine);
    }

    private void clearDialogueBox()
    {
        StopCoroutine(typeLineCoroutine);
        typeLineCoroutine = TypeLine(string.Empty);
        dialogueText.text = string.Empty;
    }
}
