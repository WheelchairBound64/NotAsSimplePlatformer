using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHandler : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    Coroutine respawnPlayer;
    Coroutine failScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            GameManager.instance.lives--;
            respawnPlayer = StartCoroutine(RespawnPlayer());
        }

        if (GameManager.instance.lives == 0)
        {
            failScreen = StartCoroutine(FailScreen());
        }
    }

    IEnumerator FailScreen()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("4 - Failure");
    }
    IEnumerator RespawnPlayer()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(player, respawnPoint.transform);
    }
}
