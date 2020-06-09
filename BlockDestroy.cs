using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Cube")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}