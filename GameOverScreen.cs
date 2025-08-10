using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("menuScene");
    }
}



