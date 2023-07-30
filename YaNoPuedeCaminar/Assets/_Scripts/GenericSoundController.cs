using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSoundController : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;

    public void play()
    {
        AudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
    }
    public void stop()
    {
        AudioController.instance.gameObject.GetComponent<AudioSource>().Stop();
    }


}
