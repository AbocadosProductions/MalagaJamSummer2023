using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private string nextScene;
    //private Vector3 initialPosition = new Vector3(-9.0f, 4.0f, -1.0f);
    //private Vector3 initialRotation = new Vector3(0.0f, 0.0f, 180.0f);
    private Vector3 initialPosition = Vector3.zero;
    private Vector3 initialRotation = Vector3.zero;


    public void NextLevel()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Credits":
                nextScene = "Main Menu";
                break;

            default:
                nextScene = SceneUtility.GetScenePathByBuildIndex(SceneManager.GetActiveScene().buildIndex + 1);
                break;
        }
        SceneManager.LoadScene(nextScene);
    }

    public Vector3 GetInitialPosition() { return initialPosition; }
    public Vector3 GetInitialRotation() { return initialRotation; }
}
