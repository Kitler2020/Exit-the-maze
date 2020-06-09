using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public int speed = 5;
    public int speed1 = 6;
    public int jumpForce;
    public bool IsGround; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
            
            if (Input.GetKey(KeyCode.LeftShift))
            {
                gameObject.transform.position += gameObject.transform.forward * speed1 * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= gameObject.transform.forward * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                gameObject.transform.position += gameObject.transform.forward * -1 * speed1 * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += gameObject.transform.right * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                gameObject.transform.position += gameObject.transform.right * speed1 * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= gameObject.transform.right * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                gameObject.transform.position += gameObject.transform.right * -1 * speed1 * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
            print("Restart");
        }

        Jump();
    }

    public void Jump()
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit rh;

        if(Physics.Raycast(ray, out rh, 1f))
        {
            IsGround = true;
        } else { IsGround = false; }

        if (Input.GetKeyDown(KeyCode.Space) && IsGround)
        {
            rb.AddForce(Vector3.up * jumpForce);
            print("Jump");
        }
    }
}