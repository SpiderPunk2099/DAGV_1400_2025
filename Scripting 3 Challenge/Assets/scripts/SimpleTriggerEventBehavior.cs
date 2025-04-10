using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SimpleTriggerEventBehavior : MonoBehaviour

{
    private Animator animator;

    public UnityEvent triggerEvent;

    private void Start()
    {
        animator = GameObject.Find("Fin").GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("Player"))
        {
            triggerEvent.Invoke();
        }
    }
}
