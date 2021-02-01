using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInfo : MonoBehaviour
{
    public static ShipInfo instance;

    public bool wonGame = false;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
}
