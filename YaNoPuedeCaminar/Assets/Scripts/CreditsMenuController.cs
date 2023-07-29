using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMenuController : MonoBehaviour
{
    public void MainMenuButton()
    {
        GameManager.instance.UpdateGameState(GameState.MainMenu);
        SceneController.instance.LoadLevel("Menu");
    }
}
