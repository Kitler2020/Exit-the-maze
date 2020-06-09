using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColl : MonoBehaviour
{
    Vector3 m_NewPosition = new Vector3(0.0f, 0.0f, 0.0f);

    void OnCollisionEnter(Collision c)
    {
        print(c.gameObject.name);

        if (c.gameObject.name == "Sphere")
        {
            gameObject.transform.position += m_NewPosition * Time.deltaTime;
        }
        if (c.gameObject.name == "trap")
        {
            Destroy(gameObject);
        }
    }
}