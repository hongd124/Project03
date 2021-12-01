using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool rightPressed = Input.GetKey("d");
        bool leftPressed = Input.GetKey("a");
        bool backPressed = Input.GetKey("s");

        // forward movement animation
        if (forwardPressed)
        {
            animator.SetBool("isRunning", true);
        }

        if (!forwardPressed)
        {
            animator.SetBool("isRunning", false);
        }
    }
}
