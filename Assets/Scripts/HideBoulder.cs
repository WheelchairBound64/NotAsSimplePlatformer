using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBoulder : MonoBehaviour
{
    BoxCollider2D box;
    Coroutine destroyBoulder;
    // Start is called before the first frame update
    void Start()
    {
        box = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            destroyBoulder = StartCoroutine(DestroyBoulder());
            box.enabled = false;
        }
    }

    IEnumerator DestroyBoulder()
    {
        yield return new WaitForSeconds(1.6f);
        Destroy(gameObject);
    }
}
