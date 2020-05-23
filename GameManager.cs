using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

    public bool paused;

    // instance
    public static GameManager instance;
    
    void Awake()
    {
        instance = this;

    }

    public void AddScore(int scoreToGive)
    {
        score += scoreToGive;
    }
    public void LevelEnd()
    {
        // is this the last level?
        if (SceneManager.sceneCountInBuildSettings == SceneManager.GetActiveScene().buildIndex + 1)
        {
            // display the win screen
            WinGame();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
    public void WinGame()
    {

    }
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}