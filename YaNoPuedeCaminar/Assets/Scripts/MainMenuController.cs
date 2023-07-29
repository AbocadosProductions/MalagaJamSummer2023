using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void StartButton()
    {
        //SceneController.instance.LoadFirstLevel();
    }

    public void CreditsButton()
    {
        //SceneController.instance.LoadCredits();
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
