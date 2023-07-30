using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurboTarta : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Cucaracha").GetComponent<Animator>().SetBool("IsTarting", true);
        Invoke("LoadNextLevel", 2.5f);

    }

    private void LoadNextLevel()
    {
        SceneController.instance.LoadLevel();
        GameObject.Find("Cucaracha").GetComponent<Animator>().SetBool("IsTarting", false);
        GameManager.instance.UpdateGameState(GameState.Playing);

    }
}
