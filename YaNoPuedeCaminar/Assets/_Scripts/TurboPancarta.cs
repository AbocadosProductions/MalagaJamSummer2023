using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurboPancarta : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Cucaracha").GetComponent<Animator>().SetBool("IsPancarting", true);
        Invoke("LoadNextLevel", 2.5f);

    }

    private void LoadNextLevel()
    {
        SceneController.instance.LoadLevel();
        GameObject.Find("Cucaracha").GetComponent<Animator>().SetBool("IsPancarting", false);
        GameManager.instance.UpdateGameState(GameState.Playing);

    }
}
