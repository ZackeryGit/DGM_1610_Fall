using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalPlayer : MonoBehaviour
{

    public ParticleSystem particleSystem;
    
    void Start()
    {
        particleSystem.Stop();
    }

    
    public void PlayParticles()
    {
        particleSystem.Play();
    }
    public void StopParticles()
    {
        particleSystem.Stop();
    }
}
