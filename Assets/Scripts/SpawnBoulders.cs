using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnBoulders : MonoBehaviour
{
    public GameObject boulder;
    public GameObject player; 
    Coroutine spawnBoulder;
    // Start is called before the first frame update
    void Start()
    {
        spawnBoulder = StartCoroutine(SpawnBoulder());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator SpawnBoulder()
    {
        while (!player.IsDestroyed())
        {
            Instantiate(boulder, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
