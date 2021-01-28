using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinLight : MonoBehaviour
{
    public float spinSpeed = 0.37f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * spinSpeed);
    }
}
