using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SimpleFloatData health;
    void Start()
    {
        health.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
