using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void StartButton()
    {
        GameManager.instance.UpdateGameState(GameState.Playing);
        SceneController.instance.LoadLevel("Level1");
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
