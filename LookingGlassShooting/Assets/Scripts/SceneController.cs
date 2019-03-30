using System.Collections;
using System.Collections.Generic;
using LooklingGlassShooting.Models;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        
    }

    public void ShowTitle()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowCharacterSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void CharactersSelected(SeasonFormat player1Season, SeasonFormat player2Season)
    {
        GlobalRegistory.SetSeasons(player1Season,player2Season);
        ShowBattle();
    }

    private void ShowBattle()
    {
        SceneManager.LoadScene(2);
    }
}
