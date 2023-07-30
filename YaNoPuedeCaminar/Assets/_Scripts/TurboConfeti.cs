using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurboConfeti : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Cucaracha").GetComponent<Animator>().SetBool("IsConfeting", true);
        Invoke("LoadNextLevel", 3.0f);

    }

    private void LoadNextLevel()
    {
        SceneController.instance.LoadLevel();
        GameObject.Find("Cucaracha").GetComponent<Animator>().SetBool("IsConfeting", false);
        GameManager.instance.UpdateGameState(GameState.Playing);

    }
}
