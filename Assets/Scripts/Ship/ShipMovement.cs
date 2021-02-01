using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Vector3 direction;
    public Vector3 rotation;

    public float x, z;

    public float decceleration;
    public float rotationDecceleration;
    public float velocity;
    public float acceleration;
    private float _acceleration;
    public float rotationRate;
    private float _rotationRate;
    public float maxRotation;

    bool rotAccelerating;
    bool accelerating;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)) accelerating = false;
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            accelerating = true;
            if (Input.GetKeyDown(KeyCode.W))_acceleration = acceleration;
            else _acceleration = -acceleration;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) rotAccelerating = false;
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            rotAccelerating = true;
            if (Input.GetKeyDown(KeyCode.A)) _rotationRate = -rotationRate;
            else _rotationRate = rotationRate;
        }

    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            if (z < velocity) z += _acceleration;
            else z = velocity;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (z > -velocity) z += _acceleration;
            else z = -velocity;
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (x > -maxRotation) x += _rotationRate;
            else x = -maxRotation;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (x < maxRotation) x += _rotationRate;
            else x = maxRotation;
        }
        if (!accelerating)
        {
            if (Mathf.Abs(z) > 0.5) z *= decceleration;
            else z = 0;           
        }
        if(!rotAccelerating)
        {
            if(Mathf.Abs(x) > 0.05) x *= rotationDecceleration;
            else x = 0;
        }
        direction = transform.forward.normalized * z;
        rotation = Vector3.up.normalized * x;
        transform.Rotate(rotation);
        //print(rb.velocity.magnitude + " " + maxVelocity);
        //if (rb.velocity.magnitude < maxVelocity)
        rb.velocity = direction;
    }
}
