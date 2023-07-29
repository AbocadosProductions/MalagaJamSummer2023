using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void StartButton()
    {
        SceneController.instance.LoadLevel("Level1");
    }

    public void CreditsButton()
    {
        SceneController.instance.LoadLevel("Credits");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
