using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_AnimController_MH : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("IsWalking", true);
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("IsWalking", false);
        }
    }
}
