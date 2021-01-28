﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Vector3 direction;
    public Vector3 rotation;

    public float x, z;

    public float acceleration;
    public float rotationRate;
    public float maxRotation;
    public float maxVelocity;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        z = 0;

        if (Input.GetKey(KeyCode.W) && rb.velocity.z < maxVelocity) z = acceleration;
        if (Input.GetKey(KeyCode.S) && rb.velocity.z > -maxVelocity) z = -acceleration;
        if (Input.GetKey(KeyCode.A) && x > -maxRotation) x += -rotationRate;
        if (Input.GetKey(KeyCode.D) && x < maxRotation) x += rotationRate;

        direction = transform.forward.normalized * z;
        rotation = transform.up.normalized * x;
        transform.Rotate(rotation);
        rb.velocity += direction;
    }
}
