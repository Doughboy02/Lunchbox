﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipRotation : MonoBehaviour
{
    public float zOffset;
    public float xOffset;
    public float yOffset;

    public Terrain terrain;
    public float front,center,back;
    private float left, right;

    Vector3 frontPosition, centerPosition, backPosition,leftPosition,rightPosition;

    private void Update()
    {
        frontPosition = transform.position + transform.forward.normalized * zOffset;
        centerPosition = transform.position;
        backPosition = transform.position - transform.forward.normalized * zOffset;

        leftPosition = transform.position - transform.right.normalized * xOffset;
        rightPosition = transform.position + transform.right.normalized * xOffset;

        front = Terrain.activeTerrain.SampleHeight(frontPosition);
        center = Terrain.activeTerrain.SampleHeight(centerPosition);
        back = Terrain.activeTerrain.SampleHeight(backPosition);
        left = Terrain.activeTerrain.SampleHeight(leftPosition);
        right = Terrain.activeTerrain.SampleHeight(rightPosition);

        backPosition = new Vector3(backPosition.x,back,backPosition.z);
        frontPosition = new Vector3(frontPosition.x,front,frontPosition.z);
        leftPosition = new Vector3(leftPosition.x, left, leftPosition.z);
        rightPosition = new Vector3(rightPosition.x, right, rightPosition.z);

        transform.parent.position = new Vector3(transform.parent.position.x, center - yOffset, transform.parent.position.z);
        Vector3 directionZ = frontPosition - backPosition;
        Vector3 directionX = rightPosition - leftPosition;
        float checkZ = Vector3.Angle(Vector3.up,directionZ);
        float checkX = Vector3.Angle(Vector3.up,directionX);
        //print(checkZ);
        //print(checkX);
        //if (checkZ > 90 + maxPitchRange) transform.Rotate(transform.right.normalized * pitchCorrectionRate);
        //if (checkZ < 90 - maxPitchRange) transform.Rotate(transform.right.normalized * -pitchCorrectionRate);
        //if (checkX < 90 - rollRange) transform.Rotate(transform.forward.normalized * -rollCorrectionRate);
        //if (checkX > 90 + rollRange) transform.Rotate(transform.forward.normalized * rollCorrectionRate);
        transform.rotation = Quaternion.Euler(-90 + checkZ,transform.rotation.eulerAngles.y, -90 + checkX);
        //transform.Rotate(transform.right.normalized * (back - front));
        //transform.Rotate(transform.forward.normalized * (left - right));
    }
}
