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
            /*
            if(GameManager.instance.state == GameState.Pause)
            {
                GameManager.instance.ChangeState(Playing);
                PauseMenuActivation(false);
            }
            else
            {
                GameManager.instance.ChangeState(Pause);
                PauseMenuActivation(false);
            }
            */
        }
    }

    //TODO Pasarlo a evento
    private void PauseMenuActivation(bool active)
    {
        GameObject.Find("PauseMenu").SetActive(active);
    }

    public void ContinueButton()
    {
        //GameManager.instance.ChangeState(Playing);
    }

    public void MainMenuButton()
    {
        //SceneController.instance.LoadMainMenu();
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
