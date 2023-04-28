using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour
{
    public GameObject exitDoor;
    public Transform doorSpawn;
    AudioSource coinGet;
    // Start is called before the first frame update
    void Start()
    {
        coinGet = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Coin[] coins = FindObjectsOfType<Coin>();
        if (coins.Length == 0)
        {
            Instantiate(exitDoor, doorSpawn.transform);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            Destroy(collision.gameObject);
            coinGet.Play();
            GameManager.instance.coins++;

        }
    }
}
