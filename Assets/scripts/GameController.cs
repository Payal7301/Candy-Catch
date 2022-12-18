using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("Game");
    }

    public void exit()
    {
        Application.Quit();
    }
}
