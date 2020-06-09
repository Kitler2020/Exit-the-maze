using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDanger : MonoBehaviour
{
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Sphere")
        {
            c.gameObject.transform.position = new Vector3(5.15f, 15f, -2.65f);
        }
    }
}