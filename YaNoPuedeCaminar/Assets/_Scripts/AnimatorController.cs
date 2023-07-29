using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ChangeAnimationState(string conditionToAnimate) 
    {
        switch (conditionToAnimate)
        {
            case "Death":
                animator.SetBool("IsDying", true);
                break;
            case "Move":
                animator.SetBool("IsMoving", true);
                break;
            case "Idle":
                animator.SetBool("IsDying", false);
                animator.SetBool("IsMoving", false);
                break;
            default:
                break;
        }
    }
}
