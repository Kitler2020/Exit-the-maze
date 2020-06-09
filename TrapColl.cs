using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapColl : MonoBehaviour
{
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "trap")
        {
            Destroy(c.gameObject);
        }
    }
}