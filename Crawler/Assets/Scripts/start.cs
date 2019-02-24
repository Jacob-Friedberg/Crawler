using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
     public void startGame()
    {
        SceneManager.LoadScene("Level1");
        PlayerMovement.startGame(); 
    }

    public void quitButton()
    {

        Application.Quit();

    }
    public void backButton()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void creditsButton()
    {
        SceneManager.LoadScene("Credits");
    }
}
