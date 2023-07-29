using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    bool hasToPauseUnpause = false;

    void Update()
    {
        GetInputs();
        HandleInputs();
    }

    private void GetInputs()
    {
        hasToPauseUnpause = Input.GetKeyDown(KeyCode.Escape);
    }

    private void HandleInputs()
    {
        if (hasToPauseUnpause)
        {

            if(GameManager.instance.state == GameState.Pause)
            {
                GameManager.instance.UpdateGameState(GameState.Playing);
                PauseMenuActivation(false);
            }
            else
            {
                GameManager.instance.UpdateGameState(GameState.Pause);
                PauseMenuActivation(false);
            }

        }
    }

    //TODO Pasarlo a evento
    private void PauseMenuActivation(bool active)
    {
        GameObject.Find("PauseMenu").SetActive(active);
    }

    public void ContinueButton()
    {
        GameManager.instance.UpdateGameState(GameState.Playing);
        PauseMenuActivation(false);
    }

    public void MainMenuButton()
    {
        SceneController.instance.LoadLevel("Menu");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
