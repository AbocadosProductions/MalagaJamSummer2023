using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void Start()
    {
        GameObject.Find("BackgroundAudioSource").GetComponent<BackGroundAudioController>().BackGroundPlay(6);
    }

    public void StartButton()
    {
        GameManager.instance.UpdateGameState(GameState.Playing);
        SceneController.instance.LoadLevel();
    }

    public void CreditsButton()
    {
        GameManager.instance.UpdateGameState(GameState.Credits);
        SceneController.instance.LoadLevel("Credits");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
