
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    [SerializeField] Rigidbody body;
    [SerializeField] float power;
    [SerializeField] float steerPower;


    public void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        var steer = 0;

        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(Vector3.right* steerPower* Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
            {
            body.AddForce(-Vector3.right* steerPower* Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            body.AddForce(Vector3.forward * power * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            body.AddForce(-Vector3.forward * power * Time.deltaTime);
        }


    }
}
