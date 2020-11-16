using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemManager : MonoBehaviour
{
    public ParticleSystem ps;
    private void OnParticleSystemStopped()
    {
        ps.Play();
    }

    private void OnParticleCollision(GameObject other)
    {
        
    }
    private void OnParticleTrigger()
    {
        
    }
}
