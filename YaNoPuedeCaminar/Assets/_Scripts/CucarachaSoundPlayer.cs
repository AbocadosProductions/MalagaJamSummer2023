using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CucarachaSoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip leftStep;
    [SerializeField] private AudioClip rightStep;
    [SerializeField] private AudioClip death;
    [SerializeField] private AudioClip[] deathList;

    public void playLeftStep()
    {
        AudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(leftStep);
    }

    public void playRightStep()
    {
        AudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(rightStep);
    }

    public void playDeath()
    {
        AudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(death);
    }

    public void playDeathMultiSound()
    {
        int deathSoundsNumber = deathList.Count();
        int soundToPlay = Random.Range(0, deathSoundsNumber);
        AudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(deathList[soundToPlay]);
    }
}
