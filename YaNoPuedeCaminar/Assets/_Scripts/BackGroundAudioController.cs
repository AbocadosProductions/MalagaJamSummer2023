using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundAudioController : MonoBehaviour
{
    public static BackGroundAudioController instance;
    [SerializeField] private AudioClip backgroundAudioClipNivel1;
    [SerializeField] private AudioClip backgroundAudioClipNivel2;
    [SerializeField] private AudioClip backgroundAudioClipNivel3;
    [SerializeField] private AudioClip backgroundAudioClipNivel4;
    [SerializeField] private AudioClip backgroundAudioClipFiesta;
    [SerializeField] private AudioClip backgroundAudioClipMenu;
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

    public void BackGroundPlay(int clipIndex)
    {
        switch (clipIndex)
        {
            case 1:
                Invoke("Play1", 0.25f);
                break;
            case 2:
                Invoke("Play2", 0.25f);
                break;
            case 3:
                Invoke("Play3", 0.25f);
                break;
            case 4:
                Invoke("Play4", 0.25f);
                break;
            case 5:
                Invoke("Play5", 0.25f);
                break;
            case 6:
                Invoke("Play6", 0.25f);
                break;
            default:
                Invoke("AudioTramposo", 0.25f);
                break;
        }
    }

    public void AudioTramposo()
    {
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().Stop();
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(backgroundAudioClipNivel1);
    }

    private void Play1()
    {
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().Stop();
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(backgroundAudioClipNivel1);
    }

    private void Play2()
    {
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().Stop();
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(backgroundAudioClipNivel2);
    }

    private void Play3()
    {
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().Stop();
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(backgroundAudioClipNivel3);
    }

    private void Play4()
    {
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().Stop();
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(backgroundAudioClipNivel4);
    }

    private void Play5()
    {
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().Stop();
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(backgroundAudioClipFiesta);
    }

    private void Play6()
    {
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().Stop();
        BackGroundAudioController.instance.gameObject.GetComponent<AudioSource>().PlayOneShot(backgroundAudioClipMenu);
    }
}
