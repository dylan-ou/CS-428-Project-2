using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class animationScript : MonoBehaviour
{
    public GameObject dylan;
    public GameObject button;

    Animator animator;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = dylan.GetComponent<Animator>();
        audioSource = dylan.GetComponent<AudioSource>();
        button = GameObject.Find("Button");
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed (VirtualButtonBehaviour vb)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Breathing Idle"))
        {
            audioSource.Play();
        }

        animator.SetBool("buttonPressed", true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Fuck 2");
        animator.SetBool("buttonPressed", false);
    }
}
