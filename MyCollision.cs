using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyCollision : MonoBehaviour
{
    public int speed = 10;
    public GameObject portal;
    public GameObject image;
    public GameObject text;
    public GameObject slider;
    public GameObject floor;
    public GameObject floordanger;

    Vector3 CubePosition = new Vector3(0.0f, 0.0f, 10.0f);
    Vector3 WallPosition = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 RespawnPosition = new Vector3(5.15f, 13.5f, -2.7f);

    Vector3 C1 = new Vector3(3.5f, 5.5f, -2.0f);
    Vector3 C2 = new Vector3(6.5f, 5.5f, -2.0f);
    Vector3 C3 = new Vector3(5.0f, 5.5f, -3.5f);
    Vector3 C4 = new Vector3(5.0f, 5.5f, -0.5f);

    void OnCollisionEnter(Collision c)
    {
        print(c.gameObject.name);

        if (c.gameObject.name == "Block")
        {
            Destroy(c.gameObject);
            print("Block destroyed");
        }

        if (c.gameObject.name == "Danger")
        {
            print("Game over!");
            gameObject.transform.position = RespawnPosition;
        }
        if (c.gameObject.name == "Danger1")
        {
            gameObject.transform.position = new Vector3(58.5f, 18.5f, 50.15f);
        }

        if (c.gameObject.name == "Cube")
        {
            c.gameObject.transform.position += CubePosition * speed * Time.deltaTime;
        }
        if (c.gameObject.name == "Wall")
        {
            gameObject.transform.position += WallPosition * Time.deltaTime;
        }
        if (c.gameObject.name == "Respawn")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (c.gameObject.name == "trap")
        {
            print("Game over!");
            SceneManager.LoadScene("SampleScene");
        }
        if (c.gameObject.name == "P1")
        {
            c.gameObject.AddComponent<Trap1>();
        }
        if (c.gameObject.name == "FloorTrap")
        {
            c.gameObject.AddComponent<Trap2>();
        }

        if (c.gameObject.name == "Fall")
        {
            c.gameObject.AddComponent<Trap2>();
        }
        if (c.gameObject.name == "Fall1")
        {
            Destroy(c.gameObject);

            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

        if (c.gameObject.name == "CubeWall")
        {
            Destroy(c.gameObject);
        }
        if (c.gameObject.name == "LiftRespawn")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (c.gameObject.name == "Lift")
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

        if (c.gameObject.name == "Portal")
        {
            gameObject.transform.position = new Vector3(5f, 13f, 20f);
        }
        if (c.gameObject.name == "Portal1")
        {
            gameObject.transform.position = new Vector3(5.15f, 15f, -2.65f);
            floordanger.AddComponent<FloorDanger>();

            Destroy(c.gameObject);
            Destroy(floor);
        }
        if (c.gameObject.name == "Portal2")
        {
            Destroy(portal);
            Destroy(image);
            Destroy(text);
            Destroy(slider);

            gameObject.transform.position = new Vector3(5.15f, 125f, -3f);
        }
        if (c.gameObject.name == "Portal3")
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }

        if (c.gameObject.name == "CubeSpawn1")
        {
            Destroy(c.gameObject);

            GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube1.AddComponent<Rigidbody>();
            cube1.transform.position = new Vector3(-1.5f, 20, 13f);
            cube1.name = "CubeSpawn2";
            cube1.GetComponent<Renderer>().material.color = Color.red;
        }
        if (c.gameObject.name == "CubeSpawn2")
        {
            Destroy(c.gameObject);

            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube2.AddComponent<Rigidbody>();
            cube2.transform.position = new Vector3(5f, 20, -25f);
            cube2.name = "CubeSpawn3";
            cube2.GetComponent<Renderer>().material.color = Color.red;
        }
        if (c.gameObject.name == "CubeSpawn3")
        {
            Destroy(c.gameObject);

            GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube3.AddComponent<Rigidbody>();
            cube3.AddComponent<BoxCollider>();
            cube3.AddComponent<CubeColl>();
            cube3.AddComponent<Trap>();
            cube3.transform.position = new Vector3(5f, 20, 2.5f);
            cube3.name = "Cube";
            cube3.GetComponent<Renderer>().material.color = Color.red;
        }

        if (c.gameObject.name == "W1")
        {
            Destroy(c.gameObject);
        }
        if (c.gameObject.name == "W2")
        {
            Destroy(c.gameObject);
        }
        if (c.gameObject.name == "W3")
        {
            Destroy(c.gameObject);
        }

        if (c.gameObject.name == "С1")
        {
            Destroy(c.gameObject);
            gameObject.transform.position = C1;
        }
        if (c.gameObject.name == "C2")
        {
            Destroy(c.gameObject);
            gameObject.transform.position = C2;
        }
        if (c.gameObject.name == "C3")
        {
            Destroy(c.gameObject);
            gameObject.transform.position = C3;
        }
        if (c.gameObject.name == "C4")
        {
            Destroy(c.gameObject);
            gameObject.transform.position = C4;
        }
    }
}