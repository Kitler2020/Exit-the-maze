using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftColl : MonoBehaviour
{
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Lift")
        {
            c.gameObject.transform.position = new Vector3(62.49f, -4.5f, 50.11f);
            gameObject.transform.position = new Vector3(62.5f, 25.125f, 50.1f);
        }
    }

    void Update()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}