using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundAudioController : MonoBehaviour
{
    public static BackGroundAudioController instance;
    [SerializeField] private AudioClip backgroundAudioClip;
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void BackGroundPlay()
    {
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(backgroundAudioClip);
    }
}
