using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMainMenu : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("1 - Title");
        GameManager.instance.coins = 0;
        GameManager.instance.lives = 5;
    }
}
