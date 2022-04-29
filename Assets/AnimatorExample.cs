using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorExample : MonoBehaviour
{
    private Animator animator;
   
    void Start()
    {
        animator = GetComponent<Animator>();

        // To get animator variable value
        animator.GetFloat("forward");

        // To set animator variable value
        animator.SetFloat("forward", 5);
    }

    private void OnAnimatorMove() {
        // this function will shadow the apply root motion on the animator
        // we can set the movement here
    }
}
