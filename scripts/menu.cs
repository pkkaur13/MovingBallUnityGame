using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string sceneName1;


    public void playGame1()
    {
        SceneManager.LoadScene(sceneName1);
    }

    public void quitGame()
    {
        Debug.Log("This will quit the game, only works after the game is actually built not in Unity editor");
        Application.Quit();
    }
    
}
