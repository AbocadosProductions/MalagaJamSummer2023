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
                PauseMenuActivation(true);
            }

        }
    }

    //TODO Pasarlo a evento
    private void PauseMenuActivation(bool active)
    {
        ActivateDeactivateChilds(active);
    }

    private void ActivateDeactivateChilds(bool setActive)
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(setActive);
        gameObject.transform.GetChild(1).gameObject.SetActive(setActive);
        gameObject.transform.GetChild(2).gameObject.SetActive(setActive);
        gameObject.transform.GetChild(3).gameObject.SetActive(setActive);
        gameObject.transform.GetChild(4).gameObject.SetActive(setActive);
    }

    public void ContinueButton()
    {
        GameManager.instance.UpdateGameState(GameState.Playing);
        PauseMenuActivation(false);
    }

    public void MainMenuButton()
    {
        GameManager.instance.UpdateGameState(GameState.MainMenu);
        SceneController.instance.LoadLevel("Menu");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
