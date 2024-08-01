using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] string PlayerTag;
   
    Animator animator;
    [SerializeField] AudioSource OpenSound;
    [SerializeField] AudioSource CloseSound;
  

    private void Start()
    {
        animator = GetComponent<Animator>();  
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PlayerTag))
        {
            if (OpenSound.isPlaying) { OpenSound.Stop(); }
            if (CloseSound.isPlaying) { CloseSound.Stop(); }
            OpenSound.Play();
            animator.SetTrigger("open");
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag(PlayerTag))
        {
            if (OpenSound.isPlaying) { OpenSound.Stop(); }
            if (CloseSound.isPlaying) { CloseSound.Stop(); }
            CloseSound.Play();
            animator.SetTrigger("close");
        }
    }
}
