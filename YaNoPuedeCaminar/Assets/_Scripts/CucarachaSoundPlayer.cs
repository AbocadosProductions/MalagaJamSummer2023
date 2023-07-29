using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CucarachaSoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip leftStep;
    [SerializeField] private AudioClip rightStep;

    public void playLeftStep()
    {
        AudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(leftStep);
    }

    public void playRightStep()
    {
        AudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(rightStep);
    }
}
