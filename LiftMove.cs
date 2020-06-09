using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftMove : MonoBehaviour
{
    public float timer, coolDown;

    void FixedUpdate()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            gameObject.transform.position += new Vector3(0f, 0.5f, 0f);
            timer = coolDown;
        }
    }
}