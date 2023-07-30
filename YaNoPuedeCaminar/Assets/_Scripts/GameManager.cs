using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    MainMenu,
    Playing,
    Pause,
    Death,
    Credits,
    Animating
}

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public GameState state;
    private float timeScalePlaying = 1.0f;
    private float timeScalePause = 0.0f;

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
    }

    public void UpdateGameState(GameState newState)
    {
        state = newState;

        switch (newState)
        {
            case GameState.MainMenu:
                Time.timeScale = timeScalePlaying;
                break;
            case GameState.Playing:
                Time.timeScale = timeScalePlaying;
                break;
            case GameState.Pause:
                Time.timeScale = timeScalePause;
                break;
            case GameState.Death:
                break;
            default:
                break;
        }
    }


    /*
    // Esto queda pausado ya que no es lo queremos hacer para el cambio de nivel

        
    private Vector3 cameraOffset = new Vector3(19.0f, 0.0f, 0.0f);
    private Vector3 cucarachaOffset = new Vector3(2.3f, 0.0f, 0.0f);

    IEnumerator coroutine = null;

    public void ChangeLevel(GameObject WallToUnlock)
    {
        UpdateGameState(GameState.Transition);
        ChangeWallStatus(WallToUnlock, false);
        MoveCameraAndCharacter();
        ChangeWallStatus(WallToUnlock, true);
        UpdateGameState(GameState.Playing);
    }

    private void ChangeWallStatus(GameObject WallToUnlock, bool status) { WallToUnlock.SetActive(status); }

    // TODO -- Seguir aqui, recoger referencia de camera, cucaracha y ajustar bien los nombres.
    private void MoveCameraAndCharacter()
    {
        coroutine = SmoothMover(Camera, Camera.transform, Camera.transform + cameraOffset, 10.0f);
        StartCoroutine(coroutine);
        coroutine = SmoothMover(Cucaracha, Cucaracha.transform, Cucaracha.transform + cucarachaOffset, 10.0f);
        StartCoroutine(coroutine);
    }

    IEnumerator SmoothMover (Transform objectToMove, Vector3 origin, Vector3 end, float speed)
    {
        float step = (speed / (origin - end).magnitude) * Time.fixedDeltaTime;
        float t = 0;
        while (t < 1.0f) 
        {
            t += step;
            objectToMove.position = Vector3.Lerp(origin, end, t);
            yield return new WaitForFixedUpdate();
        }
        objectToMove.position = end;
        StopCoroutine(coroutine);
    }
    */
}
