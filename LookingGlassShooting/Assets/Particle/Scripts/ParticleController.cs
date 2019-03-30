using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField]
    ParticleSystem spring;
    [SerializeField]
    ParticleSystem summer;
    [SerializeField]
    ParticleSystem fall;
    [SerializeField]
    ParticleSystem winter;
    // Start is called before the first frame update
    void Start()
    {
        spring.Play();
        fall.Play();
        winter.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
