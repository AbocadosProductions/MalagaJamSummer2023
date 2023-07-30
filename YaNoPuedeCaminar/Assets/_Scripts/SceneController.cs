using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    private string nextScene;
    private Vector3 initialPosition = Vector3.zero;
    private Vector3 initialRotation = Vector3.zero;
    private GameObject initilizer;


    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        LoadLevelData();
    }

    public void LoadLevel(string targetLevel=null)
    {
        if (targetLevel == null)
        {
            string nextScenePath = SceneUtility.GetScenePathByBuildIndex(SceneManager.GetActiveScene().buildIndex + 1);
            int slash = nextScenePath.LastIndexOf('/');
            string sceneNameWithDot = nextScenePath.Substring(slash + 1);
            int punto = sceneNameWithDot.LastIndexOf('.');
            nextScene = sceneNameWithDot.Substring(0, punto);
        }

        else nextScene = targetLevel;
        SceneManager.LoadScene(nextScene);
    }

    private void SetInitialPosition() {  initialPosition = initilizer.transform.position; }
    private void SetInitialRotation() {  initialRotation = initilizer.transform.eulerAngles; }

    public Vector3 GetInitialPosition() { return initialPosition; }
    public Vector3 GetInitialRotation() { return initialRotation; }


    public void LoadLevelData()
    {
        if (SceneManager.GetActiveScene().name != "Menu" && SceneManager.GetActiveScene().name != "Credits" && SceneManager.GetActiveScene().name != "Introducçao")
        {
            initilizer = GameObject.Find("InitValues");
            SetInitialPosition();
            SetInitialRotation();
            
        }
        if (SceneManager.GetActiveScene().name == "Nivel1")
        {
            GameObject.Find("BackgroundAudioSource").GetComponent<BackGroundAudioController>().BackGroundPlay(1);
        }
        if (SceneManager.GetActiveScene().name == "Nivel2")
        {
            GameObject.Find("BackgroundAudioSource").GetComponent<BackGroundAudioController>().BackGroundPlay(2);
        }
        if (SceneManager.GetActiveScene().name == "Nivel3")
        {
            GameObject.Find("BackgroundAudioSource").GetComponent<BackGroundAudioController>().BackGroundPlay(3);
        }
        if (SceneManager.GetActiveScene().name == "Nivel4")
        {
            GameObject.Find("BackgroundAudioSource").GetComponent<BackGroundAudioController>().BackGroundPlay(4);
        }
        if (SceneManager.GetActiveScene().name == "EndScreen")
        {
            GameObject.Find("BackgroundAudioSource").GetComponent<BackGroundAudioController>().BackGroundPlay(5);
        }
    }

}
