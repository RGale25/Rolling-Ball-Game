using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //function closes menu and opens game
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    //function to close the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
