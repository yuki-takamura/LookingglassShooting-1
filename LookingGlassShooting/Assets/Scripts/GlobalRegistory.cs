using System;
using LooklingGlassShooting.Models;
using UnityEngine;

public class GlobalRegistory : MonoBehaviour
{
    public static Player[] players;
    public static SeasonFormat[] PlayerSeasons;
    public static TimeSpan RoundTime = TimeSpan.FromSeconds(60.0f);

    public GlobalRegistory()
    {
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetSeasons(SeasonFormat player1Season, SeasonFormat player2Season)
    {
        PlayerSeasons = new SeasonFormat[]{
            player1Season,
            player2Season,
        };
        
    }
}
