using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenController : MonoBehaviour
{
    public void ContinueButton()
    {
        SceneController.instance.LoadLevel();
    }
    private void Start()
    {
        StartCoroutine(ShowEndButton(0, 6.0f));
    }

    private IEnumerator ShowEndButton(int index, float time)
    {
        float t = 0;
        while (t < time)
        {
            t += Time.deltaTime;
            yield return null;
        }
        ShowButton();
    }

    private void ShowButton()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

}
