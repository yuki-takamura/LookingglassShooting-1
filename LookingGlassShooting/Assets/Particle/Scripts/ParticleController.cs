using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Season
{
    spring,summer,fall,winter
}
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

    public Season own;
    public Season enemy;
    public int damage;
    public float hSliderValue = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        //spring.Play();
        //fall.Play();
        //winter.Play();
        if (own == Season.spring || enemy == Season.spring)
        {
            spring.Play();
        }
        if (own == Season.summer || enemy == Season.summer)
        {
            summer.Play();
        }
        if (own == Season.fall || enemy == Season.fall)
        {
            fall.Play();
        }
        if (own == Season.winter || enemy == Season.winter)
        {
            winter.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        var emission = spring.emission;
        emission.rateOverTime = hSliderValue;
            //= 0.1f;
    }
}
