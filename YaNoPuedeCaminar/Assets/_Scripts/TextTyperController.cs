using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextTyperController : MonoBehaviour
{
    private TMP_Text dialogueText;

    private float waitSeconds = 0.08f;

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
        typeLineCoroutine = TypeLine(string.Empty);
    }

    public void showDialogue(string dialogue, TMP_Text text)
    {
        dialogueText = text;
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
