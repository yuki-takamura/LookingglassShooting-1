using System;
using LooklingGlassShooting.Models;
using UnityEngine;

public class GlobalRegistory : MonoBehaviour
{
    public static Player[] players;
    public static TimeSpan RoundTime = TimeSpan.FromSeconds(60.0f);

    public GlobalRegistory()
    {
        players = new Player[]{
            new Player(), new Player()
        };
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
