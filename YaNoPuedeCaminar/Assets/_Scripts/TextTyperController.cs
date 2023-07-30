using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TextTyperController : MonoBehaviour
{
    private TMP_Text dialogueText;

    private float waitSeconds = 0.02f;

    private IEnumerator typeLineCoroutine;

    private bool hasSoundToPlay = false;

    private GenericSoundController soundController = null;

    private float playingTime = 0f;
    private float maxplayingTime = 0.1f;

    private IEnumerator TypeLine(string dialogue)
    {
        foreach (char c in dialogue.ToCharArray())
        {
            Debug.Log(dialogue.ToCharArray().Count());
            dialogueText.text += c;
            if (hasSoundToPlay ) 
            {
                playingTime += Time.deltaTime;
                
                if (playingTime > maxplayingTime )
                {
                    soundController.stop();
                    soundController.play();
                    playingTime = 0f;
                }
            }
            yield return new WaitForSeconds(waitSeconds);
        }
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
        if (TryGetComponent<GenericSoundController>(out GenericSoundController sound))
        { 
            hasSoundToPlay = true;
            soundController = sound;
            soundController.play();
        }
        else { hasSoundToPlay = false; }
        StartCoroutine(typeLineCoroutine);
    }

    private void clearDialogueBox()
    {
        StopCoroutine(typeLineCoroutine);
        typeLineCoroutine = TypeLine(string.Empty);
        dialogueText.text = string.Empty;
    }
}
