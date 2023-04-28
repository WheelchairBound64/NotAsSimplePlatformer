using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayCoinsandLives : MonoBehaviour
{
    public TMP_Text lives;
    public TMP_Text coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = "x " + GameManager.instance.coins;
        lives.text = "x " + GameManager.instance.lives;
    }
}
