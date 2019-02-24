using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOver : MonoBehaviour
{
    public void endGame()
    {
        SceneManager.LoadScene("StartScene");
        PlayerMovement.startGame();
    }
}
