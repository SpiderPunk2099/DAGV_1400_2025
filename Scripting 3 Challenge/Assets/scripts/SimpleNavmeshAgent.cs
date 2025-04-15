using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleNavmeshAgent : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}
