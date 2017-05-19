using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomRotator : MonoBehaviour {
    public float speed; //angularSpeed = 20f;
     void Update ()
    {
        transform.Rotate(0, speed, speed);
           // GetComponent<Rigidbody2D>().AddTorque(Random.Range(-angularSpeed, angularSpeed));
     }

    // Update is called once per frame
    //void Update () {

    //}
}
