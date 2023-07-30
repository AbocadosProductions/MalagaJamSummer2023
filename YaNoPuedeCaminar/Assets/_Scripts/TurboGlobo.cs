using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurboGlobo : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Cucaracha").GetComponent<Animator>().SetBool("IsGlobing", true);
        Invoke("LoadNextLevel", 2.5f);

    }

    private void LoadNextLevel()
    {
        SceneController.instance.LoadLevel();
        GameObject.Find("Cucaracha").GetComponent<Animator>().SetBool("IsGlobing", false);
        GameManager.instance.UpdateGameState(GameState.Playing);

    }

}
