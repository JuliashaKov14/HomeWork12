using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter2D(Collider2D collision)
    {
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
