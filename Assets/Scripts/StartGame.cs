using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartGameFunction()
    {
        SceneManager.LoadScene("2 - Game");
        GameManager.instance.coins = 0;
        GameManager.instance.lives = 5;
    }
}
