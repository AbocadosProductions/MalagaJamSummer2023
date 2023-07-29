using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using Cinemachine;

public class CamaraMoveController : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera PriorizingCam;
    [SerializeField] CinemachineVirtualCamera NonPriorizingCam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PriorizingCam.Priority = 10;
            NonPriorizingCam.Priority = 0;

        }
    }
}
