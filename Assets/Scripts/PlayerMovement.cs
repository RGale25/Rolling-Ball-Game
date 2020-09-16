using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float addForce = 5000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, addForce * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-addForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -addForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(addForce * Time.deltaTime, 0, 0);
        }
    }
}
