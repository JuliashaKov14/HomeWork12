using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMovement: MonoBehaviour
{
    public float fireRate;
    private float nextFire;
    public float speed;
    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.up * speed;
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
        }
    }
    }
