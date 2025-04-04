using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particleSystem;

    public int firstEmissionAmount = 10;
    public int secondEmissionAmount = 20;
    public int thirdEmissionAmount = 30;
    public float delayBetweenParticles = 0.5f;
    private void Start()
    {
       particleSystem = GetComponent<ParticleSystem>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            StartCoroutine(EmitParticlesCoroutine());
        }
    }

    private IEnumerator EmitParticlesCoroutine()
    {
        particleSystem.Emit(firstEmissionAmount);
        yield return new WaitForSeconds(delayBetweenParticles);
        
        particleSystem.Emit(secondEmissionAmount);
        yield return new WaitForSeconds(delayBetweenParticles);
        
        particleSystem.Emit(thirdEmissionAmount);
        
        Destroy(gameObject);
    }
}
