using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float timer, coolDown = 0.7f;

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            cube.AddComponent<Rigidbody>();
            cube.AddComponent<BoxCollider>();
            cube.transform.position = new Vector3(5.3f, 10, 5.7f);
            cube.name = "trap";
            cube.tag = "Player";
            cube.transform.localScale = new Vector3(4.5f, 1, 1);
            cube.GetComponent<Renderer>().material.color = Color.black;
            //cube.GetComponent<Renderer>().material = new Material(Shader.Find("Danger")); //Хана грі!

            timer = coolDown;
        }
    }
}