using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSound : MonoBehaviour
{
    private AudioSource audioSource;
    
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}
