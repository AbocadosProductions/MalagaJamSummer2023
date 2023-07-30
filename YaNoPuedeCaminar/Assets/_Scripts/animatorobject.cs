using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorobject : MonoBehaviour
{
    [SerializeField] string variable;

    public void SetVariable()
    {
        GameObject.Find("Cucaracha").GetComponent<Animator>().SetBool(variable, true);
    }
}
