using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    public float spinSpeed = 0.37f;

    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * spinSpeed);
    }
}
