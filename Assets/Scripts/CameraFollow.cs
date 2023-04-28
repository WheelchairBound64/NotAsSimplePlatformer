using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject follower;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        follower.transform.position = player.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            follower.transform.position = player.GetComponent<Transform>().position;
        }
        else
        {
            player = GameObject.FindWithTag("Player");
            follower.transform.position = player.GetComponentInParent<Transform>().position;
        }
    }
}
