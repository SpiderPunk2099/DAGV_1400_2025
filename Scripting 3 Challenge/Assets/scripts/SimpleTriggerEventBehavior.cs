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
    private void OnTriggerStay(Collider other)

    {
        triggerEvent.Invoke();
        animator.SetTrigger("HitTrigger");
        //Debug.Log("Player interacter with the object!");
        
    }
}
