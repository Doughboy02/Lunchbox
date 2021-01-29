using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipRotation : MonoBehaviour
{
    public float zOffset;
    public float xOffset;
    public float yOffset;
    public float maxPitchAngle;
    public float pitchCorrectionRate;
    public float rollRange;
    public float rollCorrectionRate;
    public Terrain terrain;
    private float front,center,back;
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

        transform.position = new Vector3(transform.position.x, center - yOffset, transform.position.z);
        Vector3 directionZ = backPosition - frontPosition;
        Vector3 directionX = rightPosition - leftPosition;
        float checkZ = Vector3.Angle(Vector3.up,directionZ);
        float checkX = Vector3.Angle(Vector3.up,directionX);
        //print(checkZ);
        //print(checkX);
        if (checkZ > maxPitchAngle) transform.Rotate(transform.right.normalized * pitchCorrectionRate);
        if (checkX < 90 - rollRange) transform.Rotate(transform.forward.normalized * -rollCorrectionRate);
        if (checkX > 90 + rollRange) transform.Rotate(transform.forward.normalized * rollCorrectionRate);
        transform.Rotate(transform.right.normalized * (back - front));
        //transform.Rotate(transform.forward.normalized * (left - right));
    }
}
