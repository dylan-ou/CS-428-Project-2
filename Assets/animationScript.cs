using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScript : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    bool buttonPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            buttonPressed = true;
        } else
        {
            buttonPressed = false;
        }

        if (buttonPressed && animator.GetCurrentAnimatorStateInfo(0).IsName("Breathing Idle"))
        {
            audioSource.Play();
        }

        animator.SetBool("buttonPressed", buttonPressed);
    }
}
